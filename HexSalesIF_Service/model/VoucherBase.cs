using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HexSalesIF_Service.model
{
    public class VoucherBaseReq: IWebServiceModelserialization
    {
        [VoucherSortNo(n = 99)]
        public string Sign { set; get; }

        /// <summary>
        /// 转换为字典数据
        /// </summary>
        /// <param name="lowerInitial"></param>
        /// <returns></returns>
        public IDictionary ToStringDictionary(bool lowerInitial)
        {
            OrderedDictionary dict = new OrderedDictionary();

            List<KeyValuePair<int, string>> l = new List<KeyValuePair<int, string>>();
            foreach (var prop in this.GetType().GetProperties())
            {
                var attrList = prop.GetCustomAttributes(true);
                var v = prop.GetValue(this, null);
                if (v != null && (v.GetType() == typeof(string) || v.GetType() == typeof(int) || v.GetType() == typeof(float)))
                {
                    var name = prop.Name;
                    if (lowerInitial)
                    {
                        name = Char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1);
                    }
                    if (attrList.Length > 0)
                    {
                        var sortAttr = attrList[0] as VoucherSortNoAttribute;
                        if (sortAttr != null)
                        {
                            l.Add(new KeyValuePair<int, string>(sortAttr.n, name + "=" + v));
                        };
                    }
                    else
                    {
                        l.Add(new KeyValuePair<int, string>(999, name + "=" + v));
                    }

                }


            };

            l.Sort(delegate (KeyValuePair<int, string> s1, KeyValuePair<int, string> s2)
            {
                return s1.Key.CompareTo(s2.Key); //顺序排序
            });

            foreach (var item in l)
            {
                dict.Add(item.Value.Split('=')[0], Convert.ToString(item.Value.Split(new char[] { '=' }, 2)[1])); //key:name value:value
            }


            //foreach (var prop in this.GetType().GetProperties())
            //{
            //    var v = prop.GetValue(this, null);
            //    if (v != null && (v.GetType() == typeof(string) || v.GetType() == typeof(int) || v.GetType() == typeof(float)))
            //    {
            //        var name = prop.Name;
            //        if (lowerInitial)
            //        {
            //            name = Char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1);
            //        }

            //        dict.Add(name, Convert.ToString(v));
            //    }
            //}
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
            this.ExecuteReuslt = false;
        }

        public VoucherBaseResp(string msg, string msgNo,string sign)
        {
            this.RtnMsg = msg;
            this.RtnMsgNo = msgNo;
            this.Sign = sign;
            this.ExecuteReuslt = false;
        }

        public void SetExecuteSuccess(bool success)
        {
            this.ExecuteReuslt = success;
        }

        public bool isExcuteSuccess()
        {
            return this.ExecuteReuslt;
        }

        public void SetMsgAndMsgNo(string msg, string msgNo)
        {
            RtnMsg = msg;
            RtnMsgNo = msgNo;
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
                if (prop.Name.ToLower() == "executereuslt") { continue; }
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