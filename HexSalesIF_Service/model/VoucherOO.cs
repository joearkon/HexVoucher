using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherOOReq:VoucherBaseReq
    {
        public string TransTp { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherQty { get; set; }

        public string VoucherBcd { get; set; }

        public string BizdtOrd { get; set; }

        public string NetNoOrd { get; set; }

        public string CustName { get; set; }

        public string CustTel { get; set; }

        public string CustRmk { get; set; }

        public string Rmk { get; set; }

        public VoucherOOReq(string transTp, string voucherNo, string voucherQty, string voucherBcd, string bizdtOrd, string netNoOrd, string custName,
            string custTel, string custRmk,string rmk):base()
        {
            this.TransTp = transTp;
            this.VoucherNo = voucherNo;
            this.VoucherQty = voucherQty;
            this.VoucherBcd = voucherBcd;
            this.BizdtOrd = bizdtOrd;
            this.NetNoOrd = netNoOrd;
            this.CustName = custName;
            this.CustTel = custTel;
            this.CustRmk = custRmk;
            this.Rmk = rmk;
        }

        public VoucherOOReq():base()
        {

        }

        // public IDictionary ToDict()
        //{
        //    var props = this.GetType().GetProperties();
        //    OrderedDictionary orderDict = new OrderedDictionary();
        //    foreach (var prop in props)
        //    {
        //        orderDict.Add(prop.Name)
        //    }
        //}
    }

    public class VoucherOOResp : VoucherBaseResp
    {
        public string RtnTransTp { get; set; }
        public string RtnVoucherBcd { get; set; }
        public string RtnVoucherItem { get; set; }
         public VoucherOOResp():base()
        {
            this.RtnTransTp = "";
            this.RtnVoucherBcd = "";
            this.RtnVoucherItem = "";
        }



    }
}