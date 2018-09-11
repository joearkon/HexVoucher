//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;

//namespace ConsoleTs
//{
//    class Class2
//    {
//        /// <summary>
//        /// 使用 OpenSSL 兼容的方式对数据进行签名。
//        /// </summary>
//        /// <param name="data">要签名的数据。</param>
//        /// <param name="privateKeyPem">pem 私钥（可以包含-----BEGIN RSA PRIVATE KEY----  和-----END RSA PRIVATE KEY-----）。</param>
//        /// <param name="charset">签名使用的字符编码（默认UTF8）。</param>
//        /// <returns></returns>
//        public static string RSASign(string data, string privateKeyPem, string charset = "utf-8")
//        {
//            string keyString = FormatKey(privateKeyPem);
//            var key = Convert.FromBase64String(keyString);
//            using (RSACryptoServiceProvider rsaCsp = DecodePemPrivateKey(key))
//            {
//                byte[] dataBytes = null;
//                if (string.IsNullOrWhiteSpace(charset))
//                {
//                    dataBytes = Encoding.UTF8.GetBytes(data);
//                }
//                else
//                {
//                    dataBytes = Encoding.GetEncoding(charset).GetBytes(data);
//                }

//                byte[] signatureBytes = rsaCsp.SignData(dataBytes, "SHA1");

//                return Convert.ToBase64String(signatureBytes);
//            }
//        }

//        /// <summary>
//        /// 对 OpenSSL 数字签名进行验证。
//        /// </summary>
//        /// <param name="signContent">要验证的数据。</param>
//        /// <param name="sign">用来验证数据的数字签名。</param>
//        /// <param name="publicKeyPem">pem 公钥（可以包含-----BEGIN RSA PUBLIC KEY----  和-----END RSA PUBLIC KEY-----）。</param>
//        /// <param name="charset">签名使用的字符编码（默认UTF8）。</param>
//        /// <returns></returns>
//        public static bool RSAVerify(string signContent, string sign, string publicKeyPem, string charset = "utf-8")
//        {
//            try
//            {
//                string keyString = FormatKey(publicKeyPem);
//                charset = charset.IfNullOrWhiteSpace("utf-8");
//                var key = Convert.FromBase64String(keyString);
//                using (RSACryptoServiceProvider rsa = DecodePemPublicKey(key))
//                {
//                    rsa.PersistKeyInCsp = false;
//                    using (var sha1 = System.Security.Cryptography.SHA1.Create())
//                    {
//                        bool bVerifyResultOriginal = rsa.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent), sha1, Convert.FromBase64String(sign));
//                        return bVerifyResultOriginal;
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
                
//                return false;
//            }

//        }


//        private static RSACryptoServiceProvider DecodePemPrivateKey(byte[] privkey)
//        {
//            byte[] MODULUS, E, D, P, Q, DP, DQ, IQ;

//            // --------- Set up stream to decode the asn.1 encoded RSA private key ------
//            using (MemoryStream mem = new MemoryStream(privkey))
//            {
//                using (BinaryReader binr = new BinaryReader(mem))  //wrap Memory Stream with BinaryReader for easy reading
//                {
//                    byte bt = 0;
//                    ushort twobytes = 0;
//                    int elems = 0;
//                    try
//                    {
//                        twobytes = binr.ReadUInt16();
//                        if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)
//                            binr.ReadByte();    //advance 1 byte
//                        else if (twobytes == 0x8230)
//                            binr.ReadInt16();    //advance 2 bytes
//                        else
//                            return null;

//                        twobytes = binr.ReadUInt16();
//                        if (twobytes != 0x0102) //version number
//                            return null;
//                        bt = binr.ReadByte();
//                        if (bt != 0x00)
//                            return null;


//                        //------ all private key components are Integer sequences ----
//                        elems = GetIntegerSize(binr);
//                        MODULUS = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        E = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        D = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        P = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        Q = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        DP = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        DQ = binr.ReadBytes(elems);

//                        elems = GetIntegerSize(binr);
//                        IQ = binr.ReadBytes(elems);


//                        // ------- create RSACryptoServiceProvider instance and initialize with public key -----
//                        CspParameters CspParameters = new CspParameters();
//                        CspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
//                        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024, CspParameters);
//                        RSAParameters RSAparams = new RSAParameters();
//                        RSAparams.Modulus = MODULUS;
//                        RSAparams.Exponent = E;
//                        RSAparams.D = D;
//                        RSAparams.P = P;
//                        RSAparams.Q = Q;
//                        RSAparams.DP = DP;
//                        RSAparams.DQ = DQ;
//                        RSAparams.InverseQ = IQ;
//                        RSA.ImportParameters(RSAparams);
//                        return RSA;
//                    }
//                    catch (Exception ex)
//                    {
//                        throw ex;
//                    }
//                }
//            }
//        }

