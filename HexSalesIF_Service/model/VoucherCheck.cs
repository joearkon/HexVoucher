using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherCheckReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public string VoucherNo { get; set; }

        [VoucherSortNo(n = 2)]
        public string StoreNo { get; set; }

        public VoucherCheckReq(string storeNo, string voucherNo)
        {
            this.VoucherNo = voucherNo;
            this.StoreNo = storeNo;
        }

        public VoucherCheckReq(string storeNo, string voucherNo, string sign) : this(storeNo, voucherNo)
        {
            this.Sign = sign;
        }
    }
    public class VoucherCheckResp : VoucherBaseResp
    {
        public string DisNo { get; set; }
        public VoucherCheckResp()
        {
            this.DisNo = "";
        }
    }

    public class VoucherCheckNewResp : VoucherBaseResp
    {
        public string VoucherItemNo { get; set; }
        public string DisNo { get; set; }
        public string NetAmt { get; set; }

        public VoucherCheckNewResp() : base()
        {
            this.DisNo = "";
            this.VoucherItemNo = "";
            this.NetAmt = "";
        }
    }

    /// <summary>
    /// 电子或者预约券返回类
    /// </summary>
    public class VoucherCheckBcpResp : VoucherBaseResp
    {
        public string ItemNo { get; set; }

        public string DisNo { get; set; }

        public VoucherCheckBcpResp() : base()
        {

        }
    }

    /// <summary>
    /// 电子或者预约券返回类(新)
    /// </summary>
    public class VoucherCheckBcpNewResp : VoucherBaseResp
    {
        public string VoucherItemNo { get; set; }
        public string ItemNo { get; set; }

        public string DisNo { get; set; }

        public string NetAmt { get; set; }
    }

    public class VoucherSalesCheckResp : VoucherBaseResp
    {
        public string ItemNo { get; set; }

        public VoucherSalesCheckResp() : base()
        {

        }
    }

    public class VoucherCheckRetrunResp : VoucherBaseResp
    {
        public string DisNo { get; set; }
        public string NetAmt { get; set; }
        public string ItemNo { get; set; }
        public string TenderNo { get; set; }

        public VoucherCheckRetrunResp() : base() { }
        public VoucherCheckRetrunResp(string disNo, string netAmt, string itemNo, string tenderNo) : base()
        {
            DisNo = disNo;
            NetAmt = netAmt;
            ItemNo = itemNo;
            TenderNo = tenderNo;
        }

    }
}