using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;

namespace HexSalesIF_Service.controller
{
    public class VoucherOOController : ControllerBase
    {
        public VoucherOOController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newObj = baseReq as VoucherOOReq; // 强制转换
            VoucherOOResp resp = new VoucherOOResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER_OO.SP_VOUCHER_OO", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {
                    oralceComm.Parameters.Add(new OracleParameter("P_TRANS_TP", OracleType.VarChar)).Value = newObj.trans_tp;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_NO", OracleType.VarChar)).Value = newObj.voucher_no;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_QTY", OracleType.VarChar)).Value = newObj.voucher_qty;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_BCD", OracleType.VarChar)).Value = newObj.voucher_bcd;
                    try
                    {
                        oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.DateTime)).Value = System.Convert.ToDateTime(newObj.bizdt_ord);
                    }
                    catch
                    {
                        oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.DateTime)).Value = System.DateTime.Now;
                    }

                    //oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.VarChar)).Value = bizdt_ord;
                    oralceComm.Parameters.Add(new OracleParameter("P_NET_NO_ORD", OracleType.VarChar)).Value = newObj.net_no_ord;
                    oralceComm.Parameters.Add(new OracleParameter("P_CUST_NAME", OracleType.VarChar)).Value = newObj.cust_name;
                    oralceComm.Parameters.Add(new OracleParameter("P_CUST_TEL", OracleType.VarChar)).Value = newObj.cust_tel;
                    oralceComm.Parameters.Add(new OracleParameter("P_CUST_RMK", OracleType.VarChar)).Value = newObj.cust_rmk;
                    oralceComm.Parameters.Add(new OracleParameter("P_RMK", OracleType.VarChar)).Value = newObj.rmk;

                    OracleParameter PRTNtranstp = new OracleParameter("V_TRANS_TP", OracleType.VarChar);
                    PRTNtranstp.Direction = ParameterDirection.Output;
                    PRTNtranstp.Size = 50;
                    oralceComm.Parameters.Add(PRTNtranstp);
                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 100;
                    oralceComm.Parameters.Add(PRtnMsg);
                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    PRTNMSGNO.Size = 50;
                    oralceComm.Parameters.Add(PRTNMSGNO);
                    OracleParameter PRtnVoucherBcd = new OracleParameter("V_VOUCHER_BCD", OracleType.VarChar);
                    PRtnVoucherBcd.Direction = ParameterDirection.Output;
                    PRtnVoucherBcd.Size = 250;
                    oralceComm.Parameters.Add(PRtnVoucherBcd);
                    OracleParameter PRtnVoucherItem = new OracleParameter("V_VOUCHER_ITEM", OracleType.VarChar);
                    PRtnVoucherItem.Direction = ParameterDirection.Output;
                    PRtnVoucherItem.Size = 800;
                    oralceComm.Parameters.Add(PRtnVoucherItem);


                    oralceComm.ExecuteNonQuery();

                    resp.RtnTransTp = PRTNtranstp.Value.ToString();
                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();
                    resp.RtnVoucherBcd = PRtnVoucherBcd.Value.ToString();
                    resp.RtnVoucherItem = PRtnVoucherItem.Value.ToString();

                    ////成功 存储过程返回 00 
                    //if (RtnMsgNo == "1")
                    //{
                    //    //   CheckStatus = "1"; 
                    //    return "1";
                    //}
                    //else
                    //{
                    //    //  CheckStatus = "0"; 
                    //    return "0";
                    //}


                }
                catch (Exception e)
                {
                    resp.RtnTransTp = newObj.trans_tp;
                    resp.RtnMsgNo = "99";
                    // RtnMsg = StoreNo;            
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    resp.RtnVoucherBcd = "";
                    resp.RtnVoucherItem = "";
                }
            }

            return resp;
        }
    }

    public class VoucherCheckOOController : ControllerBase
    {
        public VoucherCheckOOController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var req = baseReq as VoucherCheckReq; // 强制转换
            var resp = new VoucherOOCheckResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            // OracleConnection dbConn = new OracleConnection(databasedws);

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck_OO", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = req.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = req.StoreNo;

                    OracleParameter PItemNo = new OracleParameter("V_DISNO", OracleType.VarChar);
                    PItemNo.Direction = ParameterDirection.Output;
                    PItemNo.Size = 50;
                    oralceComm.Parameters.Add(PItemNo);

                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 100;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    PRTNMSGNO.Size = 50;
                    oralceComm.Parameters.Add(PRTNMSGNO);


                    oralceComm.ExecuteNonQuery();

                    resp.DisNo = PItemNo.Value.ToString();

                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    //   dbConn.Close();
                    //if (DisNo == "")
                    //{
                    //    result = "";
                    //}
                    //else
                    //{
                    //    result = "1";
                    //}


                }
                catch (Exception e)
                {
                    resp.RtnMsgNo = "99";
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    
                }
                
            }
            return resp;
        }
    }
}