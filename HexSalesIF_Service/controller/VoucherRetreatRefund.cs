using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;

namespace HexSalesIF_Service.controller
{
    public class VoucherRetreatRefundController : ControllerBase
    {
        public VoucherRetreatRefundController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherTransRefundReq;
            var resp = new VoucherTransRefundResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_RETREAT2", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    //string[] vous = VoucherNo.Split(',');

                    //for (int i = 0; i < vous.Length; i++)
                    //{

                    //    if (vous[i].Trim() != "")
                    //    {

                    oralceComm.Parameters.Clear();
                    oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = newReq.TransNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = newReq.TillNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = newReq.SaleId;
                    oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = newReq.SaleDate;
                    oralceComm.Parameters.Add(new OracleParameter("P_REMARKS1", OracleType.VarChar)).Value = newReq.Remarks1;
                    oralceComm.Parameters.Add(new OracleParameter("P_REMARKS2", OracleType.VarChar)).Value = newReq.Remarks2;


                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Size = 100;
                    PRtnMsg.Direction = ParameterDirection.Output;
                    oralceComm.Parameters.Add(PRtnMsg);


                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    PRTNMSGNO.Size = 50;
                    oralceComm.Parameters.Add(PRTNMSGNO);

                    oralceComm.ExecuteNonQuery();

                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    //    }
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