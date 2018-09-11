using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherBaseReq: IWebServiceModelserialization
    {
        public string Sign { set; get; }

        public IDictionary ToStringDictionary(bool lowerInitial)
        {
            OrderedDictionary dict = new OrderedDictionary();
            foreach (var prop in this.GetType().GetProperties())
            {
                var v = prop.GetValue(this, null);
                if (v != null && (v.GetType() == typeof(string) || v.GetType() == typeof(int) || v.GetType() == typeof(float)))
                {
                    var name = prop.Name;
                    if (lowerInitial)
                    {
                        name = Char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1);
                    }

                    dict.Add(name, Convert.ToString(v));
                }
            }
            return dict;
        }
    }

    public class VoucherBaseResp: IWebServiceModelserialization
    {
        public string RtnMsg { get; set; }
        public string RtnMsgNo { set; get; }

        public string Sign { set; get; }

        public bool ExecuteReuslt { get; set; }

        public VoucherBaseResp()
        {
            this.RtnMsg = "";
            this.RtnMsgNo = "";
            this.Sign = "";
        }

        public VoucherBaseResp(string msg, string msgNo,string sign)
        {
            this.RtnMsg = msg;
            this.RtnMsgNo = msgNo;
            this.Sign = sign;
        }

        public void SetExecuteSuccess()
        {
            this.ExecuteReuslt = true;
        }

        public bool isExcuteSuccess()
        {
            return this.ExecuteReuslt;
        }

        public bool isSignValidResp()
        {
            return this.RtnMsg == "验签成功" && this.RtnMsgNo == "00";
        }

        public static VoucherBaseResp CreateNotValidSignResp()
        {
            return new VoucherBaseResp("验签失败", "90", "");
        }

        public static VoucherBaseResp CreateValidSignResp()
        {
            return new VoucherBaseResp("验签成功", "00", "");
        }

        public static VoucherBaseResp CreateSuccessResp()
        {
            return new VoucherBaseResp("操作成功", "00", "");
        }

        public static VoucherBaseResp CreateErrorResp()
        {
            return new VoucherBaseResp("系统错误, 操作失败", "99", "");
        }

        public IDictionary ToStringDictionary(bool lowerInitial)
        {
            OrderedDictionary dict = new OrderedDictionary();
            foreach (var prop in this.GetType().GetProperties())
            {
                var v = prop.GetValue(this, null);
                if (v != null && (v.GetType() == typeof(string) || v.GetType() == typeof(int) || v.GetType() == typeof(float)))
                {
                    var name = prop.Name;
                    if (lowerInitial)
                    {
                        name = Char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1);
                    }

                    dict.Add(name, Convert.ToString(v));
                }
            }
            return dict;
        }
    }

    /// <summary>
    /// webservice模型序列化接口
    /// </summary>
    public interface IWebServiceModelserialization
    {
         /// <summary>
         /// 做dict转换
         /// </summary>
         /// <param name="lowerInitial"></param>
         /// <returns></returns>
         IDictionary ToStringDictionary(bool lowerInitial);
    }



}