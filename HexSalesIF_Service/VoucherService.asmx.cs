using HexSalesIF_Service.controller;
using HexSalesIF_Service.model;
using HexSalesIF_Service.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using Oracle.DataAccess.Client;   // 在windows2008 之后的机器  部署 需要此 类库  
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;     // 在Windows 2004 机器是部署需要此类库 
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace HexSalesIF_Service
{

    /// <summary>
    /// VoucherService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class VoucherService : System.Web.Services.WebService
    {
        private WebServiceCommon serviceCommon { get; set; }
        public VoucherService()
        {
            //如果使用设计的组件，请取消注释以下行 
            //InitializeComponent(); 

            this.serviceCommon = new WebServiceCommon();

        }

        //public string GetMD5(string myString)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    byte[] fromData = System.Text.Encoding.UTF8.GetBytes(myString);
        //    byte[] targetData = md5.ComputeHash(fromData);
        //    string byte2String = null;
        //    for (int i = 0; i < targetData.Length; i++)
        //    {
        //        byte2String += targetData[i].ToString("x2");
        //    }
        //    return byte2String.ToUpper();
        //}


        [WebMethod(Description = "线上礼券预约")]
        public string VoucherOO(string trans_tp, string voucher_no, string voucher_qty,
                                string voucher_bcd, string bizdt_ord, string net_no_ord,
                                string cust_name, string cust_tel, string cust_rmk, string rmk, ref string Sign,
           out string RtnTransTp, out string RtnMsg, out string RtnMsgNo,
           out string RtnVoucherBcd, out string RtnVoucherItem)
        {
            //string result = "0";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary {
            //    { "trans_tp", trans_tp },
            //    { "voucher_no", voucher_no},
            //    { "voucher_qty", voucher_qty},
            //    { "voucher_bcd",voucher_bcd},
            //    { "bizdt_ord",bizdt_ord},
            //    { "net_no_ord",net_no_ord},
            //    { "cust_name",cust_name},
            //    { "cust_tel",cust_tel},
            //    { "cust_rmk",cust_rmk},
            //    { "rmk",rmk},
            //};

            //WebRequestGateway gate = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));
            //VoucherOOResp vcResp = new VoucherOOResp();
            //VoucherOOController c = new VoucherOOController();
            //if (!gate.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    vcResp.RtnMsg = "验签失败";
            //    vcResp.RtnMsgNo = "90";
            //}
            //else
            //{
            //    VoucherBaseResp resp = c.Execute(new VoucherOOReq(trans_tp, voucher_no, voucher_qty, voucher_bcd, bizdt_ord, net_no_ord, cust_name,
            //        cust_tel, cust_rmk, rmk));
            //    vcResp = resp as VoucherOOResp;
            //    result = "1";
            //}

            //RtnMsg = vcResp.RtnMsg;
            //RtnMsgNo = vcResp.RtnMsgNo;
            //RtnTransTp = vcResp.RtnTransTp;
            //RtnVoucherBcd = vcResp.RtnVoucherBcd;
            //RtnVoucherItem = vcResp.RtnVoucherItem;
            //if (RtnMsgNo == "1")
            //{
            //    result = "1";
            //}
            //Sign = gate.CreateSign(new OrderedDictionary
            //{
            //    { "rtnMsg", RtnMsg },
            //    { "rtnMsgNo", RtnMsgNo},
            //    { "rtnTransTp",RtnTransTp},
            //    { "rtnVoucherBcd",RtnVoucherBcd},
            //    {"rtnVoucherItem", RtnVoucherItem}
            //});
            //return result;

            string result = "0";
            RtnTransTp = "";
            RtnVoucherBcd = "";
            RtnVoucherItem = "";
            VoucherOOController c = new VoucherOOController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherOOReq(trans_tp, voucher_no, voucher_qty, voucher_bcd, bizdt_ord, net_no_ord, cust_name,
                    cust_tel, cust_rmk, rmk, Sign));
            if (resp.isExcuteSuccess())
            {
                VoucherOOResp vcResp = resp as VoucherOOResp;
                if (vcResp.RtnMsgNo == "1") { result = "1"; }
                RtnTransTp = vcResp.RtnTransTp;
                RtnVoucherBcd = vcResp.RtnVoucherBcd;
                RtnVoucherItem = vcResp.RtnVoucherItem;

            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;

            //string parString = "";

            //if (trans_tp != null)
            //{
            //    parString = parString + trans_tp + "~";
            //}
            //else
            //{
            //    parString = "~";
            //}

            //if (voucher_no != null)
            //{
            //    parString = parString + voucher_no + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (voucher_qty != null)
            //{
            //    parString = parString + voucher_qty + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (voucher_bcd != null)
            //{
            //    parString = parString + voucher_bcd + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (bizdt_ord != null)
            //{
            //    parString = parString + bizdt_ord + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (net_no_ord != null)
            //{
            //    parString = parString + net_no_ord + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (cust_name != null)
            //{
            //    parString = parString + cust_name + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (cust_tel != null)
            //{
            //    parString = parString + cust_tel + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (cust_rmk != null)
            //{
            //    parString = parString + cust_rmk + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (rmk != null)
            //{
            //    parString = parString + rmk + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    RtnTransTp = "";
            //    RtnMsg = parString;
            //    RtnMsgNo = "99";
            //    RtnVoucherBcd = "";
            //    RtnVoucherItem = "";

            //    return "0";
            //}





            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            //OracleConnection dbConn = new OracleConnection(databasedws);

            //try
            //{
            //    dbConn.Open();
            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER_OO.SP_VOUCHER_OO", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    oralceComm.Parameters.Add(new OracleParameter("P_TRANS_TP", OracleType.VarChar)).Value = trans_tp;
            //    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_NO", OracleType.VarChar)).Value = voucher_no;
            //    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_QTY", OracleType.VarChar)).Value = voucher_qty;
            //    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_BCD", OracleType.VarChar)).Value = voucher_bcd;
            //    try
            //    {
            //        oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.DateTime)).Value = System.Convert.ToDateTime(bizdt_ord);
            //    }
            //    catch
            //    {
            //        oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.DateTime)).Value = System.DateTime.Now;
            //    }

            //    //oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.VarChar)).Value = bizdt_ord;
            //    oralceComm.Parameters.Add(new OracleParameter("P_NET_NO_ORD", OracleType.VarChar)).Value = net_no_ord;
            //    oralceComm.Parameters.Add(new OracleParameter("P_CUST_NAME", OracleType.VarChar)).Value = cust_name;
            //    oralceComm.Parameters.Add(new OracleParameter("P_CUST_TEL", OracleType.VarChar)).Value = cust_tel;
            //    oralceComm.Parameters.Add(new OracleParameter("P_CUST_RMK", OracleType.VarChar)).Value = cust_rmk;
            //    oralceComm.Parameters.Add(new OracleParameter("P_RMK", OracleType.VarChar)).Value = rmk;

            //    OracleParameter PRTNtranstp = new OracleParameter("V_TRANS_TP", OracleType.VarChar);
            //    PRTNtranstp.Direction = ParameterDirection.Output;
            //    PRTNtranstp.Size = 50;
            //    oralceComm.Parameters.Add(PRTNtranstp);
            //    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //    PRtnMsg.Direction = ParameterDirection.Output;
            //    PRtnMsg.Size = 100;
            //    oralceComm.Parameters.Add(PRtnMsg);
            //    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //    PRTNMSGNO.Direction = ParameterDirection.Output;
            //    PRTNMSGNO.Size = 50;
            //    oralceComm.Parameters.Add(PRTNMSGNO);
            //    OracleParameter PRtnVoucherBcd = new OracleParameter("V_VOUCHER_BCD", OracleType.VarChar);
            //    PRtnVoucherBcd.Direction = ParameterDirection.Output;
            //    PRtnVoucherBcd.Size = 250;
            //    oralceComm.Parameters.Add(PRtnVoucherBcd);
            //    OracleParameter PRtnVoucherItem = new OracleParameter("V_VOUCHER_ITEM", OracleType.VarChar);
            //    PRtnVoucherItem.Direction = ParameterDirection.Output;
            //    PRtnVoucherItem.Size = 800;
            //    oralceComm.Parameters.Add(PRtnVoucherItem);


            //    oralceComm.ExecuteNonQuery();

            //    RtnTransTp = PRTNtranstp.Value.ToString();
            //    RtnMsg = PRtnMsg.Value.ToString();

            //    RtnMsgNo = PRTNMSGNO.Value.ToString();
            //    RtnVoucherBcd = PRtnVoucherBcd.Value.ToString();
            //    RtnVoucherItem = PRtnVoucherItem.Value.ToString();

            //    dbConn.Close();

            //    //成功 存储过程返回 00 
            //    if (RtnMsgNo == "1")
            //    {
            //        //   CheckStatus = "1"; 
            //        return "1";
            //    }
            //    else
            //    {
            //        //  CheckStatus = "0"; 
            //        return "0";
            //    }


            //}
            //catch (Exception e)
            //{
            //    //  dbConn.Close();
            //    RtnTransTp = trans_tp;
            //    RtnMsgNo = "99";
            //    // RtnMsg = StoreNo;            
            //    RtnMsg = "异常情况：" + e.Message.ToString();
            //    RtnVoucherBcd = "";
            //    RtnVoucherItem = "";
            //    //RtnMsg = "InvoiceNo:" + InvoiceNo + "StoreNo: " + StoreNo;
            //    // CheckStatus = "0"; 
            //    return "0";
            //}
        }


        //public bool CheckSign(string myString, string sign, out string RtnMsgNo, out string RtnMsg)
        //{

        //    RtnMsgNo = "";
        //    RtnMsg = "";

        //    string signKey = System.Configuration.ConfigurationManager.AppSettings["singKey"];

        //    if (sign != GetMD5(myString + signKey))
        //    {

        //        RtnMsgNo = "98";
        //        RtnMsg = "加密签名错误";
        //        return false;
        //    }


        //    return true;
        //}


        //[WebMethod]
        //public string VoucherCheckTest(string VoucherNo, string StoreNo, string Sign)
        //{

        //    string parString = "";

        //    if (VoucherNo != null)
        //    {
        //        parString = parString + VoucherNo + "~";
        //    }
        //    else
        //    {
        //        parString = "~";
        //    }

        //    if (StoreNo != null)
        //    {
        //        parString = parString + StoreNo + "~";
        //    }
        //    else
        //    {
        //        parString = parString + "~";
        //    }

        //    string signKey = System.Configuration.ConfigurationManager.AppSettings["singKey"];

        //    string serMd5 = GetMD5(parString + signKey);

        //    return "服务器字符串：" + parString + signKey + " 服务器 Sign ：" + serMd5 + " " + "接收 Sign ：" + Sign;


        //}


        [WebMethod(Description = "礼券检查")]
        public string VoucherCheck(string VoucherNo, string StoreNo, ref string Sign, out string DisNo, out string RtnMsg, out string RtnMsgNo)
        {

            string result = "0";
            DisNo = "";
            VoucherCheckController c = new VoucherCheckController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo,Sign));
            if (resp.isExcuteSuccess())
            {
                VoucherCheckResp vcResp = resp as VoucherCheckResp;
                if (vcResp.DisNo != "") { result = "1"; }
                DisNo = vcResp.DisNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;
            // --- 老验证 注释 开始
            //string parString = "";

            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = "~";
            //}

            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    DisNo = "";
            //    return "0";
            //}
            // ---老验证 注释 结束
            //string result = "0";
            //DisNo = "";
            //RtnMsg = "";
            //RtnMsgNo = "";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo}
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            //VoucherCheckResp checkResp = new VoucherCheckResp();
            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{


            //    dbConn.Open();


            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {



            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

            //        OracleParameter PItemNo = new OracleParameter("V_DISNO", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);

            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 100;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        PRTNMSGNO.Size = 50;
            //        oralceComm.Parameters.Add(PRTNMSGNO);


            //        oralceComm.ExecuteNonQuery();

            //        DisNo = PItemNo.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        // dbConn.Close();
            //        if (DisNo == "")
            //        {
            //            result = "";
            //        }
            //        else
            //        {
            //            result = "1";
            //        }


            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();

            //        RtnMsgNo = "99";
            //        // RtnMsg = StoreNo;            
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }

            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary{
            //            { "rtnMsg", RtnMsg },
            //            { "rtnMsgNo", RtnMsgNo},
            //            {"disNo", DisNo }
            //        });
            //    }
            //}
            //return result;



        }

        [WebMethod(Description = "礼券检查(新)")]
        public string VoucherCheckNew(string VoucherNo, string StoreNo, ref string Sign, out string VoucherItemNo, out string DisNo, out string NetAmt, 
            out string RtnMsg, out string RtnMsgNo)
        {

            string result = "0";
            DisNo = "";
            NetAmt = "";
            VoucherItemNo = "";
            var c = new VoucherCheckNewController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                VoucherCheckNewResp vcResp = resp as VoucherCheckNewResp;
                if (vcResp.DisNo != "") { result = "1"; }
                DisNo = vcResp.DisNo;
                VoucherItemNo = vcResp.VoucherItemNo;
                NetAmt = vcResp.NetAmt;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;

            // ----- 老接口 注释 start
            //string parString = "";

            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = "~";
            //}

            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    DisNo = "";
            //    VoucherItemNo = "";
            //    NetAmt = "";
            //    return "0";
            //}
            // ----- 老接口 注释 end


            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo}
            //};

            //string result = "0";
            //DisNo = "";
            //VoucherItemNo = "";
            //NetAmt = "";
            //RtnMsg = "";
            //RtnMsgNo = "";


            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //    Sign, HttpContext.Current.Request.Headers.Get("version")));

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}



            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    dbConn.Open();

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_NEW", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

            //        OracleParameter PItemNo = new OracleParameter("V_VOUCHERITEMNO", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);

            //        OracleParameter Pdisc = new OracleParameter("V_DISNO", OracleType.VarChar);
            //        Pdisc.Direction = ParameterDirection.Output;
            //        Pdisc.Size = 50;
            //        oralceComm.Parameters.Add(Pdisc);


            //        OracleParameter PnetAmt = new OracleParameter("V_NETAMT", OracleType.VarChar);
            //        PnetAmt.Direction = ParameterDirection.Output;
            //        PnetAmt.Size = 50;
            //        oralceComm.Parameters.Add(PnetAmt);

            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 100;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        PRTNMSGNO.Size = 50;
            //        oralceComm.Parameters.Add(PRTNMSGNO);


            //        oralceComm.ExecuteNonQuery();


            //        VoucherItemNo = PItemNo.Value.ToString();

            //        DisNo = Pdisc.Value.ToString();

            //        NetAmt = PnetAmt.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        // dbConn.Close();


            //        if (DisNo == "")
            //        {
            //            result = "";
            //        }
            //        else
            //        {
            //            result = "1";
            //        }


            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();
            //        VoucherItemNo = "";
            //        RtnMsgNo = "99";
            //        NetAmt = "";
            //        // RtnMsg = StoreNo;            
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary{
            //            { "rtnMsg", RtnMsg },
            //            { "rtnMsgNo", RtnMsgNo},
            //            {"disNo", DisNo },
            //            {"netAmt",NetAmt },
            //            { "voucherItemNo",VoucherItemNo}
            //        });

            //    }
            //}
            //return result;

        }



        [WebMethod(Description = ":礼券是否可销退")]
        public string VoucherCheckReturn(string VoucherNo, string StoreNo, ref string Sign, out string DisNo, out string NetAmt, out string ItemNo, out string TenderNo, out string RtnMsg, out string RtnMsgNo)
        {
            string result = "0";
            DisNo = "";
            NetAmt = "";
            ItemNo = "";
            TenderNo = "";
            var c = new VoucherCheckRetrunController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                VoucherCheckRetrunResp vcResp = resp as VoucherCheckRetrunResp;
                if (vcResp.DisNo != "") { result = "1"; }
                DisNo = vcResp.DisNo;
                ItemNo = vcResp.ItemNo;
                NetAmt = vcResp.NetAmt;
                TenderNo = vcResp.TenderNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            

            // -- 老接口 注释
            //string parString = "";

            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = "~";
            //}

            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    DisNo = "";
            //    ItemNo = "";
            //    TenderNo = "";
            //    NetAmt = "";
            //    return "0";
            //}
            // -- 老接口 注释结束
            //string result = "0";
            //DisNo = "";
            //RtnMsg = "";
            //RtnMsgNo = "";
            //TenderNo = "";
            //NetAmt = "";
            //ItemNo = "";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo}
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}
            //string step = "";


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            ////  string databasedws = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStr"].ToString();   

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{

            //    dbConn.Open();

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_RETURN", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {
            //        step = "123";

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

            //        OracleParameter Pdisc = new OracleParameter("V_DISNO", OracleType.VarChar);
            //        Pdisc.Direction = ParameterDirection.Output;
            //        Pdisc.Size = 50;
            //        oralceComm.Parameters.Add(Pdisc);


            //        OracleParameter PNetAmt = new OracleParameter("V_AMT", OracleType.Int32);
            //        PNetAmt.Direction = ParameterDirection.Output;
            //        PNetAmt.Size = 50;
            //        oralceComm.Parameters.Add(PNetAmt);

            //        OracleParameter PItemNo = new OracleParameter("V_ITEM", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);


            //        OracleParameter Ptender = new OracleParameter("V_TENDERNO", OracleType.VarChar);
            //        Ptender.Direction = ParameterDirection.Output;
            //        Ptender.Size = 50;
            //        oralceComm.Parameters.Add(Ptender);

            //        step = "457";

            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 100;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        PRTNMSGNO.Size = 50;
            //        oralceComm.Parameters.Add(PRTNMSGNO);

            //        step = "666";
            //        oralceComm.ExecuteNonQuery();

            //        DisNo = Pdisc.Value.ToString();

            //        // DisNo = "99121";


            //        NetAmt = PNetAmt.Value.ToString();
            //        TenderNo = Ptender.Value.ToString();
            //        ItemNo = PItemNo.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        step = "777";

            //        // dbConn.Close();
            //        if (DisNo == "")
            //        {
            //            result = "";
            //        }
            //        else
            //        {
            //            result = "1";
            //        }


            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();


            //        DisNo = "";
            //        NetAmt = "";
            //        TenderNo = "";
            //        ItemNo = "";


            //        RtnMsgNo = "99";
            //        // RtnMsg = StoreNo;            
            //        RtnMsg = "异常情况：" + e.Message.ToString() + step;

            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary{
            //            { "rtnMsg", RtnMsg },
            //            { "rtnMsgNo", RtnMsgNo},
            //            {"disNo", DisNo },
            //            {"netAmt",NetAmt },
            //            {"tenderNo",TenderNo },
            //            {"itemNo",ItemNo}
            //        });
            //    }
            //}
            return result;

        }


        [WebMethod(Description = "礼券预约")]
        public string VoucherCheck_OO(string VoucherNo, string StoreNo, ref string Sign, out string DisNo, out string RtnMsg, out string RtnMsgNo)
        {

            string result = "0";
            DisNo = "";
            var c = new VoucherCheckOOController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                VoucherOOCheckResp vcResp = resp as VoucherOOCheckResp;
                if (vcResp.DisNo != "") { result = "1"; }
                DisNo = vcResp.DisNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            //string parString = "";

            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = "~";
            //}

            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    DisNo = "";
            //    return "0";
            //}
            //string result = "0";
            //DisNo = "";
            //RtnMsg = "";
            //RtnMsgNo = "";


            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo}
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));

            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            //VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            //// OracleConnection dbConn = new OracleConnection(databasedws);

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    dbConn.Open();

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck_OO", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

            //        OracleParameter PItemNo = new OracleParameter("V_DISNO", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);

            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 100;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        PRTNMSGNO.Size = 50;
            //        oralceComm.Parameters.Add(PRTNMSGNO);


            //        oralceComm.ExecuteNonQuery();

            //        DisNo = PItemNo.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //   dbConn.Close();
            //        if (DisNo == "")
            //        {
            //            result = "";
            //        }
            //        else
            //        {
            //            result = "1";
            //        }


            //    }
            //    catch (Exception e)
            //    {
            //        RtnMsgNo = "99";
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary{
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo},
            //            {"disNo", DisNo }
            //        });
            //    }
            //}
            return result;
        }

        // [WebMethod]
        //public string VoucherCheck_test(string VoucherNo, string StoreNo, string Sign)
        //{

        //    string RtnMsg = "";
        //    string RtnMsgNo = "";
        //    string parString = "";

        //    if (VoucherNo != null)
        //    {
        //        parString = parString + VoucherNo + "~";
        //    }
        //    else
        //    {
        //        parString = "~";
        //    }

        //    if (StoreNo != null)
        //    {
        //        parString = parString + StoreNo + "~";
        //    }
        //    else
        //    {
        //        parString = parString + "~";
        //    }





        //    if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
        //    {

        //        return "RtnMsgNo" + RtnMsgNo + "  RtnMsg:" + RtnMsg;
        //    }


        //    //VoucherNo:string;StoreNo:string;var ItemNo:string

        //    string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
        //    OracleConnection dbConn = new OracleConnection(databasedws);
        //    dbConn.Open();

        //    string DisNo = "";




        //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck", dbConn);//调用存储过程的方法
        //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
        //    try
        //    {

        //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
        //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

        //        OracleParameter PItemNo = new OracleParameter("V_DISNO", OracleType.VarChar);
        //        PItemNo.Direction = ParameterDirection.Output;
        //        PItemNo.Size = 50;
        //        oralceComm.Parameters.Add(PItemNo);

        //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

        //        PRtnMsg.Direction = ParameterDirection.Output;
        //        PRtnMsg.Size = 100;
        //        oralceComm.Parameters.Add(PRtnMsg);

        //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
        //        PRTNMSGNO.Direction = ParameterDirection.Output;
        //        PRTNMSGNO.Size = 50;
        //        oralceComm.Parameters.Add(PRTNMSGNO);


        //        oralceComm.ExecuteNonQuery();

        //        DisNo = PItemNo.Value.ToString();

        //        RtnMsg = PRtnMsg.Value.ToString();

        //        RtnMsgNo = PRTNMSGNO.Value.ToString();

        //        dbConn.Close();
        //        if (DisNo == "")
        //        {
        //            return "0";
        //        }
        //        else
        //        {
        //            return "1";
        //        }


        //    }
        //    catch (Exception e)
        //    {
        //        dbConn.Close();

        //        RtnMsgNo = "99";
        //        // RtnMsg = StoreNo;            
        //        RtnMsg = "异常情况：" + e.Message.ToString();
        //        return RtnMsg;
        //    }
        //}


        [WebMethod]
        public string Test()
        {
            //VoucherNo:string;StoreNo:string;var ItemNo:string

            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];



            //  return databasedws;
            OracleConnection dbConn = new OracleConnection(databasedws);
            dbConn.Open();



            OracleCommand oralceComm = new OracleCommand("  SELECT SYSDATE  AS A  FROM DUAL  ", dbConn);//调用存储过程的方法
            oralceComm.CommandType = CommandType.Text;//存储过程名称
            try
            {
                OracleDataAdapter adp = new OracleDataAdapter(oralceComm);

                System.Data.DataSet DS = new DataSet();

                adp.Fill(DS);

                return DS.Tables[0].Rows[0][0].ToString();




            }
            catch (Exception e)
            {
                dbConn.Close();


                return e.Message.ToString();
            }
        }

        [WebMethod]
        public string Test2()
        {
            VoucherOOReq a = new VoucherOOReq();
            
            a.rmk = "2222";
            var b = a.ToStringDictionary(true);
            foreach (DictionaryEntry i in b)
            {
                var item = i.Key + i.Value.ToString();
            }
            var props = a.GetType().GetProperties();
            List<string> di = new List<string>();
            foreach(var prop in props)
            {
                var item = prop.GetValue(a, null);
               if (item != null)
                {
                    di.Add(item.ToString());
                }
            }
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "sk\\", "VendorPrivateKey.xml");
            var path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "sk\\", "CustomPublicKey.xml");
            var path3 = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory);
            var path4 = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent;

            //var s = WebSecurity.Sign("a=1&b=2", WebSecurity.GetXmlString(path));
            //var t = WebSecurity.Verify("bizdt_ord=AAA&cust_name=xiaoliag", "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==",
            //   WebSecurity.GetXmlString(path2));
            SortedDictionary<string, string> dict = new SortedDictionary<string, string> {
                { "bizdt_ord", "AAA" },
                { "cust_name", "xiaoliag"}};
            var s = this.serviceCommon.CreateSign("a=1&b=2");
            var t = this.serviceCommon.VerifySign(dict, "LNOhvqRJxW3QA31VEMSbamx0uC5U0p6BaDks16CM+ip1IXboKoCZFAGYiyB/Xmq4VwguIoVRbZ9s6JeVNBso3dABVZGUh0H5nfDrqxgwt/SkBrP5DlIe1zjVVey/gq3nZ51Cyhg5mlSEoEC8+2mH79l4aD67qh7xJp0cCUP3WRXkSAb6DNY9ebsLZwpRgeZ05yK0XmUzxrdz3hx4IQlAxIxLBD9knl5Xqvi3aH8KR/lRv0ce6Fpt07mvG+RnDYq/doPzjIigAoKmIKQG2t8C9tMpWVzlHtK8ft7tyagmXROFbh7/EgLIgAqYxFRzlIgWFTDPo6YyU9oUW8uxIv1DBg==");


            SortedDictionary<string, string> dict2 = new SortedDictionary<string, string> {
                { "voucherNo", "941831670000224191"},
                   { "storeNo", "600017" } };
            LogHelper.Debug(string.Format("请求参数 voucherNo{0}, storeNO{1}, sign{2}", "1", "2", "YOPGjMtwZ11i5lDMz5VlrZngauPhYXdqbRb5aO8OMYxVAEn9h5rqKGQNioQY15muw6hrQ0mtHiyY"));
            var d = this.serviceCommon.CreateSign("storeNo=600017&voucherNo=941831670000224191");
            var c = this.serviceCommon.VerifySign(dict2, "VA+57fF0F5Sn31tl/qbueuQI+YOPGjMtwZ11i5lDMz5VlrZngauPhYXdqbRb5aO8OMYxVAEn9h5rqKGQNioQY15muw6hrQ0mtHiyY/J1tyHBhLhxl+gnQCI6Vk6Du7e8S+1Sp2P7tmLYdnnweq3Scb0f+gFtuqgMK0vr586HlxIifAgzGpAPinNfdlwhMNNu2TSxIZnxfimSpjNcXEPtoACT4B5mwXYlYpEhJtwImOK41XWCwFatvZ55Iqt7DgOw4pPbI+eISL2exIaou2GXTtcqmxBKCjgq4L27dQxlFwWLcb7LUjzMOspkH1hqEHvumZdJyNxq55+pGlCd8WSEHg==");

            //string RtnMsg = "";
            //string RtnMsgNo = "";
            //string sign = "VA+57fF0F5Sn31tl/qbueuQI+YOPGjMtwZ11i5lDMz5VlrZngauPhYXdqbRb5aO8OMYxVAEn9h5rqKGQNioQY15muw6hrQ0mtHiyY/J1tyHBhLhxl+gnQCI6Vk6Du7e8S+1Sp2P7tmLYdnnweq3Scb0f+gFtuqgMK0vr586HlxIifAgzGpAPinNfdlwhMNNu2TSxIZnxfimSpjNcXEPtoACT4B5mwXYlYpEhJtwImOK41XWCwFatvZ55Iqt7DgOw4pPbI+eISL2exIaou2GXTtcqmxBKCjgq4L27dQxlFwWLcb7LUjzMOspkH1hqEHvumZdJyNxq55+pGlCd8WSEHg==";
            //this.VoucherQuery("941831670000224191", "600017", ref sign, out RtnMsg, out RtnMsgNo);

            var datapair = @"rtnMsg=条码:941831670000224191 - 2018版星冰粽冰尚礼盒券天猫
