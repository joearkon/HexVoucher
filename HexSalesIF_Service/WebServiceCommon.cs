using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using HexSalesIF_Service.util;

namespace HexSalesIF_Service
{
    /// <summary>
    /// WebService常用类
    /// </summary>
    public class WebServiceCommon
    {
        /* 服务端私钥公钥*/
        private const string serverPrivateXml = "VendorPrivateKey.xml";
        private const string serverPublicXml = "VendorPublicKey.xml";

        /* 客户端私钥公钥*/
        private const string customerPrivateXml = "CustomPrivateKey.xml";
        private const string customerPublicXml = "CustomPublicKey.xml";

        public WebServiceCommon()
        {
        }

        /// <summary>
        /// 验证RSA签名
        /// 使用客户公钥验签
        /// </summary>
        /// <param name="dataPairs">组成的字符串字典</param>
        /// <param name="expectedSign">目标签名</param>
        /// <returns></returns>
        public bool VerifySign(IDictionary<string, string> dataPairs, string expectedSign)
        {
            string pairsStr = "";
            foreach (var item in dataPairs)
            {
                if (item.Key.ToLower() == "sign" || item.Key.ToLower() == "sign_type")
                {
                    continue;
                }
                pairsStr = pairsStr + "&" + item.Key + "=" + Convert.ToString(item.Value);
            }
            pairsStr = pairsStr.TrimStart('&');

            return this.VerifySign(pairsStr, expectedSign);

        }

        /// <summary>
        /// 验证RSA签名
        /// 使用客户公钥验签
        /// </summary>
        /// <param name="dataParis">组成的字符串</param>
        /// <param name="expectedSign">目标签名</param>
        /// <returns></returns>
        public bool VerifySign(string dataParis, string expectedSign)
        {
            bool isValid = WebSecurity.Verify(dataParis, expectedSign,
             WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "sk\\", "CustomPublicKey.xml")));

            return isValid;
        }

        /// <summary>
        /// 验证RSA签名
        /// </summary>
        /// <param name="dataParis">组成的字符串</param>
        /// <param name="expectedSign">目标签名</param>
        /// <param name="isServerXml">是否使用服务端xml公钥解密 ture:是 false:使用客户端公钥</param>
        /// <returns></returns>
        public bool VerifySign(string dataParis, string expectedSign, bool isServerXml)
        {
            var xmlName = isServerXml ? "VendorPublicKey.xml" : "CustomPublicKey.xml";
            bool isValid = WebSecurity.Verify(dataParis, expectedSign,
             WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "sk\\", xmlName)));

            return isValid;
        }


        /// <summary>
        /// 生成RSA签名
        /// 使用服务器端私钥生成
        /// </summary>
        /// <param name="data">待加密数据</param>
        /// <returns></returns>
        public string CreateSign(string data)
        {
            return WebSecurity.Sign(data,
                    WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "sk\\", "VendorPrivateKey.xml")));
        }

        /// <summary>
        /// 生成RSA签名
        /// </summary>
        /// <param name="data">待加密数据</param>
        /// <param name="isServerXml">是否使用服务器端xml秘钥加密 ture:是 false:使用客户端私钥</param>
        /// <returns></returns>
        public string CreateSign(string data, bool isServerXml)
        {
            var xmlName = isServerXml ? "VendorPrivateKey.xml" : "CustomPrivateKey.xml";
            return WebSecurity.Sign(data,
                    WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Bin\\", xmlName)));
        }


        
    }
}