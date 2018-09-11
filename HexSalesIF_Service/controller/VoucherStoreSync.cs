using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;

namespace HexSalesIF_Service.controller
{
    public class VoucherStoreSyncController : ControllerBase
    {
        public VoucherStoreSyncController(IWebRequestGateway gate) : base(gate)
        {
        }

        public override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newObj = baseReq as VoucherStoreSyncReq; // 强制转换
            VoucherStoreSyncResp resp = new VoucherStoreSyncResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_STOREINFO_SYNCHRONIZE", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Clear();
                    oralceComm.Parameters.Add(new OracleParameter("P_PROVINCE", OracleType.VarChar)).Value = newObj.Province;
                    oralceComm.Parameters.Add(new OracleParameter("P_CITY", OracleType.VarChar)).Value = newObj.City;
                    oralceComm.Parameters.Add(new OracleParameter("P_COMPANY", OracleType.VarChar)).Value = newObj.Company;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newObj.StoreNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENAME", OracleType.VarChar)).Value = newObj.StoreName;
                    oralceComm.Parameters.Add(new OracleParameter("P_STOREADDR", OracleType.VarChar)).Value = newObj.StoreAddr;
                    oralceComm.Parameters.Add(new OracleParameter("P_STOREEMAIL", OracleType.VarChar)).Value = newObj.StoreEmail;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORETEL", OracleType.VarChar)).Value = newObj.StoreTel;
                    oralceComm.Parameters.Add(new OracleParameter("P_STOREPOSNUM", OracleType.VarChar)).Value = newObj.StorePosNum;
                    oralceComm.Parameters.Add(new OracleParameter("P_OPERATETYPE", OracleType.VarChar)).Value = newObj.OperateType;
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

                    //dbConn.Close();

                    //result = "1";


                }
                catch (Exception e)
                {
                    //dbConn.Close();

                    resp.RtnMsgNo = "99";
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();

                    //result = "0";
                }

            }
            return resp;
        }
    }
}