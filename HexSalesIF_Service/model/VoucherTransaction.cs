using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    /// <summary>
    /// 礼券销售退货请求类
    /// </summary>
    public class VoucherTransactionReturnReq : VoucherBaseReq
    {
        [VoucherSortNo(n =1)]
        public int IsRtn { get; set; }
        [VoucherSortNo(n = 2)]
        public string VoucherNo { get; set; }
        [VoucherSortNo(n = 3)]
        public string StoreNo { get; set; }
        [VoucherSortNo(n = 4)]
        public string TillNo { get; set; }
        [VoucherSortNo(n = 5)]
        public int SaleId { get; set; }
        [VoucherSortNo(n = 6)]
        public string StaffNo { get; set; }
        [VoucherSortNo(n = 7)]
        public string RtnDate { get; set; }
        [VoucherSortNo(n = 8)]
        public string TtransNo { get; set; }

        public VoucherTransactionReturnReq() : base() { }
        public VoucherTransactionReturnReq(int isRtn, string voucherNo, string storeNo, string tillNo, int saleId, string staffNo, string rtnDate,
            string ttransNo)
        {
            IsRtn = isRtn;
            VoucherNo = voucherNo;
            StoreNo = storeNo;
            TillNo = tillNo;
            SaleId = saleId;
            StaffNo = staffNo;
            RtnDate = rtnDate;
            TtransNo = ttransNo;
        }

        public VoucherTransactionReturnReq(int isRtn, string voucherNo, string storeNo, string tillNo,
            int saleId, string staffNo, string rtnDate, string ttransNo, string sign)
            : this(isRtn, voucherNo, storeNo, tillNo, saleId, staffNo, rtnDate, ttransNo)
        {
            Sign = sign;
        }
    }


    /// <summary>
    /// 礼券交易记录
    /// </summary>
    public class VoucherTransactionReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public int IsSale { get; set; }
        [VoucherSortNo(n = 2)]
        public string VoucherNo { get; set; }
        [VoucherSortNo(n = 3)]
        public string StoreNo { get; set; }
        [VoucherSortNo(n = 4)]
        public string TillNo { get; set; }
        [VoucherSortNo(n = 5)]
        public int SaleId { get; set; }
        [VoucherSortNo(n = 6)]
        public string UserCode { get; set; }
        [VoucherSortNo(n = 7)]
        public string SaleDate { get; set; }


        public VoucherTransactionReq() : base() { }

        public VoucherTransactionReq(int isSale, string voucherNo, string storeNo, string tillNo, int saleId, string userCode, string saleDate)
        {
            IsSale = isSale;
            VoucherNo = voucherNo;
            StoreNo = storeNo;
            TillNo = tillNo;
            SaleId = saleId;
            UserCode = userCode;
            SaleDate = saleDate;

        }

        public VoucherTransactionReq(int isSale, string voucherNo, string storeNo, string tillNo, int saleId, string userCode, string saleDate, string sign)
            : this(isSale, voucherNo, storeNo, tillNo, saleId, userCode, saleDate)
        {
            Sign = sign;
        }
    }

    /// <summary>
    /// 礼券交易记录(新带净值) 请求类
    /// </summary>
    public class VoucherTransactionNewReq : VoucherBaseReq
    {
        [VoucherSortNo(n = 1)]
        public int IsSale { get; set; }

        [VoucherSortNo(n = 2)]
        public string VoucherNo { get; set; }

        [VoucherSortNo(n = 3)]
        public string StoreNo { get; set; }

        [VoucherSortNo(n = 4)]
        public string TillNo { get; set; }

        [VoucherSortNo(n = 6)]
        public string UserCode { get; set; }

        [VoucherSortNo(n = 7)]
        public string SaleDate { get; set; }

        [VoucherSortNo(n = 8)]
        public string NetAmt { get; set; }

        [VoucherSortNo(n = 9)]
        public string Distcount { get; set; }

        [VoucherSortNo(n = 10)]
        public string Tender { get; set; }

        [VoucherSortNo(n = 11)]
        public string TtransNo { get; set; }

        [VoucherSortNo(n = 5)]
        public int SaleId { get; set; }

        public VoucherTransactionNewReq() : base() { }

        public VoucherTransactionNewReq(int isSale, string voucherNo, string storeNo, string tillNo, string userCode, string saleDate, string netAmt,
            string distcount, string tender, string ttransNo, int saleId)
        {
            IsSale = isSale;
            VoucherNo = voucherNo;
            StoreNo = storeNo;
            TillNo = tillNo;
            UserCode = userCode;
            SaleDate = saleDate;
            NetAmt = netAmt;
            Distcount = distcount;
            Tender = tender;
            TtransNo = ttransNo;
            SaleId = saleId;
        }

        public VoucherTransactionNewReq(int isSale, string voucherNo, string storeNo, string tillNo, string userCode, string saleDate, string netAmt, string distcount, string tender, string ttransNo, int saleId, string sign) : this(isSale, voucherNo, storeNo, tillNo, userCode, saleDate, netAmt, distcount, tender, ttransNo, saleId)
        {
            Sign = sign;
        }
    }
}