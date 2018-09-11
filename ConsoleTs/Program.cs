using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using System.Xml;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Pkcs;
using System.Collections.Specialized;

namespace ConsoleTs
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //GenerateKey();
            //var r = Enc();
            // var s = Dec("LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==");

            //RSAPrivateKeyToDotNet("MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAichYBYr+bItXFudONtYtpa1SEzX2YU8DaEMVWPlT6DR4/zK7iu6RCUiMRSD/CclwADlOTdViOGJ91C20FlVEqRNiK2QP8fykbqrSyr7J5v4a/F4fSEPIwM/8aosiDD+XZLr8N74oBRMfcb5wubP0DHZZUDWZBDoOgntl3lR7Qs4HnMrDWK9hliQPRFgmPYD7S0CIyJMuofR53qCFxZ4nnm/1BAIo8d2ZTVPnlALy3fxp/9BRP1Cgxj7WmYpHIgSylfRM6Jh5yQJKJS8H0vs96AcZpZa7+b3epj/c+CK03oNtVaIDbpPdJ8tzDRbXv0aYtfUQJ2z1LMYN1+XFsNV+xQIDAQAB");
            //RSAPublicKeyJava2DotNet("MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAichYBYr+bItXFudONtYtpa1SEzX2YU8DaEMVWPlT6DR4/zK7iu6RCUiMRSD/CclwADlOTdViOGJ91C20FlVEqRNiK2QP8fykbqrSyr7J5v4a/F4fSEPIwM/8aosiDD+XZLr8N74oBRMfcb5wubP0DHZZUDWZBDoOgntl3lR7Qs4HnMrDWK9hliQPRFgmPYD7S0CIyJMuofR53qCFxZ4nnm/1BAIo8d2ZTVPnlALy3fxp/9BRP1Cgxj7WmYpHIgSylfRM6Jh5yQJKJS8H0vs96AcZpZa7+b3epj/c+CK03oNtVaIDbpPdJ8tzDRbXv0aYtfUQJ2z1LMYN1+XFsNV+xQIDAQAB");
            //var pk = RSAPrivateKeyToDotNet("");
            //RSADecryptByPrivateKey("LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==");
            //RsaDecrypt("LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==");

            //ToDotNet();

            //Class1.RSADecryptByPublicKey(GetXmlString("CustomPublicKey.xml"), "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==");

            /* 公钥验证*/
            var t = Class1.Verify("bizdt_ord=AAA&cust_name=xiaoliag", "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==",
               GetXmlString("CustomPublicKey.xml"));

            //RSAPrivateKeyDotNet2Java(GetXmlString("CustomPrivateKey.xml"), "CustomPrivateKey");

            RSAPublicKeyJava2DotNet(GetXmlString("应用公钥2048.txt"), "应用公钥2048");
            //RSAPrivateKeyJava2DotNet(GetXmlString("VendorPrivateKey.txt"), "VendorPrivateKey");

            var sign = Class1.Sign("a=1&b=2", GetXmlString("VendorPrivateKey.xml"));

            var sign2 = Class1.Sign("storeNo=600017&voucherNo=941831670000224191", GetXmlString("CustomPrivateKey.xml"));

            var sign3 = Class1.Sign("rtnMsg=条码:941831670000224191 - 2018版星冰粽冰尚礼盒券天猫折扣: 2017版星冰粽冰尚礼盒券天猫折扣商品: 481161 - 领取2017星冰粽冰尚礼盒bom该礼券必须先预约!&rtnMsgNo=05", GetXmlString("VendorPrivateKey.xml"));

            var sign4 = Class1.Sign("remarks1=作废&updateDate=2018-08-31&voucherNo=941831670000224191", GetXmlString("CustomPrivateKey.xml"));
            var sign5 = Class1.Sign("city=上海&company=test_company_1&operateType=1&province=上海&storeEmail=123@123.com&storeName=1&storeNo=600081", GetXmlString("CustomPrivateKey.xml"));
            var sign6 = Class1.Sign("expiredDate=2018-12-31&remarks1=22&startDate=2018-10-01&voucherName=6吋预约蛋糕券&voucherNo=1609941075&voucherQty=10", GetXmlString("CustomPrivateKey.xml"));
            var sign7 = Class1.Sign("remarks1=理由：冲正&saleDate=2018-08-31&saleId=1&storeNo=600017&tillNo=1&transNo=18082784302100005005&voucherNo=971832690000028430", GetXmlString("CustomPrivateKey.xml"));
            var voucherService = new HexVoucherService.VoucherService();

            //string sign4 = GetMD5("941831670000224191" + "~" + "600017" + "~" + "ABCD1234");
            string out1 = "";
            string out2 = "";
            string out3 = "";
            string out4 = "";
            string out5 = "";
            
            voucherService.VoucherCheckNew("941831670000224191", "600017", ref sign2, out out1, out out2, out out3, out out4, out out5);
         
        }

        static void ToDotNet()
        {
            using (var reader = new StreamReader("MyPublicKey.txt"))
            {
                RSAPrivateKeyJava2DotNet(reader.ReadLine(),"");

            }
            using (var reader = new StreamReader("MyPublicKey.txt"))
            {
                RSAPublicKeyJava2DotNet(reader.ReadLine(),"");

            }
        }

        static string GetXmlString(string xmlName)
        {
            var result = "";
            using(var reader = new StreamReader(xmlName))
            {
                result = reader.ReadLine();
            }
            return result;
        }


        static void GenerateKey()
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter writer = new StreamWriter("PrivateKey.xml"))
            {
                writer.Write(rsa.ToXmlString(true));
            }
            using (StreamWriter writer = new StreamWriter("PublicKey.xml"))
            {
                writer.Write(rsa.ToXmlString(false));
            }
        }

        static string Enc()
        {
            string result;
            using (var rsa = new RSACryptoServiceProvider())
            {
                using (StreamReader reader = new StreamReader("PublicKey.xml"))
                {
                    var xmlString = reader.ReadLine();
                    var rawValue = "I'm joe";
                    rsa.FromXmlString(xmlString);
                    var encryptedValue = rsa.Encrypt(Encoding.Default.GetBytes(rawValue), false);

                    result = Convert.ToBase64String(encryptedValue);


                }
            }
            return result;
        }

        static string Dec(string base64EncryptedValue)
        {
            var result = "";
            var a = Convert.FromBase64String(base64EncryptedValue);
            using (var rsa = new RSACryptoServiceProvider())
            {
                using (StreamReader reader = new StreamReader("CustomPrivateKey.xml"))
                {
                    var xmlString = reader.ReadLine();
                    rsa.FromXmlString(xmlString);
                    var rawBytes = rsa.Decrypt(Convert.FromBase64String(base64EncryptedValue), false);

                    result = Encoding.Default.GetString(rawBytes);

                }
            }
            return result;
        }

        public static string RSADecryptByPrivateKey(string strEncryptString)
        {
            var xmlPrivateKey = "";
            using (StreamReader reader = new StreamReader("CustomPrivateKey.xml"))
            {
                xmlPrivateKey = reader.ReadLine();
            }

                //加载私钥  
            RSACryptoServiceProvider privateRsa = new RSACryptoServiceProvider();
            privateRsa.FromXmlString(xmlPrivateKey);
             
            //转换密钥  
            AsymmetricCipherKeyPair keyPair = DotNetUtilities.GetKeyPair(privateRsa);
            
            IBufferedCipher c = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");// 参数与Java中加密解密的参数一致
            //IBufferedCipher c = CipherUtilities.GetCipher("RSA/ECB/OAEPWITHSHA-512ANDMGF1PADDING");// 参数与Java中加密解密的参数一致
            //IBufferedCipher c = CipherUtilities.GetCipher("RSA/NONE/PKCS1PADDING");// 参数与Java中加密解密的参数一致
            //第一个参数为true表示加密，为false表示解密；第二个参数表示密钥  
            c.Init(false, keyPair.Private);
            
            byte[] DataToEncrypt = Encoding.UTF8.GetBytes(strEncryptString);
            byte[] outBytes = c.DoFinal(DataToEncrypt);
            string strVal  = Encoding.Default.GetString(outBytes);
            string strBase64 = Convert.ToBase64String(outBytes);

            return strBase64;
        }

        public static string RSAPrivateKeyJava2DotNet(string privateKey,string keyFileName)
        {
            var pk = "";
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));
            pk = string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
                Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));

            if  (!string.IsNullOrEmpty(keyFileName)){
                using (StreamWriter writer = new StreamWriter(string.Format("{0}.xml", keyFileName)))
                {
                    writer.Write(pk);
                }
            }
           
            return pk;
        }

        public static string RSAPublicKeyJava2DotNet(string publicKey, string keyFileName)
        {
            var pk = "";
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            pk = string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
                Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
                Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));

            if (!string.IsNullOrEmpty(keyFileName))
            {
                using (StreamWriter writer = new StreamWriter(string.Format("{0}.xml", keyFileName)))
                {
                    writer.Write(pk);
                }
            }
            return pk;
        }

        public static string RSAPrivateKeyDotNet2Java(string privateKey, string keyFileName)
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
            RsaPrivateCrtKeyParameters privateKeyParam = new RsaPrivateCrtKeyParameters(m, exp, d, p, q, dp, dq, qinv);
            PrivateKeyInfo privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(privateKeyParam);
            byte[] serializedPrivateBytes = privateKeyInfo.ToAsn1Object().GetEncoded();

            if (!string.IsNullOrEmpty(keyFileName))
            {
                using (StreamWriter writer = new StreamWriter(string.Format("{0}.txt", keyFileName)))
                {
                    writer.Write(Convert.ToBase64String(serializedPrivateBytes));
                }
            }

            return Convert.ToBase64String(serializedPrivateBytes);
        }

        




        public static string RsaDecrypt(string encryptedInput)
        {
            var xmlPrivateKey = "";
            using (StreamReader reader = new StreamReader("CustomPrivateKey.xml"))
            {
                xmlPrivateKey = reader.ReadLine();
            }


            if (string.IsNullOrEmpty(encryptedInput))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(xmlPrivateKey))
            {
                throw new ArgumentException("Invalid Private Key");
            }

            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                var inputBytes = Convert.FromBase64String(encryptedInput);
                rsaProvider.FromXmlString(xmlPrivateKey);
                int bufferSize = rsaProvider.KeySize / 8;
                var buffer = new byte[bufferSize];
                using (MemoryStream inputStream = new MemoryStream(inputBytes),
                     outputStream = new MemoryStream())
                {
                    while (true)
                    {
                        int readSize = inputStream.Read(buffer, 0, bufferSize);
                        if (readSize <= 0)
                        {
                            break;
                        }

                        var temp = new byte[readSize];
                        Array.Copy(buffer, 0, temp, 0, readSize);
                        var rawBytes = rsaProvider.Decrypt(temp, false);
                        outputStream.Write(rawBytes, 0, rawBytes.Length);
                    }
                    return Encoding.UTF8.GetString(outputStream.ToArray());
                }
            }
        }



        public static string GetMD5(string myString)
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


       
    }
}
