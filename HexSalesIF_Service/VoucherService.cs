using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.OracleClient;
using System.Data.Common;
using System.Data;

/// <summary>
/// VoucherService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class VoucherService : System.Web.Services.WebService {

    public VoucherService () {
        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }


    
    [WebMethod]
    public string  VoucherCheck(string VoucherNo, string StoreNo, out string DisNo, out string RtnMsg, out string RtnMsgNo)
    {

        //VoucherNo:string;StoreNo:string;var ItemNo:string

        string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
        OracleConnection dbConn = new OracleConnection(databasedws);
        dbConn.Open();

        DisNo = "";
        RtnMsg = "";
        RtnMsgNo = "";

        

        OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck", dbConn);//调用存储过程的方法
        oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
        try
        {

            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

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

            DisNo = PItemNo.Value.ToString();

            RtnMsg = PRtnMsg.Value.ToString();

            RtnMsgNo = PRTNMSGNO.Value.ToString();

            dbConn.Close();
            if (DisNo == "")
            {
                return "";
            }
            else
            {
                return "1";
            }
           

        }
        catch (Exception e)
        {
            dbConn.Close();

            RtnMsgNo = "99";
           // RtnMsg = StoreNo;            
            RtnMsg = "异常情况：" + e.Message.ToString();
            return "0";
        }
    }



    [WebMethod]
    public string VoucherCheck_test(string VoucherNo, string StoreNo )
    {

        //VoucherNo:string;StoreNo:string;var ItemNo:string

        string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
        OracleConnection dbConn = new OracleConnection(databasedws);
        dbConn.Open();

       string   DisNo = "";
       string  RtnMsg = "";
       string  RtnMsgNo = "";



        OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VoucherCheck", dbConn);//调用存储过程的方法
        oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
        try
        {

            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;

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

            DisNo = PItemNo.Value.ToString();

            RtnMsg = PRtnMsg.Value.ToString();

            RtnMsgNo = PRTNMSGNO.Value.ToString();

            dbConn.Close();
            if (DisNo == "")
            {
                return "0";
            }
            else
            {
                return "1";
            }


        }
        catch (Exception e)
        {
            dbConn.Close();

            RtnMsgNo = "99";
            // RtnMsg = StoreNo;            
            RtnMsg = "异常情况：" + e.Message.ToString();
            return RtnMsg ;
        }
    }

    [WebMethod]
    public string  VoucherTransaction(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, out string RtnMsg, out string RtnMsgNo)
    {

        //VoucherNo:string;StoreNo:string;var ItemNo:string

        string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
        OracleConnection dbConn = new OracleConnection(databasedws);
        dbConn.Open();

        RtnMsg = "";
        RtnMsgNo = "";

        OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERTRANSACTION", dbConn);//调用存储过程的方法
        oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
        try
        {

            string[] vous = VoucherNo.Split(',');

            for (int i = 0; i < vous.Length; i++)
            {

                if (vous[i].Trim() != "")
                {
                    oralceComm.Parameters.Clear(); 
                    oralceComm.Parameters.Add(new OracleParameter("P_ISSALE", OracleType.Int32)).Value = IsSale;
                    oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = vous[i].Trim();
                    oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_TILLNO", OracleType.VarChar)).Value = TillNo;
                    oralceComm.Parameters.Add(new OracleParameter("P_SALEID", OracleType.Int32)).Value = SaleId;
                    oralceComm.Parameters.Add(new OracleParameter("P_USERCODE", OracleType.VarChar)).Value = UserCode;
                    oralceComm.Parameters.Add(new OracleParameter("P_SALEDATE", OracleType.VarChar)).Value = SaleDate;


                    OracleParameter PRtnMsg = new OracleParameter("V_RTNMSG", OracleType.VarChar);
                    PRtnMsg.Size = 100;
                    PRtnMsg.Direction = ParameterDirection.Output;
                    oralceComm.Parameters.Add(PRtnMsg);

                    OracleParameter PRTNMSGNO = new OracleParameter("V_RTNMSGNO", OracleType.VarChar);
                    PRTNMSGNO.Direction = ParameterDirection.Output;
                    PRTNMSGNO.Size = 50;
                    oralceComm.Parameters.Add(PRTNMSGNO);


                    oralceComm.ExecuteNonQuery();



                    RtnMsg = PRtnMsg.Value.ToString();

                    RtnMsgNo = PRTNMSGNO.Value.ToString();

                }
            }

            dbConn.Close(); 
            return "1";


        }
        catch (Exception e)
        {
            dbConn.Close();

            RtnMsgNo = "99";
            RtnMsg = "异常情况：" + e.Message.ToString();
            return "0";
        }
    }

     
    [WebMethod]
    public string  VoucherSalesCheck(string VoucherNo, string StoreNo, out string ItemNo, out string RtnMsg, out string RtnMsgNo)
    {

        //VoucherNo:string;StoreNo:string;var ItemNo:string

        string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
        OracleConnection dbConn = new OracleConnection(databasedws);
        dbConn.Open();

        ItemNo = "";
        RtnMsg = "";
        RtnMsgNo = "";

    

        OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERSALESCHECK", dbConn);//调用存储过程的方法
        oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
        try
        {

            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;
              

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



            ItemNo = PItemNo.Value.ToString();

            RtnMsg = PRtnMsg.Value.ToString();

            RtnMsgNo = PRTNMSGNO.Value.ToString();

            dbConn.Close();


            if (ItemNo == "")
            {
                return "0";
            }
            else
            {
                return "1";
            }
           
        }
        catch (Exception e)
        {
            dbConn.Close();
            RtnMsgNo = VoucherNo;
            RtnMsg = "异常情况：" + e.Message.ToString(); 
            return "0";
        }
    }




    [WebMethod]
    public string VoucherCheck_BCP(string VoucherNo, string StoreNo, out string ItemNo,  out string DisNo, out string RtnMsg, out string RtnMsgNo)
    {

        //VoucherNo:string;StoreNo:string;var ItemNo:string

        string databasedws = System.Configuration.ConfigurationManager.AppSettings["DbConn"];
        OracleConnection dbConn = new OracleConnection(databasedws);
        dbConn.Open();

        ItemNo = "";
        RtnMsg = "";
        RtnMsgNo = "";
        DisNo = "";


        OracleCommand oralceComm = new OracleCommand("PG_VOUCHER.SP_VOUCHERCHECK_BCP", dbConn);//调用存储过程的方法
        oralceComm.CommandType = CommandType.StoredProcedure;//存储过程名称
        try
        {

            oralceComm.Parameters.Add(new OracleParameter("P_VOUCHERNO", OracleType.VarChar)).Value = VoucherNo;
            oralceComm.Parameters.Add(new OracleParameter("P_STORENO", OracleType.VarChar)).Value = StoreNo;


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



            ItemNo = PItemNo.Value.ToString();

            DisNo = pDisno.Value.ToString();

            RtnMsg = PRtnMsg.Value.ToString();

            RtnMsgNo = PRTNMSGNO.Value.ToString();
 
            dbConn.Close();


            if (ItemNo == "")
            {
                return "0";
            }
            else
            {
                return "1";
            }

        }
        catch (Exception e)
        {
            dbConn.Close();
            RtnMsgNo = VoucherNo;
            RtnMsg = "异常情况：" + e.Message.ToString();

            return "0";
        }
    }



}

