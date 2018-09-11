using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherObsoleteReq:VoucherBaseReq
    {
        public string VoucherNo { get; set; }
        public string UpdateDate { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
         
        public VoucherObsoleteReq(string voucherNo,string updateDate,string remarks1, string remarks2,string sign)
        {
            this.VoucherNo = voucherNo;
            this.UpdateDate = updateDate;
            this.Remarks1 = remarks1;
            this.Remarks2 = remarks2;
            this.Sign = sign;
        }
    }

    public class VoucherObsoleteResp : VoucherBaseResp
    {
        public VoucherObsoleteResp() : base() { }

    }
}