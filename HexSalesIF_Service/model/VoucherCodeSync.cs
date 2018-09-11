using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherCodeSyncReq : VoucherBaseReq
    {
        public string VoucherName { get; set; }
        public string VoucherNo { get; set; }

        public int VoucherQty { get; set; }
        public string BarcodeUnit { get; set; }
        public string StartDate { get; set; }
        public string ExpiredDate { get; set; }
        public string UpdateDate { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }

        public VoucherCodeSyncReq(string voucherName, string voucherNo, int voucherQty, string barcodeUnit, string startDate, string expiredDate,
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