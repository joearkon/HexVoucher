using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
 
namespace WS_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public string GetMD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.UTF8.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String.ToUpper();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a  = new WS_TEST.WebReference.VoucherService();


                string discNo = "";
                string MsgNo = "";
                string MsgTxt = "";
                string netAmt = "";
                string itemNo = "";
                string tenderNo = "";


                string sign = GetMD5(this.textBox_VoucerNo.Text + "~" + this.textBox_StNo.Text + "~" + this.textBox4.Text)                ;

              a.VoucherCheckReturn(this.textBox_VoucerNo.Text, this.textBox_StNo.Text,sign, out discNo,out   netAmt,out itemNo,out tenderNo , out  MsgTxt, out MsgNo);

              this.textBox_rtn.Text = "返回： DisNo:" + discNo + "  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo +" netAmt:" + netAmt + " itemNo: " + itemNo + " tenderNo:" + tenderNo;
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();

                a.Test();

                MessageBox.Show("服务器返回时间：" + a.Test());
            }
            catch (Exception err)
            {

                MessageBox.Show("执行出错："+err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();


                string discNo = "";
                string MsgNo = "";
                string MsgTxt = "";
                string netAmt = "";
         //       string itemNo = "";
         //       string tenderNo = "";



                string sign = GetMD5(this.textBox_VoucerNo.Text + "~" + this.textBox_StNo.Text + "~" + this.textBox4.Text);

           //     a.VoucherCheckNew(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, sign, out discNo, out netAmt, out MsgTxt, out MsgNo);

                 //   (this.textBox1.Text, this.textBox3.Text, out discNo, out   netAmt, out itemNo, out tenderNo, out  MsgTxt, out MsgNo);

                this.textBox_rtn.Text = "返回： DisNo:" + discNo + "  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo + " netAmt:" + netAmt;
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService(); 

                string discNo = "";
                string MsgNo = "";
                string MsgTxt = "";
            //    string netAmt = "";
                string itemNo = "";
               // string tenderNo = "";


                string sign = GetMD5(this.textBox_VoucerNo.Text + "~" + this.textBox_StNo.Text + "~" + this.textBox4.Text);


                a.VoucherSalesCheck(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, sign, out itemNo, out MsgTxt, out MsgNo);
                    
                    //(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, out discNo, out netAmt, out MsgTxt, out MsgNo);


                this.textBox_rtn.Text = "返回： DisNo:" + discNo + "  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo + " itemNo:" + itemNo + " MsgTxt:" + MsgTxt;
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }  
        }

        private void button8_Click(object sender, EventArgs e)
        {


            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();

               // string discNo = "";
                string MsgNo = "";
                string MsgTxt = "";
             //   string netAmt = "";
             //   string itemNo = "";


                string sign = GetMD5("1~" + this.textBox_VOUCHERS.Text + "~" + this.textBox_StNo.Text + "~1101~119~HHS~2017-05-05~" + this.textBox_netAmts.Text + "~" + this.textBox_Disc.Text + "~1~122~" + this.textBox4.Text);



                a.VoucherTransactionNew(1,this.textBox_VOUCHERS.Text,this.textBox_StNo.Text ,"1101",119,"HHS","2017-05-05",this.textBox_netAmts.Text ,this.textBox_Disc.Text  ,"1","122",sign,out MsgTxt,out MsgNo );



                this.textBox_rtn.Text = "返回：  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo;
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }  



        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();


                string discNo = "";

                string MsgNo = "";
                string MsgTxt = "";
                string netAmt = "";
                       string itemNo = "";
                //       string tenderNo = "";


                       string sign = GetMD5(this.textBox_VoucerNo.Text + "~" + this.textBox_StNo.Text + "~" + this.textBox4.Text);



                    //   a.VoucherCheck_BCPNew(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, sign, out itemNo, out discNo, out netAmt, out MsgTxt, out MsgNo);

                    //   a.VoucherCheck_BCPNew(1, this.textBox_VOUCHERS.Text, this.textBox_StNo.Text, "1101", 119, "HHS", "2017-05-05", this.textBox_netAmts.Text, this.textBox_Disc.Text, "1", out MsgTxt, out MsgNo);



                //   (this.textBox1.Text, this.textBox3.Text, out discNo, out   netAmt, out itemNo, out tenderNo, out  MsgTxt, out MsgNo);

                       this.textBox_rtn.Text = "返回： DisNo:" + discNo + "  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo + " netAmt:" + netAmt + " itemNo:" + itemNo.ToString();
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }     



        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();


                string discNo = "";

                string MsgNo = "";
                string MsgTxt = "";
              //  string netAmt = "";
          //      string itemNo = "";
                //       string tenderNo = "";

                // a.VoucherCheckNew(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, out discNo, out netAmt, out MsgTxt, out MsgNo);

                string sign = GetMD5("1~" + this.textBox_VOUCHERS.Text + "~" + this.textBox_StNo.Text + "~" + this.textBox1.Text + "~" + this.textBox2.Text + "~" + this.textBox3.Text + "~" + System.DateTime.Now.ToString("yyyy-MM-dd") + "~121~" + this.textBox4.Text);

               a.VoucherTransactionReturn(1,this.textBox_VOUCHERS.Text,this.textBox_StNo.Text ,this.textBox1.Text ,System.Convert.ToInt32 (this.textBox2.Text ),this.textBox3.Text  ,System.DateTime.Now.ToString ("yyyy-MM-dd"),"121" ,sign, out MsgTxt,out MsgNo );
        
                
                
                //   (this.textBox1.Text, this.textBox3.Text, out discNo, out   netAmt, out itemNo, out tenderNo, out  MsgTxt, out MsgNo);

               this.textBox_rtn.Text = "返回： DisNo:" + discNo + "  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo;
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }     


        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();


                string discNo = "";
                string MsgNo = "";
                string MsgTxt = "";
                string netAmt = "";
                //       string itemNo = "";
                //       string tenderNo = "";



                string sign = GetMD5(this.textBox_VoucerNo.Text + "~" + this.textBox_StNo.Text + "~" + this.textBox4.Text);

                this.textBox_rtn.Text = sign;

                //   (this.textBox1.Text, this.textBox3.Text, out discNo, out   netAmt, out itemNo, out tenderNo, out  MsgTxt, out MsgNo);

                //this.textBox_rtn.Text = a.VoucherCheckTest(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, sign);
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();


            string tp1 ;
            string msg;
            string  msgNo ;
            string    rtnbcd ;
            string rtnitem; 


            a.VoucherOO("12", "481161", "1", "921831480000000475", "2018-04-27", "700020", "测试", "13916202944", "", "", "7A7D60B623AE06C2823C8D7640642040", out tp1, out msg, out msgNo, out rtnbcd, out rtnitem);


            this.Text = tp1 + "," + msg + "," + msgNo + "," + rtnbcd + "," + rtnitem;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                WebReference.VoucherService a = new WS_TEST.WebReference.VoucherService();

                string voucherType = "";
                string voucherItemNo = "";
                string voucherNos = "";
                string voucherStatus = "";
                string storeNo = "";
                string activedTime = "";
                string certificatedTime = "";

                string MsgNo = "";
                string MsgTxt = "";


                string sign = GetMD5(this.textBox_VoucerNo.Text + "~" + this.textBox4.Text);


                //a.VoucherSalesCheck(this.textBox_VoucerNo.Text, this.textBox_StNo.Text, sign, out itemNo, out MsgTxt, out MsgNo);

                a.VoucherQueryNew(this.textBox_VoucerNo.Text, sign, out voucherType,out voucherItemNo,out voucherNos,out voucherStatus,out storeNo,
                    out activedTime,out certificatedTime, out MsgTxt, out MsgNo);


                this.textBox_rtn.Text = "返回： voucherType:" + voucherType + "voucherItemNo" + voucherItemNo + "voucherNos" + voucherNos + "voucherStatus" + voucherStatus +
                    "storeNo" + storeNo + "activedTime" + activedTime + "certificatedTime" + certificatedTime + "  RtnMsg:" + MsgTxt + "  RtnMsgNo:" + MsgNo + " MsgTxt:" + MsgTxt;
            }
            catch (Exception err)
            {

                this.textBox_rtn.Text = "执行出错：" + err.Message;
            }  
        }
    }
}