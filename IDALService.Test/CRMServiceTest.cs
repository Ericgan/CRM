﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM.IDALServices;
using CRM.IDALServices.Test.Fake;
using CRM.DALServices;
using CRM.Model;

namespace CRM.IDALServices.Test
{
    [TestClass]
    public class CRMServiceTest
    {
        private ICRMService service = null;

        [TestInitialize]
        public void TestInitialize()
        {
            IDALContext dal = new FakeDALContext();
            service = new CRMService(dal);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void GetPkgOrdersTest()
        {
            var query = service.GetPkgOrders();
            Assert.AreEqual(query.Count(), 6, "PkgOrder数量不对");
        }

        [TestMethod]
        public void GetPkgOrderTest()
        {
            int orderId = 4;
            PkgOrder order = service.GetPkgOrder(orderId);
            Assert.IsNotNull(order);
            Assert.AreEqual<int>(orderId, order.OrderId);
        }
    }
}