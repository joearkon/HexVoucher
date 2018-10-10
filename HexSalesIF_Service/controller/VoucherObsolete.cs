using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;

namespace HexSalesIF_Service.controller
{
    public class VoucherObsoleteController : ControllerBase
    {
        public VoucherObsoleteController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newObj = baseReq as VoucherObsoleteReq; // 强制转换
            VoucherObsoleteResp resp = new VoucherObsoleteResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {

                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHER_OBSOLETE", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {
                    oralceComm.Parameters.Clear();
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newObj.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_UPDATEDATE", OracleType.VarChar)).Value = newObj.UpdateDate;
                    oralceComm.Parameters.Add(new OracleParameter("P_REMARKS1", OracleType.VarChar)).Value = newObj.Remarks1;
                    oralceComm.Parameters.Add(new OracleParameter("P_REMARKS2", OracleType.VarChar)).Value = newObj.Remarks2;


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