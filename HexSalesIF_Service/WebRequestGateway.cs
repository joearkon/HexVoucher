using HexSalesIF_Service.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Security.Cryptography;
using System.Web;

namespace HexSalesIF_Service
{

    /// <summary>
    /// webservice请求接口
    /// </summary>
    public interface IWebRequestGateway
    {
        /// <summary>
        /// 验证请求数据签名
        /// </summary>
        /// <param name="requestData"></param>
        /// <param name="requestSign"></param>
        /// <returns></returns>
        bool VerifyRequestDataSign(IDictionary requestData, string requestSign);
        /// <summary>
        /// 验证请求数据签名
        /// </summary>
        /// <param name="requestData"></param>
        /// <param name="requestSign"></param>
        /// <returns></returns>
        bool VerifyRequestDataSign(string requestData, string requestSign);

        /// <summary>
        /// 创建签名数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string CreateSign(string data);
        /// <summary>
        /// 创建签名数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string CreateSign(IDictionary data);
    }

    /// <summary>
    /// 请求门关
    /// </summary>
    public class WebRequestGateway: IWebRequestGateway
    {
        protected string version { get; }
        protected IWebRequestWatchDog watchDog { get; set; }
        public WebRequestGateway(string version)
        {
            this.version = version;
            IWebRequestWatchDog watchDog = null;
            
            if (!string.IsNullOrEmpty(this.version) && Convert.ToInt32(this.version) ==1)  //新加签方式 
            {
                this.watchDog = new NewWebRequestWatchDog();
            }
            else
            {
                this.watchDog = new ElderWebReqeustWatchDog();  //老加密方式
            }
        }
        public bool VerifyRequestDataSign(IDictionary requestData, string requestSign)
        {
            return watchDog.VerifySign(requestData, requestSign);
        }

        public bool VerifyRequestDataSign(string requestData, string requestSign)
        {
            return watchDog.VerifySign(requestData, requestSign);
        }

        public string CreateSign(string data)
        {
            return watchDog.CreateSign(data);
        }

        public string CreateSign(IDictionary data)
        {
            return watchDog.CreateSign(data);
        }
    }

    /// <summary>
    /// web请求看门狗接口
    /// </summary>
    public interface IWebRequestWatchDog
    {
        /// <summary>
        ///  请求加密验证
        /// </summary>
        /// <param name="dataPairs">请求数据的字典</param>
        /// <param name="expectedSign">待验签名或者加密字符串</param>
        /// <returns></returns>
        bool VerifySign(IDictionary dataPairs, string expectedSign);
        /// <summary>
        /// 请求加密验证
        /// </summary>
        /// <param name="dataPairs">请求数据字符串</param>
        /// <param name="expectedSign">待验签名或者加密字符串</param>
        /// <returns></returns>
        bool VerifySign(string dataPairs, string expectedSign);
        /// <summary>
        ///  验证版本
        /// </summary>
        /// <returns></returns>
        string Version();

        /// <summary>
        /// 创建签名
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string CreateSign(string data);

        /// <summary>
        /// 创建签名
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string CreateSign(IDictionary data);
    }
    public class ElderWebReqeustWatchDog : IWebRequestWatchDog
    {
        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        private string GetMD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.UTF8.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String.ToUpper();
        }
        public bool VerifySign(string dataPairs, string expectedSign)
        {
            string signKey = System.Configuration.ConfigurationManager.AppSettings["singKey"];

            if (expectedSign != GetMD5(dataPairs + signKey))
            {
                return false;
            }

            return true;

        }

        public string Version()
        {
            return "1.0";
        }

        public bool VerifySign(IDictionary dataPairs, string expectedSign)
        {
            // 按照老接口，移植加密
            string parString = "";
            foreach (DictionaryEntry item in dataPairs)
            {
                if (item.Value != null && item.Key.ToString().ToLower() != "sign")
                {
                    parString = parString + item.Value.ToString() + "~";
                }
                else
                {
                    parString = parString + "~";
                }

            }
            return this.VerifySign(parString, expectedSign);
        }

        public string CreateSign(string data)
        {
            return "";
        }

        public string CreateSign(IDictionary data)
        {
            return "";
        }
    }

    public class NewWebRequestWatchDog : IWebRequestWatchDog
    {
        public string Version()
        {
            return "2.0";
        }

        public string CreateSign(string data)
        {
            return WebSecurity.Sign(data,
                    WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Bin\\", "VendorPrivateKey.xml"))); //获取私钥
        }

        public bool VerifySign(string dataPairs, string expectedSign)
        {
            bool isValid = WebSecurity.Verify(dataPairs, expectedSign,
             WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Bin\\", "CustomPublicKey.xml"))); // 获取公钥

            return isValid;
        }

        public bool VerifySign(IDictionary dataPairs, string expectedSign)
        {
            // 新接口，RSA加密

            string pairsStr = this.GenerateSortedKeyPairs(dataPairs, '&');

            return this.VerifySign(pairsStr, expectedSign);
        }

        public string CreateSign(IDictionary data)
        {

            string pairsStr = this.GenerateSortedKeyPairs(data, '&');

            return WebSecurity.Sign(pairsStr,
                    WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Bin\\", "VendorPrivateKey.xml"))); //获取私钥
        }

        /// <summary>
        ///  生成成对字符串
        /// </summary>
        /// <param name="data">字典集合</param>
        /// <param name="sepChar">分隔符</param>
        /// <returns></returns>
        private string GenerateSortedKeyPairs(IDictionary data, char sepChar)
        {
            if (sepChar == null)
            {
                sepChar = '&';
            }
            SortedDictionary<string, string> sortedDataPairs = new SortedDictionary<string, string>();
            foreach (DictionaryEntry item in data)
            {
                string itemValue = "";
                bool v = !(string.IsNullOrEmpty(Convert.ToString(item.Value)));
                if (v)  //剔除为空的数据
                {
                    itemValue = item.Value.ToString();
                    sortedDataPairs.Add(item.Key.ToString(), itemValue);
                }
            }
            string pairsStr = "";
            foreach (var item in sortedDataPairs)
            {
                if (item.Key.ToString().ToLower() == "sign" || item.Key.ToString().ToLower() == "sign_type")  //剔除sign和sign_type
                {
                    continue;
                }
                string itemValue = "";
                if (!string.IsNullOrEmpty(item.Value))
                {
                    itemValue = item.Value.ToString();
                }
                pairsStr = pairsStr + sepChar + Convert.ToString(item.Key) + "=" + Convert.ToString(itemValue);
            }
            pairsStr = pairsStr.TrimStart(sepChar);
            return pairsStr;
        }
    }
}