折扣:2017版星冰粽冰尚礼盒券天猫
折扣商品:481161 - 领取2017星冰粽冰尚礼盒bom
该礼券必须先预约!&rtnMsgNo=05";
            var e = this.serviceCommon.VerifySign(datapair, "78bRi02Ixcq2h3PaJ5QFpzwGTJbgXd37V3Krm4b9GVqiaUOfUTvRzsROiFNBswoVnjP0G8NvLTWKt2zWa/2be7QY37+HYTKPXpI8FwnQe6FpuLCAmq/8jJYSA6w6vYH3Ub+tJFqx1JbaEDvoTqsMuv9eslAQVbx45KgmKeS3mZIzSaYAs3L6FB0U1UHzBvDFTp8SLEuYp5Jb9uz9ctoXeNwzDy706oaNZEiPYAQhp1whth07AJ1ArZDrmT5q2dd6PmyRqSHD9A2hzM37j7t2g5Xx1ylS/828ER2aueDPTlhdDl/tupY/HtjiyjvflWfy+DcGtHEaouPni1CsijJ2Gw==", true);

            var sign2 = "VA+57fF0F5Sn31tl/qbueuQI+YOPGjMtwZ11i5lDMz5VlrZngauPhYXdqbRb5aO8OMYxVAEn9h5rqKGQNioQY15muw6hrQ0mtHiyY/J1tyHBhLhxl+gnQCI6Vk6Du7e8S+1Sp2P7tmLYdnnweq3Scb0f+gFtuqgMK0vr586HlxIifAgzGpAPinNfdlwhMNNu2TSxIZnxfimSpjNcXEPtoACT4B5mwXYlYpEhJtwImOK41XWCwFatvZ55Iqt7DgOw4pPbI+eISL2exIaou2GXTtcqmxBKCjgq4L27dQxlFwWLcb7LUjzMOspkH1hqEHvumZdJyNxq55+pGlCd8WSEHg==";
            string out1 = "";
            string out2 = "";
            string out3 = "";
            string out4 = "";
            string out5 = "";

            this.VoucherCheckNew("941831670000224191", "600017", ref sign2, out out1, out out2, out out3, out out4, out out5);


            return string.Format("签名验证{0}{1}", s, t);
        }


        [WebMethod(Description = "礼券交易记录")]
        public string VoucherTransaction(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, ref string Sign, out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("Invoke VoucherTransaction voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
               Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";


            VoucherTransactionController c = new VoucherTransactionController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherTransactionReq(IsSale,VoucherNo,StoreNo,TillNo,SaleId,UserCode,SaleDate, Sign));
            if (resp.isExcuteSuccess())
            {
                result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;
            //string parString = "";


            //parString = parString + IsSale.ToString() + "~";


            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TillNo != null)
            //{
            //    parString = parString + TillNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //parString = parString + SaleId.ToString() + "~";


            //if (UserCode != null)
            //{
            //    parString = parString + UserCode.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (SaleDate != null)
            //{
            //    parString = parString + SaleDate.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    return "0";
            //}

            //string result = "0";

            //RtnMsg = "";
            //RtnMsgNo = "";


            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //    { "isSale",IsSale},
            //    { "tillNo",TillNo},
            //    {"saleId",SaleId },
            //    {"userCode",UserCode },
            //    {"saleDate",SaleDate },
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));

            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        string[] vous = VoucherNo.Split(',');

            //        for (int i = 0; i < vous.Length; i++)
            //        {

            //            if (vous[i].Trim() != "")
            //            {
            //                oralceComm.Parameters.Clear();
            //                oralceComm.Parameters.Add(new OracleParameter("P_ISSALE", OracleType.Int32)).Value = IsSale;
            //                oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
            //                oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = TillNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = SaleId;
            //                oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = UserCode;
            //                oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = SaleDate;


            //                OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //                PRtnMsg.Size = 100;
            //                PRtnMsg.Direction = ParameterDirection.Output;
            //                oralceComm.Parameters.Add(PRtnMsg);

            //                OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //                PRTNMSGNO.Direction = ParameterDirection.Output;
            //                PRTNMSGNO.Size = 50;
            //                oralceComm.Parameters.Add(PRTNMSGNO);


            //                oralceComm.ExecuteNonQuery();



            //                RtnMsg = PRtnMsg.Value.ToString();

            //                RtnMsgNo = PRTNMSGNO.Value.ToString();

            //            }
            //        }

            //        result = "1";


            //    }
            //    catch (Exception e)
            //    {
            //        RtnMsgNo = "99";
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    }
            //}
            //return result;
        }



        [WebMethod(Description = "礼券交易记录-新带净值")]
        public string VoucherTransactionNew(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string NetAmt,
            string Distcount, string Tender, string TtransNo, ref string Sign, out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("Invoke VoucherTransactionNew voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
               Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";


            VoucherTransactionNewController c = new VoucherTransactionNewController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherTransactionNewReq(IsSale, VoucherNo, StoreNo, TillNo, UserCode, SaleDate, NetAmt, Distcount, Tender, TtransNo, SaleId, Sign));
                 ;
            if (resp.isExcuteSuccess())
            {
                result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;

            // --- 老接口注释
            //string parString = "";


            //parString = parString + IsSale.ToString() + "~";


            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TillNo != null)
            //{
            //    parString = parString + TillNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //parString = parString + SaleId.ToString() + "~";


            //if (UserCode != null)
            //{
            //    parString = parString + UserCode.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (SaleDate != null)
            //{
            //    parString = parString + SaleDate.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (NetAmt != null)
            //{
            //    parString = parString + NetAmt.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (Distcount != null)
            //{
            //    parString = parString + Distcount.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (Tender != null)
            //{
            //    parString = parString + Tender.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TtransNo != null)
            //{
            //    parString = parString + TtransNo.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    return "0";
            //}
            // ---- 老接口 注释 结束
            //string result = "0";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //    {"tillNo",TillNo },
            //    {"userCode",UserCode },
            //    {"saleDate",SaleDate },
            //    {"netAmt",NetAmt },
            //    {"distcount",Distcount },
            //    {"tender",Tender },
            //    { "ttransNo",TtransNo},
            //    { "isSale",IsSale},
            //    { "saleId",SaleId}
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "验签失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_NEW", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        string[] vous = VoucherNo.Split(',');
            //        string[] amt = NetAmt.Split(',');
            //        string[] disc = Distcount.Split(',');


            //        for (int i = 0; i < vous.Length; i++)
            //        {

            //            if (vous[i].Trim() != "")
            //            {
            //                oralceComm.Parameters.Clear();
            //                oralceComm.Parameters.Add(new OracleParameter("P_ISSALE", OracleType.Int32)).Value = IsSale;
            //                oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
            //                oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = TillNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = SaleId;


            //                oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = UserCode;
            //                oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = SaleDate;


            //                oralceComm.Parameters.Add(new OracleParameter("P_NEAMT", OracleType.Double)).Value = System.Convert.ToDecimal(amt[i].ToString());
            //                oralceComm.Parameters.Add(new OracleParameter("P_DISTCOUNT", OracleType.VarChar)).Value = disc[i].Trim(); ;
            //                oralceComm.Parameters.Add(new OracleParameter("P_TENDER", OracleType.VarChar)).Value = Tender;
            //                oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = TtransNo;


            //                OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //                PRtnMsg.Size = 100;
            //                PRtnMsg.Direction = ParameterDirection.Output;
            //                oralceComm.Parameters.Add(PRtnMsg);

            //                OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //                PRTNMSGNO.Direction = ParameterDirection.Output;
            //                PRTNMSGNO.Size = 50;
            //                oralceComm.Parameters.Add(PRTNMSGNO);


            //                oralceComm.ExecuteNonQuery();
            //                RtnMsg = PRtnMsg.Value.ToString();
            //                RtnMsgNo = PRTNMSGNO.Value.ToString();


            //            }
            //        }

            //        result = "1";
            //    }
            //    catch (Exception e)
            //    {
            //        RtnMsgNo = "99";
            //        RtnMsg = "异常情况：" + e.Message.ToString();

            //        result = "0";
            //    }
            //    finally
            //    {

            //        Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    }
            //}
            //return result;
        }


        [WebMethod(Description = "礼券销售退货")]
        public string VoucherTransactionReturn(int IsRtn, string VoucherNo, string StoreNo, string TillNo,
            int SaleId, string StaffNo, string RtnDate, string TtransNo, ref string Sign, out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("Invoke VoucherTransactionReturn voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";
           

            VoucherTransactionReturnController c = new VoucherTransactionReturnController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherTransactionReturnReq(IsRtn,VoucherNo,StoreNo,TillNo,SaleId,StaffNo,
                RtnDate,TtransNo,Sign));
            if (resp.isExcuteSuccess())
            {
                 result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;
            // --老接口 注释
            //string parString = "";


            //parString = parString + IsRtn.ToString() + "~";


            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TillNo != null)
            //{
            //    parString = parString + TillNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //parString = parString + SaleId.ToString() + "~";


            //if (StaffNo != null)
            //{
            //    parString = parString + StaffNo.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (RtnDate != null)
            //{
            //    parString = parString + RtnDate.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TtransNo != null)
            //{
            //    parString = parString + TtransNo.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}





            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    return "0";
            //}
            // --老接口 注释结束

            //string result = "0";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //    {"isRtn",IsRtn },
            //    {"tillNo",TillNo },
            //    {"saleId",SaleId },
            //    {"rtnDate",RtnDate },
            //    {"ttransNo",TtransNo },
            //    {"staffNo",StaffNo }
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_RETURN", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        string[] vous = VoucherNo.Split(',');


            //        for (int i = 0; i < vous.Length; i++)
            //        {

            //            if (vous[i].Trim() != "")
            //            {
            //                oralceComm.Parameters.Clear();
            //                oralceComm.Parameters.Add(new OracleParameter("IsRtn", OracleType.Int32)).Value = IsRtn;
            //                oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
            //                oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = TillNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = SaleId;
            //                oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = StaffNo;
            //                oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = RtnDate;

            //                oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = TtransNo;


            //                OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //                PRtnMsg.Size = 100;
            //                PRtnMsg.Direction = ParameterDirection.Output;
            //                oralceComm.Parameters.Add(PRtnMsg);

            //                OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //                PRTNMSGNO.Direction = ParameterDirection.Output;
            //                PRTNMSGNO.Size = 50;
            //                oralceComm.Parameters.Add(PRTNMSGNO);


            //                oralceComm.ExecuteNonQuery();



            //                RtnMsg = PRtnMsg.Value.ToString();

            //                RtnMsgNo = PRTNMSGNO.Value.ToString();

            //            }
            //        }

            //        result = "1";


            //    }
            //    catch (Exception e)
            //    {
            //        RtnMsgNo = "99";
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    }
            //}
            //return result;
        }



        [WebMethod(Description = "礼券销售检查")]
        public string VoucherSalesCheck(string VoucherNo, string StoreNo, ref string Sign, out string ItemNo, out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("Invoke VoucherSalesCheck voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";
            ItemNo = "";

            VoucherSalesCheckController c = new VoucherSalesCheckController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                var vcResp = resp as VoucherSalesCheckResp;
                if (vcResp.ItemNo != "") { result = "1"; }
                ItemNo = vcResp.ItemNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;

            //string parString = "";



            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    ItemNo = "";
            //    return "0";
            //}

            //string result = "0";
            //ItemNo = "";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}

            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{

            //    //OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    ItemNo = "";
            //    RtnMsg = "";
            //    RtnMsgNo = "";



            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERSALESCHECK", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;


            //        OracleParameter PItemNo = new OracleParameter("V_ITEMNO", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);

            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 50;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Size = 100;
            //        PRTNMSGNO.Direction = ParameterDirection.Output;


            //        oralceComm.Parameters.Add(PRTNMSGNO);


            //        oralceComm.ExecuteNonQuery();



            //        ItemNo = PItemNo.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //  dbConn.Close();


            //        if (ItemNo == "")
            //        {
            //            result = "0";
            //        }
            //        else
            //        {
            //            result = "1";
            //        }

            //    }
            //    catch (Exception e)
            //    {
            //        RtnMsgNo = VoucherNo;
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary {
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo},
            //            { "itemNo",ItemNo}
            //        });
            //    }
            //}
            //return result;
        }


        [WebMethod(Description = "检查电子或者预约券是否可使用")]
        public string VoucherCheck_BCP(string VoucherNo, string StoreNo, ref string Sign, out string ItemNo, out string DisNo, out string RtnMsg, 
            out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("Invoke VoucherCheck_BCP voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                 Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";
            ItemNo = "";
            DisNo = "";

            VoucherCheckBcpController c = new VoucherCheckBcpController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                var vcResp = resp as VoucherCheckBcpResp;
                if (vcResp.ItemNo != "") { result = "1"; }
                ItemNo = vcResp.ItemNo;
                DisNo = vcResp.DisNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;

            //string parString = "";



            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    ItemNo = "";
            //    DisNo = "";
            //    return "0";
            //}

            //string result = "0";
            //ItemNo = "";
            //DisNo = "";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    ItemNo = "";
            //    RtnMsg = "";
            //    RtnMsgNo = "";
            //    DisNo = "";


            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_BCP", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;


            //        OracleParameter PItemNo = new OracleParameter("V_ITEMNO", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);

            //        OracleParameter pDisno = new OracleParameter("V_DISNO", OracleType.VarChar);
            //        pDisno.Direction = ParameterDirection.Output;
            //        pDisno.Size = 50;
            //        oralceComm.Parameters.Add(pDisno);

            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 50;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Size = 100;
            //        PRTNMSGNO.Direction = ParameterDirection.Output;


            //        oralceComm.Parameters.Add(PRTNMSGNO);


            //        oralceComm.ExecuteNonQuery();



            //        ItemNo = PItemNo.Value.ToString();

            //        DisNo = pDisno.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //    dbConn.Close();


            //        if (ItemNo != "")
            //        {
            //            result = "1";
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();
            //        RtnMsgNo = VoucherNo;
            //        RtnMsg = "异常情况：" + e.Message.ToString();

            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary {
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo},
            //            { "itemNo",ItemNo},
            //            { "disNo",DisNo}
            //        });
            //    }
            //}
            //return result;
        }



        [WebMethod(Description = "检查电子或者预约券是否可使用")]
        public string VoucherCheck_BCPNew(string VoucherNo, string StoreNo, ref string Sign, out string VoucherItemNo, out string ItemNo, 
            out string DisNo, out string NetAmt, out string RtnMsg, out string RtnMsgNo)
        {


            //string parString = "";



            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}


            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    ItemNo = "";
            //    VoucherItemNo = "";
            //    DisNo = "";
            //    NetAmt = "";
            //    return "0";
            //}

            
            LogHelper.Debug(string.Format("Invoke VoucherCheck_BCPNew voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                Sign, HttpContext.Current.Request.Headers.Get("version")));

            string result = "0";
            ItemNo = "";
            VoucherItemNo = "";
            DisNo = "";
            NetAmt = "";
            VoucherCheckBcpNewController c = new VoucherCheckBcpNewController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCheckReq(StoreNo, VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                var vcResp = resp as VoucherCheckBcpNewResp;
                if (vcResp.ItemNo != "") { result = "1"; }
                ItemNo = vcResp.ItemNo;
                VoucherItemNo = vcResp.VoucherItemNo;
                DisNo = vcResp.DisNo;
                NetAmt = vcResp.NetAmt;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}



            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    ItemNo = "";
            //    RtnMsg = "";
            //    RtnMsgNo = "";
            //    DisNo = "";
            //    NetAmt = "";
            //    VoucherItemNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_BCP_NEW", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;


            //        OracleParameter PvoucherItemNo = new OracleParameter("V_VOUCHERITEMNO", OracleType.VarChar);
            //        PvoucherItemNo.Direction = ParameterDirection.Output;
            //        PvoucherItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PvoucherItemNo);


            //        OracleParameter PItemNo = new OracleParameter("V_ITEMNO", OracleType.VarChar);
            //        PItemNo.Direction = ParameterDirection.Output;
            //        PItemNo.Size = 50;
            //        oralceComm.Parameters.Add(PItemNo);

            //        OracleParameter pDisno = new OracleParameter("V_DISNO", OracleType.VarChar);
            //        pDisno.Direction = ParameterDirection.Output;
            //        pDisno.Size = 50;
            //        oralceComm.Parameters.Add(pDisno);

            //        OracleParameter PnetAmt = new OracleParameter("V_NETAMT", OracleType.VarChar);
            //        PnetAmt.Direction = ParameterDirection.Output;
            //        PnetAmt.Size = 50;
            //        oralceComm.Parameters.Add(PnetAmt);



            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 50;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Size = 100;
            //        PRTNMSGNO.Direction = ParameterDirection.Output;


            //        oralceComm.Parameters.Add(PRTNMSGNO);


            //        oralceComm.ExecuteNonQuery();


            //        VoucherItemNo = PvoucherItemNo.Value.ToString();

            //        ItemNo = PItemNo.Value.ToString();

            //        DisNo = pDisno.Value.ToString();

            //        NetAmt = PnetAmt.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //    dbConn.Close();


            //        if (ItemNo != "")
            //        {
            //            result = "1";
            //        }

            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();
            //        RtnMsgNo = VoucherNo;
            //        RtnMsg = "异常情况：" + e.Message.ToString();

            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary {
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo},
            //            { "itemNo",ItemNo},
            //            { "disNo",DisNo},
            //            { "netAmt",NetAmt}
            //        });
            //    }
            //}
            //return result;
        }


        /// <summary>
        ///  礼券查询 WebService方法 
        /// </summary>
        /// <param name="VoucherNo">礼券编号</param>
        /// <param name="StoreNo">门市编码 </param>
        /// <param name="Sign">门市编码 </param>
        /// <param name="RtnMsg">正常 返回 查询信息，错误返回错误描述 </param>
        /// <param name="RtnMsgNo">正常返回1 ，错误返回 0 </param>
        /// <returns></returns>
        [WebMethod(Description = "礼券查询")]
        public string VoucherQuery(string VoucherNo, string StoreNo, ref string Sign, out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("Invoke VoucherQuery voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                 Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";

            VoucherQueryController c = new VoucherQueryController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherQueryReq(VoucherNo, StoreNo, Sign));
            if (resp.isExcuteSuccess())
            {
                result = resp.RtnMsgNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;
            //SortedDictionary<string, string> voucherQueryDict = new SortedDictionary<string, string> {
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo}};


            //bool isValid = this.serviceCommon.VerifySign(voucherQueryDict, Sign);
            //if (!isValid)
            //{
            //    RtnMsg = "验证签名失败";
            //    RtnMsgNo = "90";
            //    Sign = this.serviceCommon.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return "0";
            //}

            //OrderedDictionary voucherQueryDict = new OrderedDictionary {
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo}
            //};

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}

            //// --- 老接口 注释 开始

            ////string parString = "";
            ////if (VoucherNo != null)
            ////{
            ////    parString = parString + VoucherNo + "~";
            ////}
            ////else
            ////{
            ////    parString = parString + "~";
            ////}               

            ////if (StoreNo != null)
            ////{
            ////    parString = parString + StoreNo + "~";
            ////}
            ////else
            ////{
            ////    parString = parString + "~";
            ////} 


            ////if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            ////{

            ////    return "0";
            ////}
            //// --- 老接口 注释 结束



            //// Tina 需要补充具体的业务逻辑

            ////  RtnMsgNo = "1";

            ////  RtnMsg =           "商品：【"+VoucherNo+"】-尊礼卡1212 \r\n";
            ////  RtnMsg = RtnMsg +  "折扣：【" + StoreNo + "】-测试折扣 \r\n";
            ////  RtnMsg = RtnMsg + "状态：一切良好 ";

            ////  return "1";



            //RtnMsg = "";
            //RtnMsgNo = "";
            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERQUERY", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;




            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 500;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Size = 100;
            //        PRTNMSGNO.Direction = ParameterDirection.Output;


            //        oralceComm.Parameters.Add(PRTNMSGNO);

            //        oralceComm.ExecuteNonQuery();



            //        RtnMsg = PRtnMsg.Value.ToString();


            //        //RtnMsg = RtnMsg.Replace("~", "\r\n");



            //        //  RtnMsg = RtnMsg + "\r\n sdsaddsa";

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //    dbConn.Close(); 

            //        result = RtnMsgNo;
            //        //return RtnMsgNo;



            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        //Sign = this.serviceCommon.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //        RtnMsgNo = "0";
            //        result = RtnMsgNo;
            //    }

            //    finally
            //    {
            //        RtnMsg = WebServiceLib.NewLineString(RtnMsg);
            //        Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    }
            //}
            //return result;


        }


        /// <summary>
        ///  礼券查询(给预约业务使用) WebService方法 
        /// </summary>
        /// <param name="VoucherNo">礼券编号</param>
        /// <param name="RtnMsg">正常 返回 查询信息，错误返回错误描述 </param>
        /// <param name="RtnMsgNo">正常返回1 ，错误返回 0 </param>
        /// <returns></returns>
        [WebMethod(Description = " 礼券查询(预约业务使用)")]
        public string VoucherQueryNew(string VoucherNo, ref string Sign, out string VoucherType, out string VoucherItemNo, out string VoucherNos, out string VoucherStatus,
            out string StoreNo, out string ActivedTime, out string CertificatedTime, out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, sign:{1}", VoucherNo, Sign));
            string result = "0";
            VoucherType = "";
            VoucherItemNo = "";
            VoucherNos = "";
            VoucherStatus = "";
            StoreNo = "";
            ActivedTime = "";
            CertificatedTime = "";
            VoucherQueryNewController c = new VoucherQueryNewController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherQueryNewReq(VoucherNo, Sign));
            if (resp.isExcuteSuccess())
            {
                var vcResp = resp as VoucherQueryNewResp;
                result = vcResp.RtnMsgNo;
                VoucherType = vcResp.VoucherType;
                VoucherItemNo = vcResp.VoucherItemNo;
                VoucherNos = vcResp.VoucherNos;
                VoucherStatus = vcResp.VoucherStatus;
                StoreNo = vcResp.StoreNo;
                ActivedTime = vcResp.ActivedTime;
                CertificatedTime = vcResp.CertificatedTime;

            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            return result;


            //OrderedDictionary voucherQueryDict = new OrderedDictionary {
            //    { "voucherNo", VoucherNo }
            //};

            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", WebServiceLib.NewLineString(RtnMsg), RtnMsgNo));
            //    return result;
            //}

            //// --- 老接口 注释开始
            ////string parString = "";

            ////if (VoucherNo != null)
            ////{
            ////    parString = parString + VoucherNo + "~";
            ////}
            ////else
            ////{
            ////    parString = parString + "~";
            ////}

            ////if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            ////{
            ////    VoucherType = "";
            ////    VoucherItemNo = "";
            ////    VoucherNos = "";
            ////    VoucherStatus = "";
            ////    StoreNo = "";
            ////    ActivedTime = "";
            ////    CertificatedTime = "";
            ////    return "0";
            ////}

            //// --- 老接口 注释结束



            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    dbConn.Open();
            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    //VoucherType = "";
            //    //VoucherItemNo = "";
            //    //VoucherNos = "";
            //    //VoucherStatus = "";
            //    //StoreNo = "";
            //    //ActivedTime = "";
            //    //CertificatedTime = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERQUERY_NEW", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;

            //        OracleParameter PVoucherType = new OracleParameter("V_VOUCHERTYPE", OracleType.VarChar);
            //        PVoucherType.Direction = ParameterDirection.Output;
            //        PVoucherType.Size = 500;
            //        oralceComm.Parameters.Add(PVoucherType);
            //        OracleParameter PVoucherItemNo = new OracleParameter("V_VOUCHERITEMNO", OracleType.VarChar);
            //        PVoucherItemNo.Direction = ParameterDirection.Output;
            //        PVoucherItemNo.Size = 500;
            //        oralceComm.Parameters.Add(PVoucherItemNo);
            //        OracleParameter PVoucherNos = new OracleParameter("V_VOUCHERNO", OracleType.VarChar);
            //        PVoucherNos.Direction = ParameterDirection.Output;
            //        PVoucherNos.Size = 500;
            //        oralceComm.Parameters.Add(PVoucherNos);
            //        OracleParameter PVoucherStatus = new OracleParameter("V_VOUCHERSTATUS", OracleType.VarChar);
            //        PVoucherStatus.Direction = ParameterDirection.Output;
            //        PVoucherStatus.Size = 500;
            //        oralceComm.Parameters.Add(PVoucherStatus);
            //        OracleParameter PStoreNo = new OracleParameter("V_STORENO", OracleType.VarChar);
            //        PStoreNo.Direction = ParameterDirection.Output;
            //        PStoreNo.Size = 500;
            //        oralceComm.Parameters.Add(PStoreNo);
            //        OracleParameter PActivedTime = new OracleParameter("V_ACTIVEDTIME", OracleType.VarChar);
            //        PActivedTime.Direction = ParameterDirection.Output;
            //        PActivedTime.Size = 500;
            //        oralceComm.Parameters.Add(PActivedTime);
            //        OracleParameter PCertificatedTime = new OracleParameter("V_CERTIFICATEDTIME", OracleType.VarChar);
            //        PCertificatedTime.Direction = ParameterDirection.Output;
            //        PCertificatedTime.Size = 500;
            //        oralceComm.Parameters.Add(PCertificatedTime);


            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        PRtnMsg.Size = 500;
            //        oralceComm.Parameters.Add(PRtnMsg);

            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Size = 100;
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        oralceComm.Parameters.Add(PRTNMSGNO);

            //        oralceComm.ExecuteNonQuery();


            //        VoucherType = PVoucherType.Value.ToString();
            //        VoucherItemNo = PVoucherItemNo.Value.ToString();
            //        VoucherNos = PVoucherNos.Value.ToString();
            //        VoucherStatus = PVoucherStatus.Value.ToString();
            //        StoreNo = PStoreNo.Value.ToString();
            //        ActivedTime = PActivedTime.Value.ToString();
            //        CertificatedTime = PCertificatedTime.Value.ToString();

            //        RtnMsg = PRtnMsg.Value.ToString();
            //        //RtnMsg = RtnMsg.Replace("~", "\r\n");
            //        RtnMsgNo = PRTNMSGNO.Value.ToString();
            //        //    dbConn.Close(); 
            //        result = RtnMsgNo;
            //        //return RtnMsgNo;

            //    }
            //    catch (Exception e)
            //    {
            //        // dbConn.Close();
            //        RtnMsgNo = "0";
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = RtnMsgNo;
            //    }
            //    finally
            //    {
            //        RtnMsg = WebServiceLib.NewLineString(RtnMsg);
            //        Sign = requestGateway.CreateSign(new OrderedDictionary {
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo},
            //            { "voucherType", VoucherType},
            //            { "VoucherItemNo", VoucherItemNo},
            //            { "voucherNos",VoucherNos},
            //            { "voucherStatus",VoucherStatus},
            //            { "storeNo",StoreNo},
            //            { "certificatedTime",CertificatedTime},
            //            { "activedTime",ActivedTime}
            //        });
            //    }
            //}
            //return result;


        }


        [WebMethod(Description = "礼券销退交易冲正")]
        public string VoucherTransactionRetreatRefund(string TransNo, string VoucherNo, ref string Sign, string StoreNo, string TillNo,
                                                      int SaleId, string SaleDate, string Remarks1, string Remarks2,
                                                      out string RtnMsg, out string RtnMsgNo)
        {


            LogHelper.Debug(string.Format("Invoke VoucherTransactionRetreatRefund voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                 Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";

            VoucherRetreatRefundController c = new VoucherRetreatRefundController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherTransRefundReq(VoucherNo, StoreNo, TransNo, TillNo, SaleId, SaleDate, Remarks1, Remarks2, Sign));
            if (resp.isExcuteSuccess())
            {
                result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;

            //string parString = "";

            //if (TransNo != null)
            //{
            //    parString = parString + TransNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TillNo != null)
            //{
            //    parString = parString + TillNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //parString = parString + SaleId.ToString() + "~";


            //if (SaleDate != null)
            //{
            //    parString = parString + SaleDate.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (Remarks1 != null)
            //{
            //    parString = parString + Remarks1 + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (Remarks2 != null)
            //{
            //    parString = parString + Remarks2 + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    return "0";
            //}

            //string result = "0";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //    { "transNo",TransNo},
            //    { "tillNo",TillNo},
            //    { "saleId",SaleId},
            //    { "saleDate",SaleDate},
            //    { "remarks1",Remarks1},
            //    { "remarks2",Remarks2},
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "验签失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_RETREAT2", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        //string[] vous = VoucherNo.Split(',');

            //        //for (int i = 0; i < vous.Length; i++)
            //        //{

            //        //    if (vous[i].Trim() != "")
            //        //    {

            //        oralceComm.Parameters.Clear();
            //        oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = TransNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = TillNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = SaleId;
            //        oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = SaleDate;
            //        oralceComm.Parameters.Add(new OracleParameter("P_REMARKS1", OracleType.VarChar)).Value = Remarks1;
            //        oralceComm.Parameters.Add(new OracleParameter("P_REMARKS2", OracleType.VarChar)).Value = Remarks2;


            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Size = 100;
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        oralceComm.Parameters.Add(PRtnMsg);


            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        PRTNMSGNO.Size = 50;
            //        oralceComm.Parameters.Add(PRTNMSGNO);

            //        oralceComm.ExecuteNonQuery();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //    }
            //        //}

            //        result = "1";
            //    }
            //    catch (Exception e)
            //    {
            //        RtnMsgNo = "99";
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary {
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo}
            //        });
            //    }
            //}
            return result;

        }

        [WebMethod(Description = "礼券核销交易冲正")]
        public string VoucherTransactionWriteOffRefund(string TransNo, string VoucherNo, ref string Sign, string StoreNo, string TillNo,
                                                      int SaleId, string SaleDate, string Remarks1, string Remarks2,
                                                      out string RtnMsg, out string RtnMsgNo)
        {
            LogHelper.Debug(string.Format("Invoke VoucherTransactionWriteOffRefund voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
                 Sign, HttpContext.Current.Request.Headers.Get("version")));
            string result = "0";

            VoucherTransRefundController c = new VoucherTransRefundController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherTransRefundReq(VoucherNo,StoreNo,TransNo,TillNo,SaleId,SaleDate, Remarks1, Remarks2, Sign));
            if (resp.isExcuteSuccess())
            {
                result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;

            //string parString = "";

            //if (TransNo != null)
            //{
            //    parString = parString + TransNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (VoucherNo != null)
            //{
            //    parString = parString + VoucherNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (StoreNo != null)
            //{
            //    parString = parString + StoreNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (TillNo != null)
            //{
            //    parString = parString + TillNo + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //parString = parString + SaleId.ToString() + "~";


            //if (SaleDate != null)
            //{
            //    parString = parString + SaleDate.ToString() + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (Remarks1 != null)
            //{
            //    parString = parString + Remarks1 + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}

            //if (Remarks2 != null)
            //{
            //    parString = parString + Remarks2 + "~";
            //}
            //else
            //{
            //    parString = parString + "~";
            //}



            //if (!CheckSign(parString, Sign, out RtnMsgNo, out RtnMsg))
            //{
            //    return "0";
            //}

            //string result = "0";
            //OrderedDictionary voucherQueryDict = new OrderedDictionary
            //{
            //    { "voucherNo", VoucherNo },
            //    { "storeNo", StoreNo},
            //    { "transNo",TransNo},
            //    { "tillNo",TillNo},
            //    { "saleId",SaleId},
            //    { "saleDate",SaleDate},
            //    { "remarks1",Remarks1},
            //    { "remarks2",Remarks2},
            //};



            //LogHelper.Debug(string.Format("请求参数 voucherNo:{0}, storeNo:{1}, sign:{2}, version:{3}", VoucherNo, StoreNo,
            //     Sign, HttpContext.Current.Request.Headers.Get("version")));


            //WebRequestGateway requestGateway = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));


            //if (!requestGateway.VerifyRequestDataSign(voucherQueryDict, Sign))
            //{
            //    RtnMsg = "参数验证失败";
            //    RtnMsgNo = "90";
            //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
            //    return result;
            //}


            ////VoucherNo:string;StoreNo:string;var ItemNo:string

            //string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            //using (OracleConnection dbConn = new OracleConnection(databasedws))
            //{
            //    //  OracleConnection dbConn = new OracleConnection(databasedws);
            //    dbConn.Open();

            //    RtnMsg = "";
            //    RtnMsgNo = "";

            //    OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_REFUND2", dbConn);//调用存储过程的方法
            //    oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
            //    try
            //    {

            //        //string[] vous = VoucherNo.Split(',');

            //        //for (int i = 0; i < vous.Length; i++)
            //        //{

            //        //    if (vous[i].Trim() != "")
            //        //    {

            //        oralceComm.Parameters.Clear();
            //        oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = TransNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = TillNo;
            //        oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = SaleId;
            //        oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = SaleDate;
            //        oralceComm.Parameters.Add(new OracleParameter("P_REMARKS1", OracleType.VarChar)).Value = Remarks1;
            //        oralceComm.Parameters.Add(new OracleParameter("P_REMARKS2", OracleType.VarChar)).Value = Remarks2;


            //        OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
            //        PRtnMsg.Size = 100;
            //        PRtnMsg.Direction = ParameterDirection.Output;
            //        oralceComm.Parameters.Add(PRtnMsg);


            //        OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
            //        PRTNMSGNO.Direction = ParameterDirection.Output;
            //        PRTNMSGNO.Size = 50;
            //        oralceComm.Parameters.Add(PRTNMSGNO);

            //        oralceComm.ExecuteNonQuery();

            //        RtnMsg = PRtnMsg.Value.ToString();

            //        RtnMsgNo = PRTNMSGNO.Value.ToString();

            //        //    }
            //        //}

            //        //dbConn.Close();
            //        result = "1";


            //    }
            //    catch (Exception e)
            //    {
            //        //dbConn.Close();

            //        RtnMsgNo = "99";
            //        RtnMsg = "异常情况：" + e.Message.ToString();
            //        result = "0";
            //    }
            //    finally
            //    {
            //        Sign = requestGateway.CreateSign(new OrderedDictionary {
            //            { "rtnMsg", RtnMsg},
            //            { "rtnMsgNo", RtnMsgNo}
            //        });
            //    }
            //}
            //return result;
        }


        [WebMethod(Description = "礼券作废")]
        public string VoucherObsolete(string VoucherNo, string UpdateDate, ref string Sign, string Remarks1, string Remarks2,
            out string RtnMsg, out string RtnMsgNo)
        {

            LogHelper.Debug(string.Format("方法 VoucherObsolete, 请求参数 voucherNo:{0}, UpdateDate:{1}, sign:{2}, version:{3}", VoucherNo, UpdateDate,
                 Sign, HttpContext.Current.Request.Headers.Get("version")));
             
            string result = "0";
             
            VoucherObsoleteController c = new VoucherObsoleteController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherObsoleteReq(VoucherNo, UpdateDate, Remarks1, Remarks2, Sign));
            if (resp.isExcuteSuccess())
            {
                result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;
        }

        [WebMethod(Description = "门店信息同步")]
        public string StoreInformationSynchronize(string Province, string City, ref string Sign, string Company, string StoreNo,
            string StoreName, string StoreAddr, string StoreEmail,
            string StoreTel, string StorePosNum, string OperateType,
            string Remarks1, string Remarks2, out string RtnMsg, out string RtnMsgNo)
        {
            LogHelper.Debug(string.Format("方法 StoreInformationSynchronize, storeno:{0}, sign:{1}, version:{2}", StoreNo,
                 Sign, HttpContext.Current.Request.Headers.Get("version")));

            string result = "0";
            VoucherStoreSyncController c = new VoucherStoreSyncController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherStoreSyncReq(Province, City, Company, StoreNo, StoreName, StoreAddr,
                   StoreEmail, StoreTel, StorePosNum, OperateType, Remarks1, Remarks2, Sign));
            if (resp.isExcuteSuccess())
            {
                  result = "1";
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;

             
        }

        /// <summary>
        /// 礼券发码同步
        /// </summary>
        /// <param name="VoucherName"> 礼券名称</param>
        /// <param name="VoucherNo">礼券编码</param>
        /// <param name="Sign">签名</param>
        /// <param name="BarcodeUnit">条码单位</param>
        /// <param name="StartDate">启用日期</param>
        /// <param name="ExpiredDate">过期日期</param>
        /// <param name="UpdateDate">更新时间</param>
        /// <param name="Remarks1">备注1</param>
        /// <param name="Remarks2">备注2</param>
        /// <param name="RtnMsg"></param>
        /// <param name="RtnMsgNo"></param>
        /// <returns></returns>
        [WebMethod(Description = "礼券发码同步接口")]
        public string VoucherCodeSynchronize(string VoucherName, string VoucherNo, string VoucherQty, ref string Sign, string BarcodeUnit,
            string StartDate, string ExpiredDate, string UpdateDate, string Remarks1, string Remarks2,
            out string RtnMsg, out string RtnMsgNo, out string SNo)
        {
            LogHelper.Debug(string.Format("方法 CodeSynchronzie, 请求参数 voucherNo:{0}, StartDate:{1}, sign:{2}, version:{3}", VoucherNo, StartDate,
                Sign, HttpContext.Current.Request.Headers.Get("version")));
            
            string result = "0";
            SNo = "";
            VoucherCodeSyncController c = new VoucherCodeSyncController(new WebRequestGate(HttpContext.Current.Request.Headers.Get("version")));
            var resp = c.ExecuteAll(new VoucherCodeSyncReq(VoucherName, VoucherNo, VoucherQty, BarcodeUnit, StartDate,
                    ExpiredDate, UpdateDate, Remarks1, Remarks2, Sign));
            if (resp.isExcuteSuccess())
            {
                if (resp.RtnMsgNo == "00") { result = "1"; }
                SNo = (resp as VoucherCodeSyncResp).VoucherDocNo;
            }

            RtnMsg = resp.RtnMsg;
            RtnMsgNo = resp.RtnMsgNo;
            Sign = resp.Sign;
            return result;
        }


    }
}

