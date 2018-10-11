using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherQueryReq : VoucherBaseReq
    {
        [VoucherSortNo(n =1)]
        public string VoucherNo { get; set; }

        [VoucherSortNo(n = 2)]
        public string StoreNo { get; set; }

        public VoucherQueryReq(string voucherNo, string storeNo) : base()
        {
            this.VoucherNo = voucherNo;
            this.StoreNo = storeNo;
        }

        public VoucherQueryReq(string voucherNo, string storeNo, string sign) : this(voucherNo, storeNo)
        {
            this.Sign = sign;
        }
    }
    
    public class VoucherQueryResp : VoucherBaseResp
    {
        public VoucherQueryResp() : base() { }
    }


    public class VoucherQueryNewReq: VoucherBaseReq
    {
        [VoucherSortNo(n =1)]
        public string VoucherNo { get; set; }
     

        public VoucherQueryNewReq(string voucherNo) : base()
        {
            this.VoucherNo = voucherNo;
        }

        public VoucherQueryNewReq(string voucherNo,  string sign) : this(voucherNo)
        {
            Sign = sign;
        }
    }

    public class VoucherQueryNewResp : VoucherBaseResp
    {
        public string VoucherType { get; set; }
        public string VoucherItemNo { get; set; }
        public string VoucherNos { get; set; }
        public string VoucherStatus { get; set; }
        public string StoreNo { get; set; }
        public string ActivedTime { get; set; }
        public string CertificatedTime { get; set; }

        public VoucherQueryNewResp() : base() { }
    }

}