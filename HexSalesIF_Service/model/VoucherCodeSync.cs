using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherCodeSyncReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public string VoucherName { get; set; }
        [VoucherSortNo(n = 2)]
        public string VoucherNo { get; set; }
        [VoucherSortNo(n = 3)]
        public string VoucherQty { get; set; }
        [VoucherSortNo(n = 4)]
        public string BarcodeUnit { get; set; }
        [VoucherSortNo(n = 5)]
        public string StartDate { get; set; }
        [VoucherSortNo(n = 6)]
        public string ExpiredDate { get; set; }
        [VoucherSortNo(n = 7)]
        public string UpdateDate { get; set; }
        [VoucherSortNo(n = 8)]
        public string Remarks1 { get; set; }
        [VoucherSortNo(n = 9)]
        public string Remarks2 { get; set; }

        public VoucherCodeSyncReq(string voucherName, string voucherNo, string voucherQty, string barcodeUnit, string startDate, string expiredDate,
            string updateDate, string remarks1, string remarks2,string sign) : base()
        {
            this.VoucherName = voucherName;
            this.VoucherNo = voucherNo;
            this.BarcodeUnit = barcodeUnit;
            this.StartDate = startDate;
            this.ExpiredDate = expiredDate;
            this.UpdateDate = updateDate;
            this.Remarks1 = remarks1;
            this.Remarks2 = remarks2;
            this.VoucherQty = voucherQty;
            this.Sign = sign;
        }
    }

    public class VoucherCodeSyncResp : VoucherBaseResp
    {
        public string VoucherName { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherBCD { get; set; }

        public string VoucherDocNo { get; set; }

       
        public VoucherCodeSyncResp() : base()
        {
            this.VoucherDocNo = "";
        }
    }
}