//        private static RSACryptoServiceProvider DecodePemPublicKey(byte[] publickey)
//        {
//            // encoded OID sequence for  PKCS #1 rsaEncryption szOID_RSA_RSA = "1.2.840.113549.1.1.1"
//            byte[] SeqOID = { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };
//            byte[] seq = new byte[15];
//            // ---------  Set up stream to read the asn.1 encoded SubjectPublicKeyInfo blob  ------
//            using (MemoryStream mem = new MemoryStream(publickey))
//            {
//                using (BinaryReader binr = new BinaryReader(mem))    //wrap Memory Stream with BinaryReader for easy reading
//                {
//                    byte bt = 0;
//                    ushort twobytes = 0;

//                    try
//                    {

//                        twobytes = binr.ReadUInt16();
//                        if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)
//                            binr.ReadByte();    //advance 1 byte
//                        else if (twobytes == 0x8230)
//                            binr.ReadInt16();   //advance 2 bytes
//                        else
//                            return null;

//                        seq = binr.ReadBytes(15);       //read the Sequence OID
//                        if (!CompareByteArrays(seq, SeqOID))    //make sure Sequence for OID is correct
//                            return null;

//                        twobytes = binr.ReadUInt16();
//                        if (twobytes == 0x8103) //data read as little endian order (actual data order for Bit String is 03 81)
//                            binr.ReadByte();    //advance 1 byte
//                        else if (twobytes == 0x8203)
//                            binr.ReadInt16();   //advance 2 bytes
//                        else
//                            return null;

//                        bt = binr.ReadByte();
//                        if (bt != 0x00)     //expect null byte next
//                            return null;

//                        twobytes = binr.ReadUInt16();
//                        if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)
//                            binr.ReadByte();    //advance 1 byte
//                        else if (twobytes == 0x8230)
//                            binr.ReadInt16();   //advance 2 bytes
//                        else
//                            return null;

//                        twobytes = binr.ReadUInt16();
//                        byte lowbyte = 0x00;
//                        byte highbyte = 0x00;

//                        if (twobytes == 0x8102) //data read as little endian order (actual data order for Integer is 02 81)
//                            lowbyte = binr.ReadByte();  // read next bytes which is bytes in modulus
//                        else if (twobytes == 0x8202)
//                        {
//                            highbyte = binr.ReadByte(); //advance 2 bytes
//                            lowbyte = binr.ReadByte();
//                        }
//                        else
//                            return null;
//                        byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };   //reverse byte order since asn.1 key uses big endian order
//                        int modsize = BitConverter.ToInt32(modint, 0);

//                        byte firstbyte = binr.ReadByte();
//                        binr.BaseStream.Seek(-1, SeekOrigin.Current);

//                        if (firstbyte == 0x00)
//                        {   //if first byte (highest order) of modulus is zero, don't include it
//                            binr.ReadByte();    //skip this null byte
//                            modsize -= 1;   //reduce modulus buffer size by 1
//                        }

//                        byte[] modulus = binr.ReadBytes(modsize);   //read the modulus bytes

//                        if (binr.ReadByte() != 0x02)            //expect an Integer for the exponent data
//                            return null;
//                        int expbytes = (int)binr.ReadByte();        // should only need one byte for actual exponent data (for all useful values)
//                        byte[] exponent = binr.ReadBytes(expbytes);

//                        // ------- create RSACryptoServiceProvider instance and initialize with public key -----
//                        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
//                        RSAParameters RSAKeyInfo = new RSAParameters();
//                        RSAKeyInfo.Modulus = modulus;
//                        RSAKeyInfo.Exponent = exponent;
//                        RSA.ImportParameters(RSAKeyInfo);
//                        return RSA;
//                    }
//                    catch (Exception ex)
//                    {
//                        throw ex;
//                    }

//                }
//            }
//        }

//        private static int GetIntegerSize(BinaryReader binr)
//        {
//            byte bt = 0;
//            byte lowbyte = 0x00;
//            byte highbyte = 0x00;
//            int count = 0;
//            bt = binr.ReadByte();
//            if (bt != 0x02)		//expect integer
//                return 0;
//            bt = binr.ReadByte();

//            if (bt == 0x81)
//                count = binr.ReadByte();	// data size in next byte
//            else
//                if (bt == 0x82)
//            {
//                highbyte = binr.ReadByte(); // data size in next 2 bytes
//                lowbyte = binr.ReadByte();
//                byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
//                count = BitConverter.ToInt32(modint, 0);
//            }
//            else
//            {
//                count = bt;     // we already have the data size
//            }

//            while (binr.ReadByte() == 0x00)
//            {	//remove high order zeros in data
//                count -= 1;
//            }
//            binr.BaseStream.Seek(-1, SeekOrigin.Current);		//last ReadByte wasn't a removed zero, so back up a byte
//            return count;
//        }

//        private static bool CompareByteArrays(byte[] a, byte[] b)
//        {
//            if (a.Length != b.Length)
//                return false;
//            int i = 0;
//            foreach (byte c in a)
//            {
//                if (c != b[i])
//                    return false;
//                i++;
//            }
//            return true;
//        }
//    }
//}
//}
