using System.Globalization;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl;
using Microsoft.VisualStudio.TeamFoundation;
using Microsoft.VisualStudio.TeamFoundation.VersionControl;
using BestMerge.Core;
using BestMerge.Entity;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace BestMerge
{
    [ProvideToolboxControl("BestMerge.FindForm", false)]
    public partial class FindForm : Form
    {
        private readonly TfsHelper _tfs = new BestMerge.Core.TfsHelper();
        private string _criteria;
        private DateTime? _endDate;
        private string _fromBranch;
        private string _owner;
        private int _sortColumn = -1;
        private DateTime? _startDate;
        private string _statusMessage;
        private string _toBranch;


        public string DefaultCollectionUrl { get; set; }

        public IPackage CallerPackage { get; set; }

        public FindForm()
        {
            InitializeComponent();
        }

        private void CbTeamProjectCollectionSelectedIndexChanged(object sender, EventArgs e)
        {
            lwChangesets.Items.Clear();
            cbTeamProject.DisplayMember = "DisplayName";
            cbTeamProject.ValueMember = "ProjectId";
            cbTeamProject.DataSource = ((TfsProjectCollection)cbTeamProjectCollection.SelectedItem).TeamProjects;
        }

        private void cbMergeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lwChangesets.Items.Clear();
        }

        private void BtnGetChangesetsClick(object sender, EventArgs e)
        {
            SetUserAction(UserActionEnum.GettingChangesetList);
            lwChangesets.Items.Clear();
            if (dpFrom.Checked)
                _startDate = dpFrom.Value;
            if (dpTo.Checked)
                _endDate = dpTo.Value;
            _fromBranch = cbMergeFrom.Text;
            _toBranch = cbMergeTo.Text;
            _owner = cbTeamProjectContributors.SelectedValue?.ToString();
            _criteria = txtCriteria.Text;
            bwWorker.RunWorkerAsync("GettingChangesetList");
        }

        private void CbTeamProjectSelectedIndexChanged(object sender, EventArgs e)
        {
            lwChangesets.Items.Clear();
            if (cbTeamProject.SelectedItem == null)
                return;
            cbMergeFrom.DisplayMember = "DisplayName";
            cbMergeFrom.ValueMember = "DisplayName";
            cbMergeFrom.DataSource = ((TfsProject)cbTeamProject.SelectedItem).Branches;
            cbTeamProjectContributors.DataSource = ((TfsProject)cbTeamProject.SelectedItem).Contributors;
        }

        private void CbMergeFromSelectedIndexChanged(object sender, EventArgs e)
        {
            lwChangesets.Items.Clear();
            if (cbMergeFrom.SelectedItem == null)
                return;
            cbMergeTo.DisplayMember = "DisplayName";
            cbMergeTo.ValueMember = "DisplayName";
            cbMergeTo.DataSource = ((TfsBranch)cbMergeFrom.SelectedItem).ChildBranches;
        }

        private void LwChangesetsColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != _sortColumn)
            {
                _sortColumn = e.Column;
                lwChangesets.Sorting = SortOrder.Ascending;
            }
            else
                lwChangesets.Sorting = lwChangesets.Sorting == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
            lwChangesets.Sort();
            lwChangesets.ListViewItemSorter = new ListViewItemComparer(e.Column, lwChangesets.Sorting);
        }

        private void LwChangesetsDoubleClick(object sender, EventArgs e)
        {
            if (lwChangesets.SelectedItems.Count <= 0)
                return;
            CallerPackage.OpenChangeSetDetails(int.Parse(lwChangesets.SelectedItems[0].Text));
        }

        private void LwChangesetsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && lwChangesets.SelectedItems.Count > 0)
            {
                lwChangesets.Items.RemoveAt(lwChangesets.SelectedIndices[0]);
                SetUserAction(UserActionEnum.Ready);
            }
            else
            {
                if (e.KeyData != Keys.F9 || lwChangesets.SelectedItems.Count <= 0)
                    return;
                _tfs.Merge(_fromBranch, _toBranch, lwChangesets.SelectedItems[0].Text);
                var resolution = Resolution.AcceptMerge;
                if (radYours.Checked)
                    resolution = Resolution.AcceptYours;
                else if (radTheirs.Checked)
                    resolution = Resolution.AcceptTheirs;
                if (
                    !_tfs.ResolveConflicts(_toBranch, resolution, chkAutoCheckin.Checked,
                        lwChangesets.SelectedItems[0].SubItems[3].Text))
                {
                    _statusMessage = _tfs.ErrorMessage;
                    SetUserAction(UserActionEnum.Error);
                }
                else
                {
                    var index = lwChangesets.SelectedIndices[0];
                    lwChangesets.Items.RemoveAt(index);
                    if (lwChangesets.Items.Count <= index)
                        index = lwChangesets.Items.Count - 1;
                    if (index >= 0)
                        lwChangesets.Items[index].Selected = true;
                    SetUserAction(UserActionEnum.Ready);
                }
            }
        }

        private void BwWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var str = e.Argument.ToString();
            switch (str)
            {
                case "Load":
                    TfsLoad();
                    break;
                case "GettingChangesetList":
                    TfsGettingChangeSetList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void TfsGettingChangeSetList()
        {
            var tfsMergeCanditateList =
                _tfs.GetMergeCandidates(_fromBranch, _toBranch, _owner, _startDate, _endDate, _criteria);

            foreach (var tfsMergeCandidate in tfsMergeCanditateList)
            {
                if (lwChangesets.InvokeRequired)
                {
                    var c1 = tfsMergeCandidate;
                    lwChangesets.Invoke((Action) (() => lwChangesets.Items.Add(new ListViewItem(new string[4]
                    {
                        c1.ChangesetId.ToString(CultureInfo.InvariantCulture),
                        c1.Owner,
                        c1.CreationDate.ToString(),
                        c1.Comment
                    }))));
                }
                else
                    lwChangesets.Items.Add(new ListViewItem(new string[4]
                    {
                        tfsMergeCandidate.ChangesetId.ToString(CultureInfo.InvariantCulture),
                        tfsMergeCandidate.Owner,
                        tfsMergeCandidate.CreationDate.ToString(CultureInfo.InvariantCulture),
                        tfsMergeCandidate.Comment
                    }));
            }
        }

        private void TfsLoad()
        {
            _tfs.Initialize(DefaultCollectionUrl);
            if (cbTeamProjectCollection.InvokeRequired)
                cbTeamProjectCollection.Invoke(
                    (Action)(() => cbTeamProjectCollection.DataSource = (object)_tfs.TeamProjectCollections));
            else
                cbTeamProjectCollection.DataSource = _tfs.TeamProjectCollections;
        }

        private void BwWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetUserAction(UserActionEnum.Ready);
        }

        public void FindFormLoad(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DefaultCollectionUrl))
            {
                //TODO picker is not work, that can be dependent assemblies
                var teamProjectPicker = new TeamProjectPicker(TeamProjectPickerMode.NoProject, false);
                var num = (int) teamProjectPicker.ShowDialog();
                var projectCollection = teamProjectPicker.SelectedTeamProjectCollection;
                if (projectCollection != null)
                    DefaultCollectionUrl = projectCollection.ConfigurationServer.Uri.ToString(); 
            } 

            if (string.IsNullOrEmpty(DefaultCollectionUrl))
            {
                _statusMessage = "No TFS connection info founded.";
                btnGetChangesets.Enabled = false;
                SetUserAction(UserActionEnum.Error);
            }
            else
            {
                SetUserAction(UserActionEnum.FormLoading);
                dpFrom.Value = DateTime.Now.AddMonths(-1);
                cbTeamProjectCollection.DisplayMember = "DisplayName";
                cbTeamProjectCollection.ValueMember = "InstanceId";
                bwWorker.RunWorkerAsync("Load");
            }
        } 

        private void SetUserAction(UserActionEnum action)
        {
            toolBarText.ResetForeColor();
            switch (action)
            {
                case UserActionEnum.Ready:
                    toolBarProcess.Style = ProgressBarStyle.Continuous;
                    toolBarText.Text = "Ready to action.";
                    btnGetChangesets.Enabled = true;
                    break;
                case UserActionEnum.FormLoading:
                    toolBarProcess.Style = ProgressBarStyle.Marquee;
                    toolBarText.Text = string.Format("Connecting to TFS: {0}", DefaultCollectionUrl);
                    btnGetChangesets.Enabled = false;
                    break;
                case UserActionEnum.GettingChangesetList:
                    toolBarProcess.Style = ProgressBarStyle.Marquee;
                    toolBarText.Text = "Getting changeset list...";
                    btnGetChangesets.Enabled = false;
                    break;
                case UserActionEnum.Error:
                    toolBarProcess.Style = ProgressBarStyle.Continuous;
                    toolBarText.ForeColor = Color.Red;
                    toolBarText.Text = _statusMessage;
                    btnGetChangesets.Enabled = true;
                    break;
            }
        }
        private enum UserActionEnum
        {
            Ready,
            FormLoading,
            GettingChangesetList,
            Error
        }
    }

}
