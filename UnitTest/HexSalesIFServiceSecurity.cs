using Microsoft.VisualStudio.TestTools.UnitTesting;
using HexSalesIF_Service.util;
using System;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class HexSalesIFServiceSecurity
    {
        /// <summary>
        /// «©√˚≥…π¶≤‚ ‘
        /// </summary>
        [TestMethod]
        public void SignTestTrue()
        {
            var s = WebSecurity.Sign("a=1&b=2", WebSecurity.GetXmlString("VendorPrivateKey.xml"));
            Assert.AreEqual(s, "Vz8Zs6PN7EhhtCVhLP5s53vMhWBCG5+6PeUIO6Gnq1ODccNnk9NOVbhV3hHDfz8BQbH6u05x1rE7qg/VdF7OGwpp6TvcS2jdH0zALhyerIL6Sido1fOqcSh0nUalspZEEkSP0UCwsq5tTWxP5Bqg9tBlA8vNmgmYuAcsDyk/bTVxfv/PQ5FRofRNjIoBjHbjfeWXJZSs0oK+PaiQH8bViifAp5qgHqEqhdULOPzOWXOHBgZNgPUNftjCxRuzX/C80Rw/m6VU0wqKBhgrc9xSpfq4OeDihFgClcmjoQfjogwfwm3fb61lfdCZ6nTDZF0KizpDr5l1ba5/xyHpD08fSw==");
        }

        /// <summary>
        /// «©√˚ ß∞‹≤‚ ‘
        /// </summary>
        [TestMethod]
        public void SignTestFalse()
        {
            var s = WebSecurity.Sign("a=1&b=222", WebSecurity.GetXmlString("VendorPrivateKey.xml"));
            Assert.AreNotEqual(s, "Vz8Zs6PN7EhhtCVhLP5s53vMhWBCG5+6PeUIO6Gnq1ODccNnk9NOVbhV3hHDfz8BQbH6u05x1rE7qg/VdF7OGwpp6TvcS2jdH0zALhyerIL6Sido1fOqcSh0nUalspZEEkSP0UCwsq5tTWxP5Bqg9tBlA8vNmgmYuAcsDyk/bTVxfv/PQ5FRofRNjIoBjHbjfeWXJZSs0oK+PaiQH8bViifAp5qgHqEqhdULOPzOWXOHBgZNgPUNftjCxRuzX/C80Rw/m6VU0wqKBhgrc9xSpfq4OeDihFgClcmjoQfjogwfwm3fb61lfdCZ6nTDZF0KizpDr5l1ba5/xyHpD08fSw==");
        }

        /// <summary>
        /// —È«©≥…π¶≤‚ ‘
        /// </summary>
        [TestMethod]
        public void VerifyTestTrue()
        { 
            var t = WebSecurity.Verify("bizdt_ord=AAA&cust_name=xiaoliag", "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==",
               WebSecurity.GetXmlString("CustomPublicKey.xml"));

            Assert.IsTrue(t);
        }

        /// <summary>
        /// —È«© ß∞‹≤‚ ‘
        /// </summary>
        [TestMethod]
        public void VerifyTestFalse()
        {
            var t = WebSecurity.Verify("bizdt_ord=AAABB&cust_name=xiaoliag", "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==",
               WebSecurity.GetXmlString("CustomPublicKey.xml"));

            Assert.IsFalse(t);
        }

        /// <summary>
        ///  «©√˚Œƒº˛¥Ê‘⁄≤‚ ‘
        /// </summary>
        [TestMethod]
        public void GetXmlStringTest()
        {
            var path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent;
            var xmlPath = Path.Combine(path.FullName, "HexSalesIF_Service\\bin\\CustomPublicKey.xml");
            Assert.AreEqual("C:\\Users\\weizou\\Desktop\\m",path.FullName);
            Assert.AreEqual("C:\\Users\\weizou\\Desktop\\m\\HexSalesIF_Service\\bin\\CustomPublicKey.xml",xmlPath );
            bool xmlCustomPubStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\bin\\CustomPublicKey.xml"));
            bool xmlCustomPriStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\bin\\CustomPrivateKey.xml"));
            bool xmlVendorPubStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\bin\\CustomPublicKey.xml"));
            bool xmlVendorPriStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\bin\\CustomPrivateKey.xml"));
            Assert.IsTrue(xmlCustomPubStringExists);
            Assert.IsTrue(xmlCustomPriStringExists);

            Assert.IsTrue(xmlVendorPubStringExists);
            Assert.IsTrue(xmlVendorPriStringExists);

        }
    }
}
