using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;  // 有依赖，使用BouncyCastle 第三方加解密工具，兼容java的RSA
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Xml;

namespace HexSalesIF_Service.util
{
    /// <summary>
    /// 加密安全类
    /// 使用SHA256withRSA加密算法
    /// 私钥加密，公钥解密
    /// </summary>
    public class WebSecurity
    {
        /// <summary>
        /// 将C#格式公钥转成BouncyCastle格式公钥
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static RsaKeyParameters RSAPublicKeyDotNeTransfer(string publicKey)
        {
            /*加载公钥xml字符串*/
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(publicKey);

            /*初始化公钥参数*/
            BigInteger m = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Modulus")[0].InnerText));
            BigInteger p = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Exponent")[0].InnerText));

            /*生成公钥*/
            RsaKeyParameters pub = new RsaKeyParameters(false, m, p);

            return pub;
        }
        /// <summary>
        /// C#格式秘钥转成BouncyCastle格式秘钥
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static RsaKeyParameters RSAPrivateKeyDotNetTransfer(string privateKey)
        {
            /*加载私钥xml字符串*/
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(privateKey);

            /*初始化私钥参数*/
            BigInteger m = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Modulus")[0].InnerText));
            BigInteger exp = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Exponent")[0].InnerText));
            BigInteger d = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("D")[0].InnerText));
            BigInteger p = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("P")[0].InnerText));
            BigInteger q = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Q")[0].InnerText));
            BigInteger dp = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("DP")[0].InnerText));
            BigInteger dq = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("DQ")[0].InnerText));
            BigInteger qinv = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("InverseQ")[0].InnerText));

            /*生成私钥 */
            RsaPrivateCrtKeyParameters pri = new RsaPrivateCrtKeyParameters(m, exp, d, p, q, dp, dq, qinv);
            return pri;

        }

        /// <summary>
        /// 验签
        /// </summary>
        /// <param name="data">待验数据</param>
        /// <param name="expectedSignature">期望签名</param>
        /// <param name="xmlPublicKey">公钥xml字符串</param>
        /// <returns></returns>
        public static bool Verify(string data, string expectedSignature, string xmlPublicKey)
        {
            /* Make the key */
            RsaKeyParameters keyParams = RSAPublicKeyDotNeTransfer(xmlPublicKey);

            /* Init alg */
            ISigner signer = SignerUtilities.GetSigner("SHA256withRSA");

            /* Populate key */
            signer.Init(false, keyParams);

            /* Get the signature into bytes */
            byte[] expectedSig;
            try
            {
                expectedSig = Convert.FromBase64String(expectedSignature);
            }
            catch
            {
                return false;
            }

            /* Get the bytes to be signed from the string */
            var msgBytes = Encoding.UTF8.GetBytes(data);

            /* Calculate the signature and see if it matches */
            signer.BlockUpdate(msgBytes, 0, msgBytes.Length);
            return signer.VerifySignature(expectedSig);
        }

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="data">待签数据</param>
        /// <param name="xmlPrivateKey">私钥xml字符串</param>
        /// <returns></returns>
        public static string Sign(string data, string xmlPrivateKey)
        {
            /* Make the key */
            RsaKeyParameters key = RSAPrivateKeyDotNetTransfer(xmlPrivateKey);

            /* Init alg */
            ISigner sig = SignerUtilities.GetSigner("SHA256withRSA");

            /* Populate key */
            sig.Init(true, key);

            /* Get the bytes to be signed from the string */
            var bytes = Encoding.UTF8.GetBytes(data);

            /* Calc the signature */
            sig.BlockUpdate(bytes, 0, bytes.Length);
            byte[] signature = sig.GenerateSignature();

            /* Base 64 encode the sig so its 8-bit clean */
            var signedString = Convert.ToBase64String(signature);

            return signedString;
        }

        /// <summary>
        /// 获取xml字符串
        /// </summary>
        /// <param name="xmlPath">xml公钥路径</param>
        /// <returns></returns>
        public static string GetXmlString(string xmlPath)
        {
            var result = "";
            using (var reader = new StreamReader(xmlPath))
            {
                result = reader.ReadLine();
            }
            return result;
        }
    }
}