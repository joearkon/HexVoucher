using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using HexVoucherWebService;

namespace UnitTest
{
    [TestClass]
    public class HexSalesIFServiceWebService
    {
        [TestMethod]
        public void VoucherQuery()
        {
            var service = new HexVoucherWebService.Test2Request();
            
             
            Assert.AreEqual(1,1);
        }
    }
}
