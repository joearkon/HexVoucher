using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherStoreSyncReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public string Province { get; set; }
        [VoucherSortNo(n = 2)]
        public string City { get; set; }
        [VoucherSortNo(n = 3)]
        public string Company { get; set; }
        [VoucherSortNo(n = 4)]
        public string StoreNo { get; set; }
        [VoucherSortNo(n = 5)]
        public string StoreName { get; set; }
        [VoucherSortNo(n = 6)]
        public string StoreAddr { get; set; }
        [VoucherSortNo(n = 7)]
        public string StoreEmail { get; set; }
        [VoucherSortNo(n = 8)]
        public string StoreTel { get; set; }
        [VoucherSortNo(n = 9)]
        public string StorePosNum { get; set; }
        [VoucherSortNo(n = 10)]
        public string OperateType { get; set; }
        [VoucherSortNo(n = 11)]
        public string Remarks1 { get; set; }
        [VoucherSortNo(n = 12)]
        public string Remarks2 { get; set; }

        public VoucherStoreSyncReq(string province, string city,string compay, string storeNo, string storeName, string storeAddr, string storeEmail,
            string storeTel, string storePosNum, string operateType,string remarks1,string remarks2, string sign)
        {
            this.Province = province;
            this.City = city;
            this.Company = compay;
            this.StoreNo = storeNo;
            this.StoreName = storeName;
            this.StoreAddr = storeAddr;
            this.StoreEmail = storeEmail;
            this.StoreTel = storeTel;
            this.StorePosNum = storePosNum;
            this.OperateType = operateType;
            this.Remarks1 = remarks1;
            this.Remarks2 = remarks2;
            this.Sign = sign;
        }
    }

    public class VoucherStoreSyncResp : VoucherBaseResp
    {

    }
}