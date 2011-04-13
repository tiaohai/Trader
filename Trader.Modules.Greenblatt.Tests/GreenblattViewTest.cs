﻿using System.Windows.Markup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trader.Modules.Greenblatt.ViewModels;
using Trader.Modules.Greenblatt.Views;

namespace Trader.Modules.Greenblatt.Tests
{
    
    
    /// <summary>
    ///This is a test class for GreenblattViewTest and is intended
    ///to contain all GreenblattViewTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GreenblattViewTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GreenblattView Constructor
        ///</summary>
        [TestMethod()]
        public void GreenblattViewConstructorTest()
        {
            IGreenblattViewModel model = null; // TODO: Initialize to an appropriate value
            GreenblattView target = new GreenblattView(model);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            IGreenblattViewModel model = null; // TODO: Initialize to an appropriate value
            GreenblattView target = new GreenblattView(model); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Trader.Modules.Greenblatt.dll")]
        public void ConnectTest()
        {
            IGreenblattViewModel model = null; // TODO: Initialize to an appropriate value
            IComponentConnector target = new GreenblattView(model); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
