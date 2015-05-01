using System.Collections.Generic;
using System.Linq;
using CSJSONBacklog.Communicator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSJSONBacklogTest
{
    /// <summary>
    ///SpaceCommunicatorTest のテスト クラスです。すべての
    ///SpaceCommunicatorTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class SpaceCommunicatorTest : AbstractTestBase
    {
        /// <summary>
        ///現在のテストの実行についての情報および機能を
        ///提供するテスト コンテキストを取得または設定します。
        ///</summary>
        public TestContext TestContext { get; set; }

        public static TestData TestData { get; set; }

        #region 追加のテスト属性
        // 
        //テストを作成するときに、次の追加属性を使用することができます:
        //
        //クラスの最初のテストを実行する前にコードを実行するには、ClassInitialize を使用
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            TestData = TestData.CreateNew("SpaceCommunicatorTestData.json");
            SpaceName = TestData.SpaceName;
            APIKey = TestData.APIKey;
        }
        //クラスのすべてのテストを実行した後にコードを実行するには、ClassCleanup を使用
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //各テストを実行する前にコードを実行するには、TestInitialize を使用
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //各テストを実行した後にコードを実行するには、TestCleanup を使用
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        #region ConstructorTest
        [TestMethod]
        public void SpaceCommunicatorConstructorTest1()
        {
            string spacename = string.Empty;
            string apiKey = string.Empty;
            try
            {
                var ic = new SpaceCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void SpaceCommunicatorConstructorTest2()
        {
            const string spacename = "InvalidDummyValue";
            string apiKey = string.Empty;
            try
            {
                var ic = new SpaceCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void SpaceCommunicatorConstructorTest3()
        {
            string spacename = string.Empty;
            const string apiKey = "InvalidDummyValue";
            try
            {
                var ic = new SpaceCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("unexpected");
        }

        [TestMethod]
        public void SpaceCommunicatorConstructorTest4()
        {
            const string spacename = "SPACENAMETEST";
            const string apiKey = "APIKEYTEST";
            try
            {
                var ic = new SpaceCommunicator(spacename, apiKey);
            }
            catch (ArgumentNullException)
            {
                Assert.Fail("unexpected");
            }
        }
        #endregion ConstructorTest


        /// <summary>
        /// GetUserList
        ///</summary>
        [TestMethod]
        public void GetUserListTest()
        {
            var target = new SpaceCommunicator(SpaceName, APIKey);
            var actual = target.GetUserList();
            Assert.AreNotEqual(actual.Count(), 0);
        }
    }
}
