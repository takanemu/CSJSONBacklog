using System.Linq;
using CSJSONBacklog.Communicator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSJSONBacklogTest
{
    /// <summary>
    ///ProjectCommunicatorTest クラスです。すべての
    ///ProjectCommunicatorTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class ProjectCommunicatorTest : AbstractTestBase
    {
        /// <summary>
        ///現在のテストの実行についての情報および機能を
        ///提供するテスト コンテキストを取得または設定します。
        ///</summary>
        public TestContext TestContext { get; set; }

        public static TestData TestData { get; set; }

        #region 追加のテスト属性
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            TestData = TestData.CreateNew("ProjectCommunicatorTestData.json");
            SpaceKey = TestData.SpaceName;
            APIKey = TestData.APIKey;
        }
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        #region ConstructorTest
        [TestMethod]
        public void ProjectCommunicatorConstructorTest1()
        {
            string spacename = string.Empty;
            string apiKey = string.Empty;
            try
            {
                var ic = new ProjectCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void ProjectCommunicatorConstructorTest2()
        {
            const string spacename = "InvalidDummyValue";
            string apiKey = string.Empty;
            try
            {
                var ic = new ProjectCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void ProjectCommunicatorConstructorTest3()
        {
            string spacename = string.Empty;
            const string apiKey = "InvalidDummyValue";
            try
            {
                var ic = new ProjectCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void ProjectCommunicatorConstructorTest4()
        {
            const string spacename = "SPACENAMETEST";
            const string apiKey = "APIKEYTEST";
            try
            {
                var ic = new ProjectCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                Assert.Fail("unexpected");
            }
        }
        #endregion ConstructorTest

        /// <summary>
        ///AddProject
        ///</summary>
        [TestMethod]
        public void AddProjectTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///AddProjectAdministrator
        ///</summary>
        [TestMethod]
        public void AddProjectAdministratorTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///AddProjectUser
        ///</summary>
        [TestMethod]
        public void AddProjectUserTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///DeleteProject
        ///</summary>
        [TestMethod]
        public void DeleteProjectTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///DeleteProjectAdministrator
        ///</summary>
        [TestMethod]
        public void DeleteProjectAdministratorTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///DeleteProjectUser
        ///</summary>
        [TestMethod]
        public void DeleteProjectUserTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///GetCategoryList
        ///</summary>
        [TestMethod]
        public void GetCategoryListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetCategoryList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetCustomFieldList
        ///</summary>
        [TestMethod]
        public void GetCustomFieldListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetCustomFieldList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetIssueTypeList
        ///</summary>
        [TestMethod]
        public void GetIssueTypeListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetIssueTypeList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetListofGitRepositories
        ///</summary>
        [TestMethod]
        public void GetListofGitRepositoriesTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetListofGitRepositories(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetListofGroups
        ///</summary>
        [TestMethod]
        public void GetListofGroupsTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetListofGroups(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetListofRecentlyViewedIssues
        ///</summary>
        [TestMethod]
        public void GetListofRecentlyViewedIssuesTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetListofRecentlyViewedIssues(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetListofRecentlyViewedProjects
        ///</summary>
        [TestMethod]
        public void GetListofRecentlyViewedProjectsTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetListofRecentlyViewedProjects(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetListofRecentlyViewedProjects
        ///</summary>
        [TestMethod]
        public void GetListofRecentlyViewedProjectsTest1()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetListofRecentlyViewedProjects(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetListofRecentlyViewedWikis
        ///</summary>
        [TestMethod]
        public void GetListofRecentlyViewedWikisTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetListofRecentlyViewedWikis(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetProject
        ///</summary>
        [TestMethod]
        public void GetProjectTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetProject(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Id, 0);
        }

        /// <summary>
        ///GetProjectAdministrator
        ///</summary>
        [TestMethod]
        public void GetProjectAdministratorTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetProjectAdministrator(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Id, 0);
        }

        /// <summary>
        ///GetProjectAdministratorList
        ///</summary>
        [TestMethod]
        public void GetProjectAdministratorListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetProjectAdministratorList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetProjectDiskUsage
        ///</summary>
        [TestMethod]
        public void GetProjectDiskUsageTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetProjectDiskUsage(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.ProjectId, 0);
        }

        /// <summary>
        ///GetProjectIcon
        ///</summary>
        [TestMethod]
        public void GetProjectIconTest()
        {
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///GetProjectList
        ///</summary>
        [TestMethod]
        public void GetProjectListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetProjectList();
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetProjectRecentUpdate
        ///</summary>
        [TestMethod]
        public void GetProjectRecentUpdateTest()
        {
            Assert.Inconclusive("Assert.Inconclusive");
        }

        /// <summary>
        ///GetProjectUserList
        ///</summary>
        [TestMethod]
        public void GetProjectUserListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetProjectUserList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///GetVersionList
        ///</summary>
        [TestMethod]
        public void GetVersionListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetVersionList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }

        /// <summary>
        ///UpdateProject
        ///</summary>
        [TestMethod]
        public void UpdateProjectTest()
        {
            Assert.Inconclusive("Assert.Inconclusive");
        }



        /// <summary>
        ///GetVersionList
        ///</summary>
        [TestMethod]
        public void GetGetWikiPageListTest()
        {
            var target = new ProjectCommunicator(SpaceKey, APIKey);
            var actual = target.GetWikiPageList(TestData.ProjectIdOrKey);
            Assert.AreNotEqual(actual.Count(), 0);
        }
    }
}
