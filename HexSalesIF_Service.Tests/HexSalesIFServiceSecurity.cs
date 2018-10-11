using Microsoft.VisualStudio.TestTools.UnitTesting;
using HexSalesIF_Service;
using System;
using System.IO;
using Moq;
using System.Collections;
using System.Security.Cryptography;
using HexSalesIF_Service.util;

namespace UnitTest
{
    [TestClass]
    public class HexSalesIFServiceSecurity
    {
        /// <summary>
        /// 签名成功测试
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void SignTestTrue()
        {
            var s =  WebSecurity.Sign("a=1&b=2", WebSecurity.GetXmlString("sk/VendorPrivateKey.xml"));
            Assert.AreEqual(s, "Vz8Zs6PN7EhhtCVhLP5s53vMhWBCG5+6PeUIO6Gnq1ODccNnk9NOVbhV3hHDfz8BQbH6u05x1rE7qg/VdF7OGwpp6TvcS2jdH0zALhyerIL6Sido1fOqcSh0nUalspZEEkSP0UCwsq5tTWxP5Bqg9tBlA8vNmgmYuAcsDyk/bTVxfv/PQ5FRofRNjIoBjHbjfeWXJZSs0oK+PaiQH8bViifAp5qgHqEqhdULOPzOWXOHBgZNgPUNftjCxRuzX/C80Rw/m6VU0wqKBhgrc9xSpfq4OeDihFgClcmjoQfjogwfwm3fb61lfdCZ6nTDZF0KizpDr5l1ba5/xyHpD08fSw==");
        }

        /// <summary>
        /// 签名失败测试
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void SignTestFalse()
        {
            var s = WebSecurity.Sign("a=1&b=222", WebSecurity.GetXmlString("sk/VendorPrivateKey.xml"));
            Assert.AreNotEqual(s, "Vz8Zs6PN7EhhtCVhLP5s53vMhWBCG5+6PeUIO6Gnq1ODccNnk9NOVbhV3hHDfz8BQbH6u05x1rE7qg/VdF7OGwpp6TvcS2jdH0zALhyerIL6Sido1fOqcSh0nUalspZEEkSP0UCwsq5tTWxP5Bqg9tBlA8vNmgmYuAcsDyk/bTVxfv/PQ5FRofRNjIoBjHbjfeWXJZSs0oK+PaiQH8bViifAp5qgHqEqhdULOPzOWXOHBgZNgPUNftjCxRuzX/C80Rw/m6VU0wqKBhgrc9xSpfq4OeDihFgClcmjoQfjogwfwm3fb61lfdCZ6nTDZF0KizpDr5l1ba5/xyHpD08fSw==");
        }

        /// <summary>
        /// 验签成功测试
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void VerifyTestTrue()
        {
            var t = WebSecurity.Verify("bizdt_ord=AAA&cust_name=xiaoliag", "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==",
               WebSecurity.GetXmlString("sk/CustomPublicKey.xml"));

            Assert.IsTrue(t);
        }

        /// <summary>
        /// 验签失败测试
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void VerifyTestFalse()
        {
            var t = WebSecurity.Verify("bizdt_ord=AAABB&cust_name=xiaoliag", "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==",
               WebSecurity.GetXmlString("sk/CustomPublicKey.xml"));

            Assert.IsFalse(t);
        }

        /// <summary>
        ///  签名文件存在测试
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void GetXmlStringTest()
        {
            var path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent;
            var xmlPath = Path.Combine(path.FullName, "HexSalesIF_Service\\sk\\CustomPublicKey.xml");
            Assert.AreEqual("C:\\Users\\weizou\\Desktop\\m", path.FullName);
            Assert.AreEqual("C:\\Users\\weizou\\Desktop\\m\\HexSalesIF_Service\\sk\\CustomPublicKey.xml", xmlPath);
            bool xmlCustomPubStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\sk\\CustomPublicKey.xml"));
            bool xmlCustomPriStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\sk\\CustomPrivateKey.xml"));
            bool xmlVendorPubStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\sk\\CustomPublicKey.xml"));
            bool xmlVendorPriStringExists = File.Exists(Path.Combine(path.FullName, "HexSalesIF_Service\\sk\\CustomPrivateKey.xml"));
            Assert.IsTrue(xmlCustomPubStringExists);
            Assert.IsTrue(xmlCustomPriStringExists);

            Assert.IsTrue(xmlVendorPubStringExists);
            Assert.IsTrue(xmlVendorPriStringExists);

        }

