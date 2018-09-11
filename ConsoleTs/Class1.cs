using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using System;
using System.Text;
using System.Xml;

namespace ConsoleTs
{
    class Class1
    {
        /// <summary>
        /// 将C#格式公钥转成Java格式公钥
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static RsaKeyParameters RSAPublicKeyDotNet2Java(string publicKey)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(publicKey);
            BigInteger m = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Modulus")[0].InnerText));
            BigInteger p = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Exponent")[0].InnerText));
            RsaKeyParameters pub = new RsaKeyParameters(false, m, p);
            
            return pub;
        }
        /// <summary>
        /// C#格式秘钥转成Java格式秘钥
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static RsaKeyParameters RSAPrivateKeyDotNet2Java(string privateKey)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(privateKey);
            BigInteger m = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Modulus")[0].InnerText));
            BigInteger exp = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Exponent")[0].InnerText));
            BigInteger d = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("D")[0].InnerText));
            BigInteger p = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("P")[0].InnerText));
            BigInteger q = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("Q")[0].InnerText));
            BigInteger dp = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("DP")[0].InnerText));
            BigInteger dq = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("DQ")[0].InnerText));
            BigInteger qinv = new BigInteger(1, Convert.FromBase64String(doc.DocumentElement.GetElementsByTagName("InverseQ")[0].InnerText));
            RsaPrivateCrtKeyParameters pri = new RsaPrivateCrtKeyParameters(m, exp, d, p, q, dp, dq, qinv);
            //RsaKeyParameters pri = new RsaKeyParameters(true, m, exp);
            return pri;

        }

        /// <summary>
        /// 公钥解密
        /// </summary>
        /// <param name="xmlPublicKey">C#格式公钥</param>
        /// <param name="strEncryptString">密文</param>
        /// <returns></returns>
        public static string RSADecryptByPublicKey(string xmlPublicKey, string strEncryptString)
        {
            //得到公钥
            RsaKeyParameters keyParams = RSAPublicKeyDotNet2Java(xmlPublicKey);

            //参数与Java中加密解密的参数一致
            IBufferedCipher c = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");

            //第一个参数 true-加密，false-解密；第二个参数表示密钥
            c.Init(false, keyParams);

            //对密文进行base64解码
            byte[] dataFromEncrypt = Convert.FromBase64String(strEncryptString);

            //解密
            byte[] outBytes = c.DoFinal(dataFromEncrypt);

            //明文
            string clearText = Encoding.Default.GetString(outBytes);

            return clearText;
        }

        public static bool Verify(string data, string expectedSignature, string xmlPublicKey)
        {
            /* Make the key */
            RsaKeyParameters keyParams = RSAPublicKeyDotNet2Java(xmlPublicKey);

            /* Init alg */
            ISigner signer = SignerUtilities.GetSigner("SHA256withRSA");

            /* Populate key */
            signer.Init(false, keyParams);

            /* Get the signature into bytes */
            var expectedSig = Convert.FromBase64String(expectedSignature);

            /* Get the bytes to be signed from the string */
            var msgBytes = Encoding.UTF8.GetBytes(data);

            /* Calculate the signature and see if it matches */
            signer.BlockUpdate(msgBytes, 0, msgBytes.Length);
            return signer.VerifySignature(expectedSig);
        }


        private RsaKeyParameters MakeKey(String modulusHexString, String exponentHexString, bool isPrivateKey)
        {
            var modulus = new Org.BouncyCastle.Math.BigInteger(modulusHexString, 16);
            var exponent = new Org.BouncyCastle.Math.BigInteger(exponentHexString, 16);

            return new RsaKeyParameters(isPrivateKey, modulus, exponent);
        }

        public static string Sign(string data, string xmlPrivateKey)
        {
            /* Make the key */
            //RsaKeyParameters key = MakeKey(privateModulusHexString, privateExponentHexString, true);
            RsaKeyParameters key = RSAPrivateKeyDotNet2Java(xmlPrivateKey);

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

    }
}