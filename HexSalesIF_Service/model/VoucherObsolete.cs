using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherObsoleteReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public string VoucherNo { get; set; }
        [VoucherSortNo(n = 2)]
        public string UpdateDate { get; set; }
        [VoucherSortNo(n = 3)]
        public string Remarks1 { get; set; }
        [VoucherSortNo(n = 4)]
        public string Remarks2 { get; set; }

        public VoucherObsoleteReq(string voucherNo, string updateDate, string remarks1, string remarks2, string sign)
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