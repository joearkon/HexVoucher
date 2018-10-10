using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Web;
using HexSalesIF_Service.model;

namespace HexSalesIF_Service.controller
{
    public class VoucherTransactionReturnController : ControllerBase
    {
        public VoucherTransactionReturnController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherTransactionReturnReq;
            var resp = new VoucherQueryResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_RETURN", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    string[] vous = newReq.VoucherNo.Split(',');


                    for (int i = 0; i < vous.Length; i++)
                    {

                        if (vous[i].Trim() != "")
                        {
                            oralceComm.Parameters.Clear();
                            oralceComm.Parameters.Add(new OracleParameter("IsRtn", OracleType.Int32)).Value = newReq.IsRtn;
                            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
                            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = newReq.TillNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = newReq.SaleId;
                            oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = newReq.StaffNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = newReq.RtnDate;

                            oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = newReq.TtransNo;


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
                    }

                    //result = "1";


                }
                catch (Exception e)
                {
                    resp.RtnMsgNo = "99";
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    //result = "0";
                }
                
            }
            return resp;
        }
    }

    public class VoucherTransactionController : ControllerBase
    {
        public VoucherTransactionController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {

            var newReq = baseReq as VoucherTransactionReq;
            var resp = new VoucherQueryResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();
 
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    string[] vous = newReq.VoucherNo.Split(',');

                    for (int i = 0; i < vous.Length; i++)
                    {

                        if (vous[i].Trim() != "")
                        {
                            oralceComm.Parameters.Clear();
                            oralceComm.Parameters.Add(new OracleParameter("P_ISSALE", OracleType.Int32)).Value = newReq.IsSale;
                            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
                            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = newReq.TillNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = newReq.SaleId;
                            oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = newReq.UserCode;
                            oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = newReq.SaleDate;


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
                    }

                    //result = "1";


                }
                catch (Exception e)
                {
                    resp.RtnMsgNo = "99";
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    //result = "0";
                }
                
            }

            return resp; 
        }
    }

    public class VoucherTransactionNewController : ControllerBase
    {
        public VoucherTransactionNewController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherTransactionNewReq;
            var resp = new VoucherQueryResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();

              

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION_NEW", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    string[] vous = newReq.VoucherNo.Split(',');
                    string[] amt = newReq.NetAmt.Split(',');
                    string[] disc = newReq.Distcount.Split(',');


                    for (int i = 0; i < vous.Length; i++)
                    {

                        if (vous[i].Trim() != "")
                        {
                            oralceComm.Parameters.Clear();
                            oralceComm.Parameters.Add(new OracleParameter("P_ISSALE", OracleType.Int32)).Value = newReq.IsSale;
                            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
                            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = newReq.TillNo;
                            oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = newReq.SaleId;


                            oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = newReq.UserCode;
                            oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = newReq.SaleDate;


                            oralceComm.Parameters.Add(new OracleParameter("P_NEAMT", OracleType.Double)).Value = System.Convert.ToDecimal(amt[i].ToString());
                            oralceComm.Parameters.Add(new OracleParameter("P_DISTCOUNT", OracleType.VarChar)).Value = disc[i].Trim(); ;
                            oralceComm.Parameters.Add(new OracleParameter("P_TENDER", OracleType.VarChar)).Value = newReq.Tender;
                            oralceComm.Parameters.Add(new OracleParameter("P_TRANSNO", OracleType.VarChar)).Value = newReq.TtransNo;


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
                    }

                    //result = "1";
                }
                catch (Exception e)
                {
                    resp.RtnMsgNo = "99";
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();

                    //result = "0";
                }
                //finally
                //{

                //    Sign = requestGateway.CreateSign(string.Format("rtnMsg={0}&rtnMsgNo={1}", RtnMsg, RtnMsgNo));
                //}
            }
            return resp;
        }
    }
}