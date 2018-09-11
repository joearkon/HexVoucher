using HexSalesIF_Service.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.controller
{
    /// <summary>
    /// 控制器
    /// </summary>
    abstract public class ControllerBase
    {
        public IWebRequestGateway gate { get; set; }

        public ControllerBase()
        {
        
        }

        public ControllerBase(IWebRequestGateway gate)
        {
            this.gate = gate;
        }

        /// <summary>
        /// 请求数据验证
        /// 使用gate验证
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public VoucherBaseResp VerifyRequest(IDictionary data)
        {
            var valid = false;
            var sign = "";
            if (data != null)
            {
                // 寻找sign
                foreach (DictionaryEntry item in data)
                {
                    if (item.Key.ToString().ToLower().Equals("sign"))
                    {
                        if (item.Value != null && item.Value.GetType() == typeof(string))
                        {
                            sign = Convert.ToString(item.Value);
                            break;
                        }
                    }
                }
            }
            
            if (this.gate != null)
            {
                valid = this.gate.VerifyRequestDataSign(data, sign);
            }
            
            if (valid)
            {
                return VoucherBaseResp.CreateValidSignResp();
            }
            return VoucherBaseResp.CreateNotValidSignResp();

        }

        public VoucherBaseResp ExecuteAll(VoucherBaseReq baseReq)
        {
            var requestReqDict = baseReq.ToStringDictionary(true);
            var validResp = this.VerifyRequest(requestReqDict);
            if (validResp.isSignValidResp()) 
            {
                // 验证通过
                validResp = this.Execute(baseReq);
                validResp.SetExecuteSuccess();
            }
            validResp.Sign = this.gate.CreateSign(validResp.ToStringDictionary(true));
            return validResp;
        }

        abstract public VoucherBaseResp Execute(VoucherBaseReq baseReq);

    }
}