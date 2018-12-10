﻿using eStore.POCOS.Sync;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using eStore.POCOS;
using eStore.POCOS.DAL;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for CTOSComponentSyncTest and is intended
    ///to contain all CTOSComponentSyncTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CTOSComponentSyncTest
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
        ///A test for syncCTOScomponent
        ///</summary>
        [TestMethod()]
        public void syncCTOScomponentTest()
        {
            CTOSComponentSync target = new CTOSComponentSync(); // TODO: Initialize to an appropriate value
            Store store = new StoreHelper().getStorebyStoreid("AKR"); // TODO: Initialize to an appropriate value
            target.syncCTOScomponent(store);
                      

            //store = new StoreHelper().getStorebyStoreid("AEU"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);          
           
            //store = new StoreHelper().getStorebyStoreid("ATW"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);

            //store = new StoreHelper().getStorebyStoreid("ACN"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);

            //store = new StoreHelper().getStorebyStoreid("AKR"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);

            //store = new StoreHelper().getStorebyStoreid("AJP"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);

            //store = new StoreHelper().getStorebyStoreid("AAU"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);

            //store = new StoreHelper().getStorebyStoreid("SAP"); // TODO: Initialize to an appropriate value
            //target.syncCTOScomponent(store);


            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }


 
    }
}