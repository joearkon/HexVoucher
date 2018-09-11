using HexSalesIF_Service.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;

namespace HexSalesIF_Service.controller
{
    /// <summary>
    /// 礼券检查控制器
    /// </summary>
    public class VoucherCheckController: ControllerBase
    {
        public VoucherCheckController() : base() { }
         
        public override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newObj = baseReq as VoucherCheckReq; // 强制转换
            VoucherCheckResp checkResp = new VoucherCheckResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newObj.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newObj.StoreNo;

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

                    checkResp.DisNo = PItemNo.Value.ToString();

                    checkResp.RtnMsg = PRtnMsg.Value.ToString();

                    checkResp.RtnMsgNo = PRTNMSGNO.Value.ToString();
                }
                catch (Exception e)
                {
                    checkResp.RtnMsgNo = "99";
                    checkResp.RtnMsg = "异常情况：" + e.Message.ToString();
                }
                finally
                {

                }
            }
            return checkResp;
        }
    }
}