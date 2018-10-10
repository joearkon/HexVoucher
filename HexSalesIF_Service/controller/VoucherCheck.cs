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

        public VoucherCheckController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
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
            }
            return checkResp;
        }
    }

    public class VoucherCheckNewController : ControllerBase
    {
        public VoucherCheckNewController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherCheckReq;
            var resp = new VoucherCheckNewResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                dbConn.Open();

                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_NEW", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;

                    OracleParameter PItemNo = new OracleParameter("V_VOUCHERITEMNO", OracleType.VarChar);
                    PItemNo.Direction = ParameterDirection.Output;
                    PItemNo.Size = 50;
                    oralceComm.Parameters.Add(PItemNo);

                    OracleParameter Pdisc = new OracleParameter("V_DISNO", OracleType.VarChar);
                    Pdisc.Direction = ParameterDirection.Output;
                    Pdisc.Size = 50;
                    oralceComm.Parameters.Add(Pdisc);


                    OracleParameter PnetAmt = new OracleParameter("V_NETAMT", OracleType.VarChar);
                    PnetAmt.Direction = ParameterDirection.Output;
                    PnetAmt.Size = 50;
                    oralceComm.Parameters.Add(PnetAmt);

                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 100;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    PRTNMSGNO.Size = 50;
                    oralceComm.Parameters.Add(PRTNMSGNO);


                    oralceComm.ExecuteNonQuery();

                    
                    resp.VoucherItemNo = PItemNo.Value.ToString();
                    resp.DisNo = Pdisc.Value.ToString();
                    resp.NetAmt = PnetAmt.Value.ToString();
                    resp.RtnMsg = PRtnMsg.Value.ToString();
                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    // dbConn.Close();


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

    public class VoucherCheckBcpController : ControllerBase
    {
        public VoucherCheckBcpController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherCheckReq;
            var resp = new VoucherCheckBcpResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_BCP", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;


                    OracleParameter PItemNo = new OracleParameter("V_ITEMNO", OracleType.VarChar);
                    PItemNo.Direction = ParameterDirection.Output;
                    PItemNo.Size = 50;
                    oralceComm.Parameters.Add(PItemNo);

                    OracleParameter pDisno = new OracleParameter("V_DISNO", OracleType.VarChar);
                    pDisno.Direction = ParameterDirection.Output;
                    pDisno.Size = 50;
                    oralceComm.Parameters.Add(pDisno);

                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 50;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Size = 100;
                    PRTNMSGNO.Direction = ParameterDirection.Output;


                    oralceComm.Parameters.Add(PRTNMSGNO);


                    oralceComm.ExecuteNonQuery();



                    resp.ItemNo = PItemNo.Value.ToString();

                    resp.DisNo = pDisno.Value.ToString();

                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    //    dbConn.Close();


                    //if (ItemNo != "")
                    //{
                    //    result = "1";
                    //}
                }
                catch (Exception e)
                {
                    // dbConn.Close();
                    resp.RtnMsgNo = newReq.VoucherNo;
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();

                    //result = "0";
                }
                 
            }
            return resp;
        }
    }

    public class VoucherCheckBcpNewController : ControllerBase
    {
        public VoucherCheckBcpNewController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherCheckReq;
            var resp = new VoucherCheckBcpNewResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {
                //  OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();

               
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_BCP_NEW", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;


                    OracleParameter PvoucherItemNo = new OracleParameter("V_VOUCHERITEMNO", OracleType.VarChar);
                    PvoucherItemNo.Direction = ParameterDirection.Output;
                    PvoucherItemNo.Size = 50;
                    oralceComm.Parameters.Add(PvoucherItemNo);


                    OracleParameter PItemNo = new OracleParameter("V_ITEMNO", OracleType.VarChar);
                    PItemNo.Direction = ParameterDirection.Output;
                    PItemNo.Size = 50;
                    oralceComm.Parameters.Add(PItemNo);

                    OracleParameter pDisno = new OracleParameter("V_DISNO", OracleType.VarChar);
                    pDisno.Direction = ParameterDirection.Output;
                    pDisno.Size = 50;
                    oralceComm.Parameters.Add(pDisno);

                    OracleParameter PnetAmt = new OracleParameter("V_NETAMT", OracleType.VarChar);
                    PnetAmt.Direction = ParameterDirection.Output;
                    PnetAmt.Size = 50;
                    oralceComm.Parameters.Add(PnetAmt);



                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 50;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Size = 100;
                    PRTNMSGNO.Direction = ParameterDirection.Output;


                    oralceComm.Parameters.Add(PRTNMSGNO);


                    oralceComm.ExecuteNonQuery();

                    resp.VoucherItemNo = PvoucherItemNo.Value.ToString();
                    resp.ItemNo = PItemNo.Value.ToString();
                    resp.DisNo = pDisno.Value.ToString();
                    resp.NetAmt = PnetAmt.Value.ToString();
                    resp.RtnMsg = PRtnMsg.Value.ToString();
                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    //    dbConn.Close();


                    //if (ItemNo != "")
                    //{
                    //    result = "1";
                    //}

                }
                catch (Exception e)
                {
                    // dbConn.Close();
                    resp.RtnMsgNo = newReq.VoucherNo;
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();

                    //result = "0";
                }
                 
            }

            return resp;
        }
       
    }

    public class VoucherSalesCheckController : ControllerBase
    {
        public VoucherSalesCheckController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherCheckReq;
            var resp = new VoucherSalesCheckResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {

                //OracleConnection dbConn = new OracleConnection(databasedws);
                dbConn.Open();
 
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERSALESCHECK", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;


                    OracleParameter PItemNo = new OracleParameter("V_ITEMNO", OracleType.VarChar);
                    PItemNo.Direction = ParameterDirection.Output;
                    PItemNo.Size = 50;
                    oralceComm.Parameters.Add(PItemNo);

                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 50;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Size = 100;
                    PRTNMSGNO.Direction = ParameterDirection.Output;


                    oralceComm.Parameters.Add(PRTNMSGNO);


                    oralceComm.ExecuteNonQuery();



                    resp.ItemNo = PItemNo.Value.ToString();

                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    //  dbConn.Close();


                    //if (ItemNo == "")
                    //{
                    //    result = "0";
                    //}
                    //else
                    //{
                    //    result = "1";
                    //}

                }
                catch (Exception e)
                {
                    resp.RtnMsgNo = newReq.VoucherNo;
                    resp.RtnMsg = "异常情况：" + e.Message.ToString();
                    //result = "0";
                }
                
            }

            return resp;
        }
    }

    public class VoucherCheckRetrunController : ControllerBase
    {
        public VoucherCheckRetrunController(IWebRequestGate gate) : base(gate)
        {
        }

        protected override VoucherBaseResp Execute(VoucherBaseReq baseReq)
        {
            var newReq = baseReq as VoucherCheckReq;
            var resp = new VoucherCheckRetrunResp();
            string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
            //  string databasedws = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStr"].ToString();   

            using (OracleConnection dbConn = new OracleConnection(databasedws))
            {

                dbConn.Open();
                string step = "";
                OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_RETURN", dbConn);//调用存储过程的方法
                oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
                try
                {
                    step = "123";

                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = newReq.VoucherNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = newReq.StoreNo;

                    OracleParameter Pdisc = new OracleParameter("V_DISNO", OracleType.VarChar);
                    Pdisc.Direction = ParameterDirection.Output;
                    Pdisc.Size = 50;
                    oralceComm.Parameters.Add(Pdisc);


                    OracleParameter PNetAmt = new OracleParameter("V_AMT", OracleType.Int32);
                    PNetAmt.Direction = ParameterDirection.Output;
                    PNetAmt.Size = 50;
                    oralceComm.Parameters.Add(PNetAmt);

                    OracleParameter PItemNo = new OracleParameter("V_ITEM", OracleType.VarChar);
                    PItemNo.Direction = ParameterDirection.Output;
                    PItemNo.Size = 50;
                    oralceComm.Parameters.Add(PItemNo);


                    OracleParameter Ptender = new OracleParameter("V_TENDERNO", OracleType.VarChar);
                    Ptender.Direction = ParameterDirection.Output;
                    Ptender.Size = 50;
                    oralceComm.Parameters.Add(Ptender);

                    step = "457";

                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);

                    PRtnMsg.Direction = ParameterDirection.Output;
                    PRtnMsg.Size = 100;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    PRTNMSGNO.Size = 50;
                    oralceComm.Parameters.Add(PRTNMSGNO);

                    step = "666";
                    oralceComm.ExecuteNonQuery();

                    resp.DisNo = Pdisc.Value.ToString();

                    resp.NetAmt = PNetAmt.Value.ToString();
                    resp.TenderNo = Ptender.Value.ToString();
                    resp.ItemNo = PItemNo.Value.ToString();

                    resp.RtnMsg = PRtnMsg.Value.ToString();

                    resp.RtnMsgNo = PRTNMSGNO.Value.ToString();

                    step = "777";
                }
                catch (Exception e)
                {
                    resp.RtnMsgNo = "99";     
                    resp.RtnMsg = "异常情况：" + e.Message.ToString() + step;

                }
                
            }
            return resp;
        }
    }
}