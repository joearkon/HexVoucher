using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherStoreSyncReq : VoucherBaseReq
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string StoreNo { get; set; }
        public string StoreName { get; set; }
        public string StoreAddr { get; set; }
        public string StoreEmail { get; set; }
        public string StoreTel { get; set; }
        public string StorePosNum { get; set; }

        public string OperateType { get; set; }

        public string Remarks1 { get; set; }

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