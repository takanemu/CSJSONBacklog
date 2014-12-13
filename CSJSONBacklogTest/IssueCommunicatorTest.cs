using System.Collections.Generic;
using System.Linq;
using CSJSONBacklog.Communicator;
using CSJSONBacklog.Model.Issues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSJSONBacklogTest
{
    /// <summary>
    ///IssueCommunicatorTest のテスト クラスです。すべての
    ///IssueCommunicatorTest 単体テストをここに含めます
    ///</summary>
    [TestClass]
    public class IssueCommunicatorTest : AbstractTestBase
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
            TestData = TestData.CreateNew("IssueCommunicatorTestData.json");
            SpaceName = TestData.SpaceName;
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
        #endregion

        #region ConstructorTest
        [TestMethod]
        public void IssueCommunicatorConstructorTest1()
        {
            string spacename = string.Empty;
            string apiKey = string.Empty;
            try
            {
                var ic = new IssueCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void IssueCommunicatorConstructorTest2()
        {
            const string spacename = "InvalidDummyValue";
            string apiKey = string.Empty;
            try
            {
                var ic = new IssueCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void IssueCommunicatorConstructorTest3()
        {
            string spacename = string.Empty;
            const string apiKey = "InvalidDummyValue";
            try
            {
                var ic = new IssueCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void IssueCommunicatorConstructorTest4()
        {
            const string spacename = "SPACENAMETEST";
            const string apiKey = "APIKEYTEST";
            try
            {
                var ic = new IssueCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                Assert.Fail("unexpected");
            }
        }
        #endregion



        /// <summary>
        ///GetIssue のテスト
        ///</summary>
        [TestMethod]
        public void GetIssueTest()
        {
            var target = new IssueCommunicator(SpaceName, APIKey);
            var actual = target.GetIssue(TestData.IssueIdOrKey);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual(actual.id, 0);
        }

        /// <summary>
        ///GetIssues のテスト
        ///</summary>
        [TestMethod]
        public void GetIssuesTest()
        {
            var target = new IssueCommunicator(SpaceName, APIKey);
            // issues in a project
            var param = new QueryIssueParameters
            {
                ProjectIds = new List<int> { TestData.ProjectId },
                ParentChild = ParentChild.All,
                Offset = 0,
                Count = 100,// per 100 max
                Order = Order.Asc,
                Sort = Sort.Created
            };
            var actual = target.GetIssues(param);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }

        /// <summary>
        ///GetIssuesCount のテスト
        ///</summary>
        [TestMethod]
        public void GetIssuesCountTest()
        {
            var target = new IssueCommunicator(SpaceName, APIKey);
            var actual = target.GetIssuesCount(TestData.ProjectId);
            Assert.AreNotEqual(actual, 0);
        }

        /// <summary>
        ///GetIssuesCount のテスト
        ///</summary>
        [TestMethod]
        public void GetIssuesCountTest1()
        {
            var target = new IssueCommunicator(SpaceName, APIKey);
            var actual = target.GetIssuesCount(TestData.ProjectIds);
            Assert.AreNotEqual(actual, 0);
        }

        /// <summary>
        ///UpdateIssue のテスト
        ///</summary>
        [TestMethod()]
        public void UpdateIssueTest()
        {
            var target = new IssueCommunicator(SpaceName, APIKey);
            
            var issue = target.GetIssue(TestData.IssueIdOrKey);
            var desc = " Update by Test @" + DateTime.Now;
            issue.description += desc;
            issue.dueDate = null;
            var actual = target.UpdateIssue(issue);
            
            Assert.AreNotEqual(actual.id, 0);
            Assert.IsTrue(actual.description.Contains(desc));
        }
    }
}
