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
        public override VoucherBaseResp Execute(VoucherBaseReq baseReq)
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
                    oralceComm.Parameters.Add(new OracleParameter("P_TRANS_TP", OracleType.VarChar)).Value = newObj.TransTp;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_NO", OracleType.VarChar)).Value = newObj.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_QTY", OracleType.VarChar)).Value = newObj.VoucherQty;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHER_BCD", OracleType.VarChar)).Value = newObj.VoucherBcd;
                    try
                    {
                        oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.DateTime)).Value = System.Convert.ToDateTime(newObj.BizdtOrd);
                    }
                    catch
                    {
                        oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.DateTime)).Value = System.DateTime.Now;
                    }

                    //oralceComm.Parameters.Add(new OracleParameter("P_BIZDT_ORD", OracleType.VarChar)).Value = bizdt_ord;
                    oralceComm.Parameters.Add(new OracleParameter("P_NET_NO_ORD", OracleType.VarChar)).Value = newObj.NetNoOrd;
                    oralceComm.Parameters.Add(new OracleParameter("P_CUST_NAME", OracleType.VarChar)).Value = newObj.CustName;
                    oralceComm.Parameters.Add(new OracleParameter("P_CUST_TEL", OracleType.VarChar)).Value = newObj.CustTel;
                    oralceComm.Parameters.Add(new OracleParameter("P_CUST_RMK", OracleType.VarChar)).Value = newObj.CustRmk;
                    oralceComm.Parameters.Add(new OracleParameter("P_RMK", OracleType.VarChar)).Value = newObj.Rmk;

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
                    resp.RtnTransTp = newObj.TransTp;
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
}