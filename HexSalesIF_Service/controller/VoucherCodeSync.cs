using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;

namespace HexSalesIF_Service.controller
{
    public class VoucherCodeSyncController : ControllerBase
    {
        public VoucherCodeSyncController():base()
        {
        }

        public VoucherCodeSyncController(IWebRequestGate gate) : base(gate)
        {
        }

        //public WebRequestGateway gate = new WebRequestGateway(HttpContext.Current.Request.Headers.Get("version"));
        //public VoucherBaseReq o_excute(IDictionary reqData)
        //{
        //    VoucherCodeSyncResp resp = new VoucherCodeSyncResp();
        //    var sign = "";
        //    foreach (DictionaryEntry item in reqData)
        //    {
        //        if (item.Key.ToString().Equals("sign"))
        //        {
        //            if (item.Value != null)
        //            {
        //                sign = Convert.ToString(item.Value);
        //            }
        //        }
        //    }


        //}
        protected override  VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newObj = baseReq as VoucherCodeSyncReq; // 强制转换
            VoucherCodeSyncResp resp = new VoucherCodeSyncResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCODE_SYNCHRONIZE2", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {
                    int qty = 0;
                    int.TryParse(newObj.VoucherQty, out qty);

                    oralceComm.Parameters.Clear();
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNAME", OracleType.VarChar)).Value = newObj.VoucherName;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newObj.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_QTY", OracleType.Int32)).Value = qty;
                    oralceComm.Parameters.Add(new OracleParameter("P_BARCODEUNIT", OracleType.VarChar)).Value = newObj.BarcodeUnit;
                    oralceComm.Parameters.Add(new OracleParameter("P_STARTDATE", OracleType.VarChar)).Value = newObj.StartDate;
                    oralceComm.Parameters.Add(new OracleParameter("P_EXPIREDDATE", OracleType.VarChar)).Value = newObj.ExpiredDate;
                    oralceComm.Parameters.Add(new OracleParameter("P_UPDATEDATE", OracleType.VarChar)).Value = newObj.UpdateDate;
                    oralceComm.Parameters.Add(new OracleParameter("P_REMARKS1", OracleType.VarChar)).Value = newObj.Remarks1;
                    oralceComm.Parameters.Add(new OracleParameter("P_REMARKS2", OracleType.VarChar)).Value = newObj.Remarks2;


                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Size = 100;
                    PRtnMsg.Direction = ParameterDirection.Output;
                    oralceComm.Parameters.Add(PRtnMsg);


                    OracleParameter PRtnMsgNo = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRtnMsgNo.Direction = ParameterDirection.Output;
                    PRtnMsgNo.Size = 50;
                    oralceComm.Parameters.Add(PRtnMsgNo);



                    //// 返回礼券名称
                    //OracleParameter PRVoucherName = new OracleParameter("V_VOUCHERNAME",
                    //    OracleType.VarChar, 200, ParameterDirection.Output, "", DataRowVersion.Default, false, "");
                    //oralceComm.Parameters.Add(PRVoucherName);

                    //// 返回礼券编码
                    //OracleParameter PRVoucherNo = new OracleParameter("V_VOUCHERNO", OracleType.VarChar);
                    //PRVoucherNo.Direction = ParameterDirection.Output;
                    //PRVoucherNo.Size = 200;
                    //oralceComm.Parameters.Add(PRVoucherNo);

                    //// 礼券条码返回
                    //OracleParameter PRVoucherBcd = new OracleParameter("V_VOUCHERBARCODE", OracleType.VarChar);
                    //PRVoucherBcd.Direction = ParameterDirection.Output;
                    //PRVoucherBcd.Size = 500;
                    //oralceComm.Parameters.Add(PRVoucherBcd);

                    // 返回礼券文档号
                    OracleParameter PRVoucherDocNo = new OracleParameter("V_DOC_NO", OracleType.VarChar);
                    PRVoucherDocNo.Direction = ParameterDirection.Output;
                    PRVoucherDocNo.Size = 50;
                    oralceComm.Parameters.Add(PRVoucherDocNo);

                    oralceComm.ExecuteNonQuery();

                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRtnMsgNo.Value.ToString();

                    resp.VoucherDocNo = PRVoucherDocNo.Value.ToString();
                  

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