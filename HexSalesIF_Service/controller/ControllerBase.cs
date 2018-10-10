using HexSalesIF_Service.model;
using HexSalesIF_Service.util;
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
        public IWebRequestGate gate { get; set; }

        public ControllerBase()
        {

        }

        public ControllerBase(IWebRequestGate gate)
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
            if (baseReq == null)
            {
                return VoucherBaseResp.CreateNotValidSignResp();
            }
            var validResp = VoucherBaseResp.CreateErrorResp();
            try
            {
                var requestReqDict = baseReq.ToStringDictionary(true);
                validResp = this.VerifyRequest(requestReqDict);  //验证签名
                if (validResp.isSignValidResp())
                {
                    // 验证通过, 执行方法
                    validResp = this.Execute(baseReq);
                    validResp.SetExecuteSuccess(true);
                }
            }
            catch (Exception e)
            {
                validResp.SetExecuteSuccess(false);
                var message = string.Format("Error occured when executing voucher method, message: {0}, source: {1}",
                    e.Message, e.Source);
                validResp.SetMsgAndMsgNo(WebServiceLib.SubStr(message, 1000), "99");
                LogHelper.Error(string.Format("Error occured when executing voucher method, message: {0},  source: {1},  stackTrace: {2}", e.Message, e.Source, e.StackTrace));
            }
            validResp.Sign = this.gate.CreateSign(validResp.ToStringDictionary(true)); //生成签名
            return validResp;
        }

        abstract protected VoucherBaseResp Execute(VoucherBaseReq baseReq);

    }
}