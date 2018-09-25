using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BestMerge.Entity;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.VersionControl.Common;

namespace BestMerge.Core
{
    public class TfsHelper
    {

        private VersionControlServer _versionControl;
        private TfsTeamProjectCollection _tfsProjectCollection;

        private string _rootUrl { get; set; }

        public string ErrorMessage { get; private set; }

        public List<TfsProjectCollection> TeamProjectCollections { get; } = new List<TfsProjectCollection>();

        private Workspace Workspace { get; set; }

        public void Initialize(string rootUrl)
        {
            _rootUrl =
                  new TfsTeamProjectCollection(new Uri(rootUrl)).ConfigurationServer.Uri.ToString();
            _tfsProjectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(_rootUrl));
            _tfsProjectCollection.EnsureAuthenticated();
            _versionControl = _tfsProjectCollection.GetService<VersionControlServer>();

            FillWorkSpace();
            FillProjectCollection();
        }

        private void FillWorkSpace()
        {
            var workspaceArray = _versionControl.QueryWorkspaces(null, _versionControl.AuthenticatedUser,
                Environment.MachineName);
            if ((uint)workspaceArray.Length > 0U)
                Workspace = workspaceArray[0];
        }

        private void FillProjectCollection()
        {
            var configurationServer = TfsConfigurationServerFactory.GetConfigurationServer(new Uri(_rootUrl));
            var catalogNodes = configurationServer.CatalogNode.QueryChildren(
                new Guid[1] { CatalogResourceTypes.ProjectCollection },
                false, CatalogQueryOptions.None);

            foreach (var catalogNode1 in catalogNodes)
            {
                var projectCollection = new TfsProjectCollection
                {
                    DisplayName = catalogNode1.Resource.DisplayName,
                    InstanceId = catalogNode1.Resource.Properties["InstanceId"],
                    TeamProjects = FillTeamProjects(catalogNode1)
                };

                TeamProjectCollections.Add(projectCollection);
            }
        }

        private List<TfsProject> FillTeamProjects(CatalogNode catalogNode1)
        {
            var result = new List<TfsProject>();

            var projectBranches = GetProjectBranches();

            foreach (
                var catalogNode2 in
                catalogNode1.QueryChildren(new Guid[1] { CatalogResourceTypes.TeamProject }, false,
                    CatalogQueryOptions.None))
            {
                var tfsProject = new TfsProject
                {
                    DisplayName = catalogNode2.Resource.DisplayName,
                    ProjectId = catalogNode2.Resource.Properties["ProjectId"],
                    ProjectUri = catalogNode2.Resource.Properties["ProjectUri"]
                };

                foreach (var tfsBranch in projectBranches)
                {
                    if (tfsBranch.DisplayName.ToUpper().Contains(tfsProject.DisplayName.ToUpper()))
                    {
                        if (tfsProject.Branches == null)
                            tfsProject.Branches = new List<TfsBranch>();
                        tfsProject.Branches.Add(tfsBranch);
                    }
                }

                if (tfsProject.Branches != null)
                {
                    tfsProject.Contributors = GetPrrojectContributorList();
                    result.Add(tfsProject);
                }
            }

            return result.OrderByDescending(p => p.Branches[0].ChildBranches.Count).ToList();
        }

        public List<string> GetPrrojectContributorList()
        {
            var projecContributorList = new List<string>() { "" };

            IIdentityManagementService ims = _tfsProjectCollection.GetService<IIdentityManagementService>();
            var sids = ims.ReadIdentity(IdentitySearchFactor.AccountName, "Project Collection Valid Users", MembershipQuery.Expanded, ReadIdentityOptions.IncludeReadFromSource);

            var ud = ims.ReadIdentities(sids.Members, MembershipQuery.Expanded, ReadIdentityOptions.IncludeReadFromSource);
            var members = ud.Where(u => !u.IsContainer).ToArray().Select(m => m.UniqueName);

            ////add all users into team project Contributors group
            //foreach (var member in members)
            //{
            //    var userIdentity = ims.ReadIdentity(IdentitySearchFactor.AccountName, member, MembershipQuery.None, ReadIdentityOptions.IncludeReadFromSource);
            //} 

            projecContributorList.AddRange(members.ToList());

            //var groupSecurityService =
            //    (IGroupSecurityService)_tfsProjectCollection.GetService(typeof(IGroupSecurityService));

            //var identity1 = groupSecurityService.ReadIdentity(SearchFactor.EveryoneApplicationGroup, null,
            //    QueryMembership.Direct);

            //var identityArray = groupSecurityService.ReadIdentities(SearchFactor.Sid, identity1.Members,
            //    QueryMembership.None);

            //foreach (
            //    var identity2 in
            //    identityArray.Where(u => u.Domain == tfsProject.ProjectUri)
            //        .ToArray()
            //        .Where(g => g.DisplayName.Equals("Contributors")))
            //{
            //    var identity3 = groupSecurityService.ReadIdentity(SearchFactor.Sid, identity2.Sid,
            //        QueryMembership.Expanded);
            //    if (identity3.Members.Length != 0)
            //    {
            //        foreach (
            //            var identity4 in
            //            groupSecurityService.ReadIdentities(SearchFactor.Sid, identity3.Members,
            //                    QueryMembership.None)
            //                .Where(u => !u.SecurityGroup)
            //                .OrderBy(u => u.DisplayName)
            //                .ToArray())
            //        {

            //            projecContributorList.Add(identity4.DisplayName);
            //        }
            //    }
            //}

            return projecContributorList;
        }


