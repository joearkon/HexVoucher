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
    public interface IWebRequestGate
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
    public class WebRequestGate : IWebRequestGate
    {
        protected string version { get; }
        protected IWebRequestWatchDog watchDog { get; set; }
        public WebRequestGate(string version)
        {
            this.version = version;
            IWebRequestWatchDog watchDog = null;

            if (!string.IsNullOrEmpty(this.version) && Convert.ToInt32(this.version) == 1)  //新加签方式 
            {
                this.watchDog = new NewWebRequestWatchDog();
            }
            else
            {
                this.watchDog = new ElderWebReqeustWatchDog();  //老加密方式
            }
        }

        public WebRequestGate(IWebRequestWatchDog dog) { this.watchDog = dog; }
        public bool VerifyRequestDataSign(IDictionary requestData, string requestSign)
        {
            try
            {
                return watchDog.VerifySign(requestData, requestSign);
            }
            catch (Exception e)
            {
                LogHelper.Error(string.Format("Error occured when executing request gate sign verify method, message: {0}, source{1}", e.Message, e.Source));
                throw e;
            }
            //return watchDog.VerifySign(requestData, requestSign);
        }

        public bool VerifyRequestDataSign(string requestData, string requestSign)
        {
            try
            {
                return watchDog.VerifySign(requestData, requestSign);
            }
            catch (Exception e)
            {
                LogHelper.Error(string.Format("Error occured when executing request gate sign verify method, message: {0}, source{1}", e.Message, e.Source));
                throw e;
            }

        }

        public string CreateSign(string data)
        {
            try
            {
                return watchDog.CreateSign(data);
            }
            catch (Exception e)
            {
                LogHelper.Error(string.Format("Error occured when executing request gate sign creation method, message: {0}, source{1}", e.Message, e.Source));
                throw e;
            }
        }

        public string CreateSign(IDictionary data)
        {
            try
            {
                return watchDog.CreateSign(data);
            }
            catch (Exception e)
            {
                LogHelper.Error(string.Format("Error occured when executing request gate sign creation method, message: {0}, source{1}", e.Message, e.Source));
                throw e;
            }

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
        public IConfigReader configReader { get; set; } //配置读取
        public ElderWebReqeustWatchDog()
        {
            this.configReader = new WebConfigReader();
        }

        public ElderWebReqeustWatchDog(IConfigReader configReader)
        {
            this.configReader = configReader;
        }
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
            //string signKey = System.Configuration.ConfigurationManager.AppSettings["singKey"];
            string signKey = this.configReader.GetAppSetting("singKey", "");

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
                if (item.Key != null && item.Key.ToString().ToLower() == "sign")  //sign签名忽略
                {
                    continue;
                }

                if (item.Value != null)
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
        public IConfigReader configReader { get; set; } //配置读取
        public string KeyPathDictName { get; private set; }
        public string CustomPublicKeyFileName { get; private set; }
        public string VendorPrivateKeyFileName { get; private set; }

        public NewWebRequestWatchDog()
        {
            this.configReader = new WebConfigReader(); //默认使用web.config配置
            this.getKeys();

        }
        public NewWebRequestWatchDog(IConfigReader configReader) {
            this.configReader = configReader;
            this.getKeys();
        }
        public string Version()
        {
            return "2.0";
        }

        //private string KeyPathDictName = !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["SecretKeyDictName"]) ?
        //    System.Configuration.ConfigurationManager.AppSettings["SecretKeyDictName"] : "sk";// 钥匙目录 默认sk目录

        //private string CustomPublicKeyFileName = !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["PublicKeyFlieName"]) ?
        //    System.Configuration.ConfigurationManager.AppSettings["PublicKeyFlieName"] : "CustomPublicKey.xml";// 公钥验签 默认CustomPublicKey.xml

        //private string VendorPrivateKeyFileName = !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["PrivateKeyFlieName"]) ?
        //   System.Configuration.ConfigurationManager.AppSettings["PrivateKeyFlieName"] : "VendorPrivateKey.xml";// 私钥加签 默认VendorPrivateKey.xml

        /// <summary>
        /// 获取配置信息
        /// </summary>
        private void getKeys()
        {
            if (this.configReader == null)
            {
                return;
            }
            try
            {
                KeyPathDictName = this.configReader.GetAppSetting("SecretKeyDictName", "sk");
                CustomPublicKeyFileName = this.configReader.GetAppSetting("PublicKeyFlieName", "CustomPublicKey.xml");
                VendorPrivateKeyFileName = this.configReader.GetAppSetting("PrivateKeyFlieName", "VendorPrivateKey.xml");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string CreateSign(string data)
        {
            return WebSecurity.Sign(data,
                    WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + KeyPathDictName, VendorPrivateKeyFileName))); //获取私钥
        }

        public string CreateSign(IDictionary data)
        {

            string pairsStr = this.GenerateSortedKeyPairs(data, '&');

            return WebSecurity.Sign(pairsStr,
                    WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + KeyPathDictName, VendorPrivateKeyFileName))); //获取私钥
        }

        public bool VerifySign(string dataPairs, string expectedSign)
        {
            bool isValid = WebSecurity.Verify(dataPairs, expectedSign,
             WebSecurity.GetXmlString(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + KeyPathDictName, CustomPublicKeyFileName))); // 获取公钥

            return isValid;
        }

        public bool VerifySign(IDictionary dataPairs, string expectedSign)
        {
            // 新接口，RSA加密

            string pairsStr = this.GenerateSortedKeyPairs(dataPairs, '&');

            return this.VerifySign(pairsStr, expectedSign);
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