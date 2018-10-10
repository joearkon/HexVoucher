using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;
using HexSalesIF_Service.util;

namespace HexSalesIF_Service.controller
{
    public class VoucherQueryController : ControllerBase
    {
        public VoucherQueryController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherQueryReq;
            var resp = new VoucherQueryResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERQUERY", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;
                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 500;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Size = 100;
                    PRTNMSGNO.Direction = ParameterDirection.Output;


                    oralceComm.Parameters.Add(PRTNMSGNO);

                    oralceComm.ExecuteNonQuery();



                    resp.RtnMsg = PRtnMsg.Value.ToString();


                    //RtnMsg = RtnMsg.Replace("~", "\r\n");
                    //  RtnMsg = RtnMsg + "\r\n sdsaddsa";

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    //    dbConn.Close(); 

                    //result = RtnMsgNo;
                    //return RtnMsgNo;



                }
                catch (Exception e)
                {
                    // dbConn.Close();
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    //Sign = this.serviceCommon.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
                    resp.RtnMsgNo = "0";
                    //result = RtnMsgNo;
                }

                finally
                {
                    resp.RtnMsg = WebServiceLib.NewLineString(resp.RtnMsg);
                }
            }
            return resp;
        }
    }

    public class VoucherQueryNewController : ControllerBase
    {
        public VoucherQueryNewController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherQueryNewReq;
            var resp = new VoucherQueryNewResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERQUERY_NEW", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;

                    OracleParameter PVoucherType = new OracleParameter("V_VOUCHERTYPE", OracleType.VarChar);
                    PVoucherType.Direction = ParameterDirection.Output;
                    PVoucherType.Size = 500;
                    oralceComm.Parameters.Add(PVoucherType);
                    OracleParameter PVoucherItemNo = new OracleParameter("V_VOUCHERITEMNO", OracleType.VarChar);
                    PVoucherItemNo.Direction = ParameterDirection.Output;
                    PVoucherItemNo.Size = 500;
                    oralceComm.Parameters.Add(PVoucherItemNo);
                    OracleParameter PVoucherNos = new OracleParameter("V_VOUCHERNO", OracleType.VarChar);
                    PVoucherNos.Direction = ParameterDirection.Output;
                    PVoucherNos.Size = 500;
                    oralceComm.Parameters.Add(PVoucherNos);
                    OracleParameter PVoucherStatus = new OracleParameter("V_VOUCHERSTATUS", OracleType.VarChar);
                    PVoucherStatus.Direction = ParameterDirection.Output;
                    PVoucherStatus.Size = 500;
                    oralceComm.Parameters.Add(PVoucherStatus);
                    OracleParameter PStoreNo = new OracleParameter("V_STORENO", OracleType.VarChar);
                    PStoreNo.Direction = ParameterDirection.Output;
                    PStoreNo.Size = 500;
                    oralceComm.Parameters.Add(PStoreNo);
                    OracleParameter PActivedTime = new OracleParameter("V_ACTIVEDTIME", OracleType.VarChar);
                    PActivedTime.Direction = ParameterDirection.Output;
                    PActivedTime.Size = 500;
                    oralceComm.Parameters.Add(PActivedTime);
                    OracleParameter PCertificatedTime = new OracleParameter("V_CERTIFICATEDTIME", OracleType.VarChar);
                    PCertificatedTime.Direction = ParameterDirection.Output;
                    PCertificatedTime.Size = 500;
                    oralceComm.Parameters.Add(PCertificatedTime);


                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 500;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Size = 100;
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    oralceComm.Parameters.Add(PRTNMSGNO);

                    oralceComm.ExecuteNonQuery();


                    resp.VoucherType = PVoucherType.Value.ToString();
                    resp.VoucherItemNo = PVoucherItemNo.Value.ToString();
                    resp.VoucherNos = PVoucherNos.Value.ToString();
                    resp.VoucherStatus = PVoucherStatus.Value.ToString();
                    resp.StoreNo = PStoreNo.Value.ToString();
                    resp.ActivedTime = PActivedTime.Value.ToString();
                    resp.CertificatedTime = PCertificatedTime.Value.ToString();

                    resp.RtnMsg = PRtnMsg.Value.ToString();
                    //RtnMsg = RtnMsg.Replace("~", "\r\n");
                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();
                    //    dbConn.Close(); 
                    //result = RtnMsgNo;
                    //return RtnMsgNo;

                }
                catch (Exception e)
                {
                    // dbConn.Close();
                    resp.RtnMsgNo = "0";
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    //result = RtnMsgNo;
                }
                finally
                {
                    resp.RtnMsg = WebServiceLib.NewLineString(resp.RtnMsg);
                }
            }
            return resp;
        }
    }
}