using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherOOReq:VoucherBaseReq
    {
        [VoucherSortNo(n =1)]
        public string trans_tp { get; set; }
        [VoucherSortNo(n = 2)]
        public string voucher_no { get; set; }
        [VoucherSortNo(n = 3)]
        public string voucher_qty { get; set; }
        [VoucherSortNo(n = 4)]
        public string voucher_bcd { get; set; }
        [VoucherSortNo(n = 5)]
        public string bizdt_ord { get; set; }
        [VoucherSortNo(n = 6)]
        public string net_no_ord { get; set; }
        [VoucherSortNo(n = 7)]
        public string cust_name { get; set; }
        [VoucherSortNo(n = 8)]
        public string cust_tel { get; set; }
        [VoucherSortNo(n = 9)]
        public string cust_rmk { get; set; }
        [VoucherSortNo(n = 10)]
        public string rmk { get; set; }

        public VoucherOOReq(string transTp, string voucherNo, string voucherQty, string voucherBcd, string bizdtOrd, string netNoOrd, string custName,
            string custTel, string custRmk,string rmk,string sign):base()
        {
            this.trans_tp = transTp;
            this.voucher_no = voucherNo;
            this.voucher_qty = voucherQty;
            this.voucher_bcd = voucherBcd;
            this.bizdt_ord = bizdtOrd;
            this.net_no_ord = netNoOrd;
            this.cust_name = custName;
            this.cust_tel = custTel;
            this.cust_rmk = custRmk;
            this.rmk = rmk;
            this.Sign = sign;
        }

        public VoucherOOReq():base()
        {

        }
    }

    public class VoucherOOResp : VoucherBaseResp
    {
        public string RtnTransTp { get; set; }
        public string RtnVoucherBcd { get; set; }
        public string RtnVoucherItem { get; set; }
        public VoucherOOResp() : base()
        {
            this.RtnTransTp = "";
            this.RtnVoucherBcd = "";
            this.RtnVoucherItem = "";
        }
    }

    public class VoucherOOCheckResp : VoucherBaseResp
    {
        public string DisNo { get; set; }

        public VoucherOOCheckResp() : base() { }

        public VoucherOOCheckResp(string disNo) : base()
        {
            DisNo = disNo;
        }


    }
}