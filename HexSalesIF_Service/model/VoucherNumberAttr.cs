using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    /// <summary>
    /// voucher参数排序属性
    /// 兼容老接口所需要的排序方式
    /// </summary>
    public class VoucherSortNoAttribute : Attribute
    {
        /// <summary>
        /// 排序编号
        /// </summary>
        public int n { get; set; }
    }
}