        public void GetUserList()
        {
            IIdentityManagementService ims = (IIdentityManagementService)_tfsProjectCollection.GetService(typeof(IIdentityManagementService));
            // get all valid users of the collection
            TeamFoundationIdentity SIDS = ims.ReadIdentity(IdentitySearchFactor.AccountName, "Project Collection Valid Users", MembershipQuery.Expanded, ReadIdentityOptions.ExtendedProperties);
            List<string> ids = new List<string>();
            foreach (var member in SIDS.Members)
            {
                ids.Add(member.Identifier);
            }

            // get user objects for existing SIDS
            TeamFoundationIdentity[][] UserId = ims.ReadIdentities(IdentitySearchFactor.Identifier, ids.ToArray(), MembershipQuery.None, ReadIdentityOptions.ExtendedProperties);
            // convert to list
            List<TeamFoundationIdentity> UserIds = UserId.SelectMany(T => T).ToList();

            foreach (TeamFoundationIdentity user in UserIds)
            {
                // exclude groups in listing
                if (!user.IsContainer)
                {
                    //do what you want with the user
                }
            }
        }

        private List<TfsBranch> GetProjectBranches()
        {
            var projectBranches = new List<TfsBranch>();

            foreach (var branchObject in _versionControl.QueryRootBranchObjects(RecursionType.Full))
            {
                var tfsBranch = new TfsBranch
                {
                    DisplayName = branchObject.Properties.RootItem.Item
                };

                if ((uint)branchObject.ChildBranches.Length > 0U)
                {
                    tfsBranch.ChildBranches = new List<TfsBranch>();
                    foreach (var itemIdentifier in branchObject.ChildBranches)
                        tfsBranch.ChildBranches.Add(new TfsBranch
                        {
                            DisplayName = itemIdentifier.Item
                        });
                    projectBranches.Add(tfsBranch);
                }
            }

            return projectBranches;
        }
        
        //todo regex 
        //todo first query changset and look, is it merge candidate. maybe quicker
        public List<TfsMergeCandidate> GetMergeCandidates(string fromBranch, string toBranch, string user,
           DateTime? startDate, DateTime? endDate, string criteria)
        {
            var source =
                _versionControl.GetMergeCandidates(fromBranch, toBranch, RecursionType.Full)
                    .Select(m => new TfsMergeCandidate
                    {
                        Owner = m.Changeset.Owner,
                        CreationDate = m.Changeset.CreationDate,
                        ChangesetId = m.Changeset.ChangesetId,
                        Comment = m.Changeset.Comment
                    });

            if (!string.IsNullOrEmpty(user))
                source = source.Where(m => m.Owner.ToUpper().Contains(user.ToUpper()));
            if (startDate.HasValue)
                source = source.Where(m =>
                {
                    var creationDate = m.CreationDate;
                    var date1 = creationDate.Date;
                    creationDate = startDate.Value;
                    var date2 = creationDate.Date;
                    return date1 >= date2;
                });
            if (endDate.HasValue)
                source = source.Where(m =>
                {
                    var creationDate = m.CreationDate;
                    var date1 = creationDate.Date;
                    creationDate = endDate.Value;
                    var date2 = creationDate.Date;
                    return date1 <= date2;
                });
            if (!string.IsNullOrEmpty(criteria))
                source = source.Where(m =>
                {
                    if (m.Comment.ToUpper().Contains(criteria.ToUpper()))
                        return true;
                    if (IsNumber(criteria))
                        return m.ChangesetId == int.Parse(criteria);
                    return false;
                });
            return source.ToList();
        }

        public Changeset GetChangeSetDetails(int changeSetId)
        {
            return _versionControl.GetChangeset(changeSetId);
        }

        public GetStatus Merge(string fromBranch, string toBranch, string changesetId)
        {
            return Workspace.Merge(fromBranch, toBranch, VersionSpec.ParseSingleSpec(changesetId, null),
                VersionSpec.ParseSingleSpec(changesetId, null), LockLevel.None, RecursionType.Full, MergeOptions.None);
        }

        public bool ResolveConflicts(string toBranch, Resolution resolution, bool autoCheckin, string comment)
        {
            var flag = true;
            var workspace = Workspace;
            var pathFilters = new string[1]
            {
                toBranch
            };

            var num = 1;
            foreach (var conflict in workspace.QueryConflicts(pathFilters, num != 0))
            {
                if (Workspace.MergeContent(conflict, true))
                {
                    conflict.Resolution = resolution;
                    Workspace.ResolveConflict(conflict);
                }

                if (conflict.IsResolved)
                {
                    Workspace.PendEdit(conflict.TargetLocalItem);
                    try
                    {
                        File.Copy(conflict.MergedFileName, conflict.TargetLocalItem, true);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            if (autoCheckin)
            {
                var pendingChanges = Workspace.GetPendingChanges();
                if (pendingChanges != null || pendingChanges.Any())
                {
                    try
                    {
                        Workspace.CheckIn(pendingChanges, comment);
                    }
                    catch (Exception ex)
                    {
                        flag = false;
                        ErrorMessage = ex.Message;
                    }
                }
            }
            return flag;
        }

        private bool IsNumber(string text)
        {
            return new Regex("^[-+]?[0-9]*\\.?[0-9]+$").IsMatch(text);
        }
    }

}
