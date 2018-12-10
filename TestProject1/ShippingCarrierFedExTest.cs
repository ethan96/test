﻿using eStore.BusinessModules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using eStore.POCOS;
using eStore.POCOS.DAL;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ShippingCarrierFedExTest and is intended
    ///to contain all ShippingCarrierFedExTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ShippingCarrierFedExTest
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
        ///A test for getFreightEstimation
        ///</summary>
        [TestMethod()]
        public void getFreightEstimationTest()
        {
            CartHelper target = new CartHelper(); // TODO: Initialize to an appropriate value
            Cart _cartmaster = target.getCartMastersbyUserID("alex.chiu@advantech.com.tw", "ABB");
            _cartmaster.removeAllItem();

            eStore.POCOS.Store store = _cartmaster.storeX;
            PartHelper helper = new PartHelper();
            Part product = helper.getPart("Test855-19751-2", store);
            _cartmaster.addItem(product, 1);

            var cartContact = new CartContact()
            {
                Address1 = "Test",
                State = "FL",
                Country = "USA",
                ZipCode = "33487"
            };

            _cartmaster.ShipToContact = cartContact;

            //string shippingcariername = "UPS_US_ABB"; // TODO: Initialize to an appropriate value
            string shippingcariername = "USPS_ABB"; // TODO: Initialize to an appropriate value

            showCart(_cartmaster);
            ShippingCarier shippingCarrier = ShippingCarierHelper.getShippingCarrier(shippingcariername);

            //ShippingCarrierABBFedEx forwarder = new ShippingCarrierABBFedEx(store, shippingCarrier);// TODO: Initialize to an appropriate value
            //ShippingCarrierABBUPS forwarder = new ShippingCarrierABBUPS(store, shippingCarrier);// TODO: Initialize to an appropriate value
            ShippingCarrierABBUSPS forwarder = new ShippingCarrierABBUSPS(store, shippingCarrier);// TODO: Initialize to an appropriate value



            //Cart cart = null; // TODO: Initialize to an appropriate value
            Address shipFromAddress = store.ShipFromAddress; // TODO: Initialize to an appropriate value
            //List<ShippingMethod> expected = null; // TODO: Initialize to an appropriate value
            List<ShippingMethod> actual = forwarder.getFreightEstimation(_cartmaster, shipFromAddress);
            int i = 1;
            foreach (ShippingMethod sm in actual)
            {
                if (sm.Error == null)
                {
                    if (i == 1 && actual.Count > 0)
                        showPackages(sm.PackingList);

                    Console.WriteLine("[" + i++ + "]");
                    Console.WriteLine("Discount: " + sm.Discount);
                    Console.WriteLine("Insured charge: " + sm.InsuredCharge);
                    Console.WriteLine("Negotiated rate :" + sm.NegotiatedRate);
                    Console.WriteLine("Negotiated rate surcharge: " + sm.NegotiatedRateSurcharge);
                    Console.WriteLine("Publish rate " + sm.PublishRate);
                    Console.WriteLine("Publish rate surcharge: " + sm.PublishRateSurcharge);
                    Console.WriteLine("Service code: " + sm.ServiceCode);
                    Console.WriteLine("Shipping carrier: " + sm.ShippingCarrier);
                    Console.WriteLine("Shipping cost with neogotiated rate: " + sm.ShippingCostWithNegotiatedRate);
                    Console.WriteLine("Shipping cost with publish rate: " + sm.ShippingCostWithPublishedRate);
                    Console.WriteLine("Shipping method description: " + sm.ShippingMethodDescription);
                    Console.WriteLine("Currency: " + sm.UnitOfCurrency);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Error level type: " + sm.Error.ErrorLevelType.ToString());
                    Console.WriteLine("Error code: " + sm.Error.Code.ToString());
                }

                if(sm.ServiceCode == "03")
                    Assert.AreEqual(22.25, sm.ShippingCostWithPublishedRate);
            }
            //Assert.AreEqual(3, actual.Count);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        public void showCart(Cart cart)
        {
            Console.WriteLine("== Show shopping cart ==");
            int i = 1;
            foreach (CartItem c in cart.CartItems)
            {
                Console.Write("Item " + i++ + "  ==>  ");
                Console.WriteLine(c.SProductID + ", Qty: " + c.Qty);
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        public void showPackages(PackingList packinglist)
        {
            Console.WriteLine();
            Console.WriteLine("== Show packing box detail == ");
            int i = 1;
            Console.WriteLine("Ship to zip code: " + packinglist.ShipTo.ZipCode);
            Console.WriteLine("Ship to state/province: " + packinglist.ShipTo.State);
            Console.WriteLine("Ship to country code: " + packinglist.ShipTo.countryCodeX);
            Console.WriteLine("Ship from zip code: " + packinglist.ShipFrom.ZipCode);
            Console.WriteLine("Ship from state/province: " + packinglist.ShipFrom.State);
            Console.WriteLine("Ship from country code: " + packinglist.ShipFrom.countryCodeX);
            foreach (PackagingBox b in packinglist.PackagingBoxes)
            {
                Console.WriteLine(i++ + ", (L: " + b.Length + ", W: " + b.Weight + ", H: " + b.Height + "), Weight: " + b.Weight + b.WeightUnit);
            }
            Console.WriteLine();
        }
    }
}