        [TestMethod]
        [TestCategory("security")]
        public void ConfigReaderGetter()
        {
            IConfigReader configReader = Mock.Of<IConfigReader>(i => i.GetAppSetting("singKey", "") == "ABCD1234"); //mock reader
            Assert.IsTrue("ABCD1234" == configReader.GetAppSetting("singKey", ""));
        }


        /// <summary>
        /// 老验证MD5
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void ElderSignVerifyTrue()
        {
            var req = new HexSalesIF_Service.model.VoucherTransactionNewReq(0, "*821832590011746224", "503024", "2", "0", "2018-09-22 18:05:42", "0", "546", "",
                "18092262242100035290", 0, "B3B2AD70145CDAABED03EA05B9088C77");
            IConfigReader mockConfigReader = Mock.Of<IConfigReader>(i => i.GetAppSetting("singKey", "") == "ABCD1234"); //mock配置
            var watchDog = new HexSalesIF_Service.ElderWebReqeustWatchDog(mockConfigReader); //初始化老验证看门狗
            var valid = watchDog.VerifySign(req.ToStringDictionary(true), "B3B2AD70145CDAABED03EA05B9088C77");  //验证
            Assert.IsTrue(valid);
        }

        /// <summary>
        /// 新验签SH256WithRSA
        /// </summary>
        [TestMethod]
        [TestCategory("security")]
        public void NewSignVerifyTrue()
        {
            var req = new HexSalesIF_Service.model.VoucherTransactionNewReq(1, "401532740000000501", "600017", "1234", "234", "2018-09-14", "20", "1", "123", "334", 14,
                "hZ1wPz6XesDebwpMHvotRBea4Uw8RKSoFcl1uSdyd5nuFaCTWU9UDPHLtwMlUiAnL5hJX0fvVuqhNrEqcklv+FDC4fdmIY++VeQXalpBab+ogd/5DKsZtXOoax8uhzhMbftOucNOgReCB0rHu+QPWAJCOXLtjDAPxjVsZjZooAqSjhgeaAGKGoN4uNVQpfDg/wxhAucmA93O/5GNY7wvstjFvWhU2fF3QkQNglzUYgEmu99EDEZcT7ZfG7wtS06fCfgsNzfwWQa2JF8t98xjVhO41xQbikqng8/SWgDjHJ3Pgv0D2E2bOE6wv3jVxAZW0j6X33KSiPJMPuFuw4zwQg==");
            var mockConfigReader = new Mock<IConfigReader>();  //mock配置
            mockConfigReader.Setup(m => m.GetAppSetting("SecretKeyDictName", "sk")).Returns("sk");
            mockConfigReader.Setup(m => m.GetAppSetting("PublicKeyFlieName", "CustomPublicKey.xml")).Returns("CustomPublicKey.xml");
            mockConfigReader.Setup(m => m.GetAppSetting("PrivateKeyFlieName", "VendorPrivateKey.xml")).Returns("VendorPrivateKey.xml");

            var watchDog = new HexSalesIF_Service.NewWebRequestWatchDog(mockConfigReader.Object); //初始化新验证看门狗
            // 验证
            var valid = watchDog.VerifySign(req.ToStringDictionary(true),
                "hZ1wPz6XesDebwpMHvotRBea4Uw8RKSoFcl1uSdyd5nuFaCTWU9UDPHLtwMlUiAnL5hJX0fvVuqhNrEqcklv+FDC4fdmIY++VeQXalpBab+ogd/5DKsZtXOoax8uhzhMbftOucNOgReCB0rHu+QPWAJCOXLtjDAPxjVsZjZooAqSjhgeaAGKGoN4uNVQpfDg/wxhAucmA93O/5GNY7wvstjFvWhU2fF3QkQNglzUYgEmu99EDEZcT7ZfG7wtS06fCfgsNzfwWQa2JF8t98xjVhO41xQbikqng8/SWgDjHJ3Pgv0D2E2bOE6wv3jVxAZW0j6X33KSiPJMPuFuw4zwQg==");
            Assert.IsTrue(valid);



        }
    }
}
