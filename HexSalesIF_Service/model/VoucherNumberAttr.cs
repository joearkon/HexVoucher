using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.model
{
    /// <summary>
    /// voucher参数排序属性
    /// 兼容老接口所需要的排序方式
    /// MD5加密方式下，传入web service 的输入参数在一定的排序规则下进行加密
    /// </summary>
    public class VoucherSortNoAttribute : Attribute
    {
        /// <summary>
        /// 排序编号
        /// </summary>
        public int n { get; set; }
    }
}