using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherCheckReq: VoucherBaseReq
    {
        public string VoucherNo { get; set; }
        public string StoreNo { get; set; }

        public VoucherCheckReq(string storeNo, string voucherNo)
        {
            this.VoucherNo = voucherNo;
            this.StoreNo = storeNo;
        }
    }
    public class VoucherCheckResp: VoucherBaseResp
    {
        public string DisNo { get; set; }
        public VoucherCheckResp()
        {
            this.DisNo = "";
        }
    }
}