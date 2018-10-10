using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherTransRefundReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public string TransNo { get; set; }

        [VoucherSortNo(n = 2)]
        public string VoucherNo { get; set; }

        [VoucherSortNo(n = 3)]
        public string StoreNo { get; set; }

        [VoucherSortNo(n = 4)]
        public string TillNo { get; set; }

        [VoucherSortNo(n = 5)]
        public int SaleId { get; set; }

        [VoucherSortNo(n = 6)]
        public string SaleDate { get; set; }

        [VoucherSortNo(n = 7)]
        public string Remarks1 { get; set; }

        [VoucherSortNo(n = 8)]
        public string Remarks2 { get; set; }

        public VoucherTransRefundReq() : base() { }

        public VoucherTransRefundReq(string voucherNo, string storeNo, string transNo, string tillNo, int saleId, 
            string saleDate, string remark1, string remark2, string sign)
        {
            this.VoucherNo = voucherNo;
            this.StoreNo = storeNo;
            this.TransNo = transNo;
            this.TillNo = tillNo;
            this.SaleId = saleId; 
            this.SaleDate = saleDate;
            this.Remarks1 = remark1;
            this.Remarks2 = remark2;
            this.Sign = sign;
        }
    }

    public class VoucherTransRefundResp : VoucherBaseResp
    {

    }
}