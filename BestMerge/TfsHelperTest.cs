using System;
using System.Linq;
using BestMerge.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestMerge.Test
{
    [TestClass]
    public class TfsHelperTest
    {
        [TestMethod]
        public void Load_WhenInitialize_FillTeamProjectCollections()
        {
            var tfsHelper = new TfsHelper();

            tfsHelper.Initialize("http://legedema:8080/tfs/defaultcollection");

            var sigortaNetchildBranchesCount = tfsHelper.TeamProjectCollections
                .FirstOrDefault(x => x.DisplayName.Equals("DefaultCollection")).TeamProjects
                .FirstOrDefault(x => x.DisplayName.Equals("SigortaNet")).Branches.First().ChildBranches.Count;

            Assert.IsTrue(string.IsNullOrEmpty(tfsHelper.ErrorMessage));
            Assert.AreEqual(14, sigortaNetchildBranchesCount); 
        }

        [TestMethod]
        public void GetPrrojectContributorList()
        {
            var tfsHelper = new TfsHelper();

            tfsHelper.Initialize("http://legedema:8080/tfs/defaultcollection");
            var userList = tfsHelper.GetPrrojectContributorList();

            Assert.IsTrue(userList.Count > 1);

        }



    }
}
