//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace VoucherService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VoucherService.VoucherServiceSoap")]
    public interface VoucherServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherOO", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherOOResponse> VoucherOOAsync(VoucherService.VoucherOORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCheckResponse> VoucherCheckAsync(VoucherService.VoucherCheckRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheckNew", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCheckNewResponse> VoucherCheckNewAsync(VoucherService.VoucherCheckNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheckReturn", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCheckReturnResponse> VoucherCheckReturnAsync(VoucherService.VoucherCheckReturnRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck_OO", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCheck_OOResponse> VoucherCheck_OOAsync(VoucherService.VoucherCheck_OORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Test", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.TestResponse> TestAsync(VoucherService.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Test2", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.Test2Response> Test2Async(VoucherService.Test2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransaction", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionResponse> VoucherTransactionAsync(VoucherService.VoucherTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionNew", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionNewResponse> VoucherTransactionNewAsync(VoucherService.VoucherTransactionNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionReturn", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionReturnResponse> VoucherTransactionReturnAsync(VoucherService.VoucherTransactionReturnRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherSalesCheck", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherSalesCheckResponse> VoucherSalesCheckAsync(VoucherService.VoucherSalesCheckRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck_BCP", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCheck_BCPResponse> VoucherCheck_BCPAsync(VoucherService.VoucherCheck_BCPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck_BCPNew", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCheck_BCPNewResponse> VoucherCheck_BCPNewAsync(VoucherService.VoucherCheck_BCPNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherQuery", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherQueryResponse> VoucherQueryAsync(VoucherService.VoucherQueryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherQueryNew", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherQueryNewResponse> VoucherQueryNewAsync(VoucherService.VoucherQueryNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionRetreatRefund", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionRetreatRefundResponse> VoucherTransactionRetreatRefundAsync(VoucherService.VoucherTransactionRetreatRefundRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionWriteOffRefund", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionWriteOffRefundResponse> VoucherTransactionWriteOffRefundAsync(VoucherService.VoucherTransactionWriteOffRefundRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherObsolete", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherObsoleteResponse> VoucherObsoleteAsync(VoucherService.VoucherObsoleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StoreInformationSynchronize", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.StoreInformationSynchronizeResponse> StoreInformationSynchronizeAsync(VoucherService.StoreInformationSynchronizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCodeSynchronize", ReplyAction="*")]
        System.Threading.Tasks.Task<VoucherService.VoucherCodeSynchronizeResponse> VoucherCodeSynchronizeAsync(VoucherService.VoucherCodeSynchronizeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherOORequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherOO", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherOORequestBody Body;
        
        public VoucherOORequest()
        {
        }
        
        public VoucherOORequest(VoucherService.VoucherOORequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherOORequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string trans_tp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string voucher_no;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string voucher_qty;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string voucher_bcd;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string bizdt_ord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string net_no_ord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string cust_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string cust_tel;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string cust_rmk;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string rmk;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string Sign;
        
        public VoucherOORequestBody()
        {
        }
        
        public VoucherOORequestBody(string trans_tp, string voucher_no, string voucher_qty, string voucher_bcd, string bizdt_ord, string net_no_ord, string cust_name, string cust_tel, string cust_rmk, string rmk, string Sign)
        {
            this.trans_tp = trans_tp;
            this.voucher_no = voucher_no;
            this.voucher_qty = voucher_qty;
            this.voucher_bcd = voucher_bcd;
            this.bizdt_ord = bizdt_ord;
            this.net_no_ord = net_no_ord;
            this.cust_name = cust_name;
            this.cust_tel = cust_tel;
            this.cust_rmk = cust_rmk;
            this.rmk = rmk;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherOOResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherOOResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherOOResponseBody Body;
        
        public VoucherOOResponse()
        {
        }
        
        public VoucherOOResponse(VoucherService.VoucherOOResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherOOResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherOOResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnTransTp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsgNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnVoucherBcd;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnVoucherItem;
        
        public VoucherOOResponseBody()
        {
        }
        
        public VoucherOOResponseBody(string VoucherOOResult, string Sign, string RtnTransTp, string RtnMsg, string RtnMsgNo, string RtnVoucherBcd, string RtnVoucherItem)
        {
            this.VoucherOOResult = VoucherOOResult;
            this.Sign = Sign;
            this.RtnTransTp = RtnTransTp;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
            this.RtnVoucherBcd = RtnVoucherBcd;
            this.RtnVoucherItem = RtnVoucherItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheckRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheckRequestBody Body;
        
        public VoucherCheckRequest()
        {
        }
        
        public VoucherCheckRequest(VoucherService.VoucherCheckRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheckRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherCheckRequestBody()
        {
        }
        
        public VoucherCheckRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheckResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheckResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheckResponseBody Body;
        
        public VoucherCheckResponse()
        {
        }
        
        public VoucherCheckResponse(VoucherService.VoucherCheckResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheckResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCheckResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsgNo;
        
        public VoucherCheckResponseBody()
        {
        }
        
        public VoucherCheckResponseBody(string VoucherCheckResult, string Sign, string DisNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheckResult = VoucherCheckResult;
            this.Sign = Sign;
            this.DisNo = DisNo;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheckNewRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheckNew", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheckNewRequestBody Body;
        
        public VoucherCheckNewRequest()
        {
        }
        
        public VoucherCheckNewRequest(VoucherService.VoucherCheckNewRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheckNewRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherCheckNewRequestBody()
        {
        }
        
        public VoucherCheckNewRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheckNewResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheckNewResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheckNewResponseBody Body;
        
        public VoucherCheckNewResponse()
        {
        }
        
        public VoucherCheckNewResponse(VoucherService.VoucherCheckNewResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheckNewResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCheckNewResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string VoucherItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnMsgNo;
        
        public VoucherCheckNewResponseBody()
        {
        }
        
        public VoucherCheckNewResponseBody(string VoucherCheckNewResult, string Sign, string VoucherItemNo, string DisNo, string NetAmt, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheckNewResult = VoucherCheckNewResult;
            this.Sign = Sign;
            this.VoucherItemNo = VoucherItemNo;
            this.DisNo = DisNo;
            this.NetAmt = NetAmt;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheckReturnRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheckReturn", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheckReturnRequestBody Body;
        
        public VoucherCheckReturnRequest()
        {
        }
        
        public VoucherCheckReturnRequest(VoucherService.VoucherCheckReturnRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheckReturnRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherCheckReturnRequestBody()
        {
        }
        
        public VoucherCheckReturnRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheckReturnResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheckReturnResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheckReturnResponseBody Body;
        
        public VoucherCheckReturnResponse()
        {
        }
        
        public VoucherCheckReturnResponse(VoucherService.VoucherCheckReturnResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheckReturnResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCheckReturnResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string TenderNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string RtnMsgNo;
        
        public VoucherCheckReturnResponseBody()
        {
        }
        
        public VoucherCheckReturnResponseBody(string VoucherCheckReturnResult, string Sign, string DisNo, string NetAmt, string ItemNo, string TenderNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheckReturnResult = VoucherCheckReturnResult;
            this.Sign = Sign;
            this.DisNo = DisNo;
            this.NetAmt = NetAmt;
            this.ItemNo = ItemNo;
            this.TenderNo = TenderNo;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheck_OORequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck_OO", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheck_OORequestBody Body;
        
        public VoucherCheck_OORequest()
        {
        }
        
        public VoucherCheck_OORequest(VoucherService.VoucherCheck_OORequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheck_OORequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherCheck_OORequestBody()
        {
        }
        
        public VoucherCheck_OORequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheck_OOResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck_OOResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheck_OOResponseBody Body;
        
        public VoucherCheck_OOResponse()
        {
        }
        
        public VoucherCheck_OOResponse(VoucherService.VoucherCheck_OOResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheck_OOResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCheck_OOResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsgNo;
        
        public VoucherCheck_OOResponseBody()
        {
        }
        
        public VoucherCheck_OOResponseBody(string VoucherCheck_OOResult, string Sign, string DisNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheck_OOResult = VoucherCheck_OOResult;
            this.Sign = Sign;
            this.DisNo = DisNo;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Test", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.TestRequestBody Body;
        
        public TestRequest()
        {
        }
        
        public TestRequest(VoucherService.TestRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TestRequestBody
    {
        
        public TestRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.TestResponseBody Body;
        
        public TestResponse()
        {
        }
        
        public TestResponse(VoucherService.TestResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TestResult;
        
        public TestResponseBody()
        {
        }
        
        public TestResponseBody(string TestResult)
        {
            this.TestResult = TestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Test2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Test2", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.Test2RequestBody Body;
        
        public Test2Request()
        {
        }
        
        public Test2Request(VoucherService.Test2RequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Test2RequestBody
    {
        
        public Test2RequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Test2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Test2Response", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.Test2ResponseBody Body;
        
        public Test2Response()
        {
        }
        
        public Test2Response(VoucherService.Test2ResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Test2ResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Test2Result;
        
        public Test2ResponseBody()
        {
        }
        
        public Test2ResponseBody(string Test2Result)
        {
            this.Test2Result = Test2Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransaction", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionRequestBody Body;
        
        public VoucherTransactionRequest()
        {
        }
        
        public VoucherTransactionRequest(VoucherService.VoucherTransactionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int IsSale;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TillNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int SaleId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string UserCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string SaleDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Sign;
        
        public VoucherTransactionRequestBody()
        {
        }
        
        public VoucherTransactionRequestBody(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string Sign)
        {
            this.IsSale = IsSale;
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.TillNo = TillNo;
            this.SaleId = SaleId;
            this.UserCode = UserCode;
            this.SaleDate = SaleDate;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionResponseBody Body;
        
        public VoucherTransactionResponse()
        {
        }
        
        public VoucherTransactionResponse(VoucherService.VoucherTransactionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherTransactionResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherTransactionResponseBody()
        {
        }
        
        public VoucherTransactionResponseBody(string VoucherTransactionResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionResult = VoucherTransactionResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionNewRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionNew", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionNewRequestBody Body;
        
        public VoucherTransactionNewRequest()
        {
        }
        
        public VoucherTransactionNewRequest(VoucherService.VoucherTransactionNewRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionNewRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int IsSale;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TillNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int SaleId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string UserCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string SaleDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Distcount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Tender;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string TtransNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Sign;
        
        public VoucherTransactionNewRequestBody()
        {
        }
        
        public VoucherTransactionNewRequestBody(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string NetAmt, string Distcount, string Tender, string TtransNo, string Sign)
        {
            this.IsSale = IsSale;
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.TillNo = TillNo;
            this.SaleId = SaleId;
            this.UserCode = UserCode;
            this.SaleDate = SaleDate;
            this.NetAmt = NetAmt;
            this.Distcount = Distcount;
            this.Tender = Tender;
            this.TtransNo = TtransNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionNewResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionNewResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionNewResponseBody Body;
        
        public VoucherTransactionNewResponse()
        {
        }
        
        public VoucherTransactionNewResponse(VoucherService.VoucherTransactionNewResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionNewResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherTransactionNewResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherTransactionNewResponseBody()
        {
        }
        
        public VoucherTransactionNewResponseBody(string VoucherTransactionNewResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionNewResult = VoucherTransactionNewResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionReturnRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionReturn", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionReturnRequestBody Body;
        
        public VoucherTransactionReturnRequest()
        {
        }
        
        public VoucherTransactionReturnRequest(VoucherService.VoucherTransactionReturnRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionReturnRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int IsRtn;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TillNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int SaleId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string StaffNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string TtransNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Sign;
        
        public VoucherTransactionReturnRequestBody()
        {
        }
        
        public VoucherTransactionReturnRequestBody(int IsRtn, string VoucherNo, string StoreNo, string TillNo, int SaleId, string StaffNo, string RtnDate, string TtransNo, string Sign)
        {
            this.IsRtn = IsRtn;
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.TillNo = TillNo;
            this.SaleId = SaleId;
            this.StaffNo = StaffNo;
            this.RtnDate = RtnDate;
            this.TtransNo = TtransNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionReturnResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionReturnResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionReturnResponseBody Body;
        
        public VoucherTransactionReturnResponse()
        {
        }
        
        public VoucherTransactionReturnResponse(VoucherService.VoucherTransactionReturnResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionReturnResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherTransactionReturnResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherTransactionReturnResponseBody()
        {
        }
        
        public VoucherTransactionReturnResponseBody(string VoucherTransactionReturnResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionReturnResult = VoucherTransactionReturnResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherSalesCheckRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherSalesCheck", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherSalesCheckRequestBody Body;
        
        public VoucherSalesCheckRequest()
        {
        }
        
        public VoucherSalesCheckRequest(VoucherService.VoucherSalesCheckRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherSalesCheckRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherSalesCheckRequestBody()
        {
        }
        
        public VoucherSalesCheckRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherSalesCheckResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherSalesCheckResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherSalesCheckResponseBody Body;
        
        public VoucherSalesCheckResponse()
        {
        }
        
        public VoucherSalesCheckResponse(VoucherService.VoucherSalesCheckResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherSalesCheckResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherSalesCheckResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsgNo;
        
        public VoucherSalesCheckResponseBody()
        {
        }
        
        public VoucherSalesCheckResponseBody(string VoucherSalesCheckResult, string Sign, string ItemNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherSalesCheckResult = VoucherSalesCheckResult;
            this.Sign = Sign;
            this.ItemNo = ItemNo;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheck_BCPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck_BCP", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheck_BCPRequestBody Body;
        
        public VoucherCheck_BCPRequest()
        {
        }
        
        public VoucherCheck_BCPRequest(VoucherService.VoucherCheck_BCPRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheck_BCPRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherCheck_BCPRequestBody()
        {
        }
        
        public VoucherCheck_BCPRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheck_BCPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck_BCPResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheck_BCPResponseBody Body;
        
        public VoucherCheck_BCPResponse()
        {
        }
        
        public VoucherCheck_BCPResponse(VoucherService.VoucherCheck_BCPResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheck_BCPResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCheck_BCPResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnMsgNo;
        
        public VoucherCheck_BCPResponseBody()
        {
        }
        
        public VoucherCheck_BCPResponseBody(string VoucherCheck_BCPResult, string Sign, string ItemNo, string DisNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheck_BCPResult = VoucherCheck_BCPResult;
            this.Sign = Sign;
            this.ItemNo = ItemNo;
            this.DisNo = DisNo;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheck_BCPNewRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck_BCPNew", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheck_BCPNewRequestBody Body;
        
        public VoucherCheck_BCPNewRequest()
        {
        }
        
        public VoucherCheck_BCPNewRequest(VoucherService.VoucherCheck_BCPNewRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheck_BCPNewRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherCheck_BCPNewRequestBody()
        {
        }
        
        public VoucherCheck_BCPNewRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCheck_BCPNewResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCheck_BCPNewResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCheck_BCPNewResponseBody Body;
        
        public VoucherCheck_BCPNewResponse()
        {
        }
        
        public VoucherCheck_BCPNewResponse(VoucherService.VoucherCheck_BCPNewResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCheck_BCPNewResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCheck_BCPNewResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string VoucherItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string RtnMsgNo;
        
        public VoucherCheck_BCPNewResponseBody()
        {
        }
        
        public VoucherCheck_BCPNewResponseBody(string VoucherCheck_BCPNewResult, string Sign, string VoucherItemNo, string ItemNo, string DisNo, string NetAmt, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheck_BCPNewResult = VoucherCheck_BCPNewResult;
            this.Sign = Sign;
            this.VoucherItemNo = VoucherItemNo;
            this.ItemNo = ItemNo;
            this.DisNo = DisNo;
            this.NetAmt = NetAmt;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherQueryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherQuery", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherQueryRequestBody Body;
        
        public VoucherQueryRequest()
        {
        }
        
        public VoucherQueryRequest(VoucherService.VoucherQueryRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherQueryRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        public VoucherQueryRequestBody()
        {
        }
        
        public VoucherQueryRequestBody(string VoucherNo, string StoreNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.StoreNo = StoreNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherQueryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherQueryResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherQueryResponseBody Body;
        
        public VoucherQueryResponse()
        {
        }
        
        public VoucherQueryResponse(VoucherService.VoucherQueryResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherQueryResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherQueryResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherQueryResponseBody()
        {
        }
        
        public VoucherQueryResponseBody(string VoucherQueryResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherQueryResult = VoucherQueryResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherQueryNewRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherQueryNew", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherQueryNewRequestBody Body;
        
        public VoucherQueryNewRequest()
        {
        }
        
        public VoucherQueryNewRequest(VoucherService.VoucherQueryNewRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherQueryNewRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        public VoucherQueryNewRequestBody()
        {
        }
        
        public VoucherQueryNewRequestBody(string VoucherNo, string Sign)
        {
            this.VoucherNo = VoucherNo;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherQueryNewResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherQueryNewResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherQueryNewResponseBody Body;
        
        public VoucherQueryNewResponse()
        {
        }
        
        public VoucherQueryNewResponse(VoucherService.VoucherQueryNewResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherQueryNewResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherQueryNewResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string VoucherType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string VoucherItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string VoucherNos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string VoucherStatus;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string ActivedTime;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string CertificatedTime;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string RtnMsgNo;
        
        public VoucherQueryNewResponseBody()
        {
        }
        
        public VoucherQueryNewResponseBody(string VoucherQueryNewResult, string Sign, string VoucherType, string VoucherItemNo, string VoucherNos, string VoucherStatus, string StoreNo, string ActivedTime, string CertificatedTime, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherQueryNewResult = VoucherQueryNewResult;
            this.Sign = Sign;
            this.VoucherType = VoucherType;
            this.VoucherItemNo = VoucherItemNo;
            this.VoucherNos = VoucherNos;
            this.VoucherStatus = VoucherStatus;
            this.StoreNo = StoreNo;
            this.ActivedTime = ActivedTime;
            this.CertificatedTime = CertificatedTime;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionRetreatRefundRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionRetreatRefund", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionRetreatRefundRequestBody Body;
        
        public VoucherTransactionRetreatRefundRequest()
        {
        }
        
        public VoucherTransactionRetreatRefundRequest(VoucherService.VoucherTransactionRetreatRefundRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionRetreatRefundRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TransNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string TillNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int SaleId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string SaleDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Remarks1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Remarks2;
        
        public VoucherTransactionRetreatRefundRequestBody()
        {
        }
        
        public VoucherTransactionRetreatRefundRequestBody(string TransNo, string VoucherNo, string Sign, string StoreNo, string TillNo, int SaleId, string SaleDate, string Remarks1, string Remarks2)
        {
            this.TransNo = TransNo;
            this.VoucherNo = VoucherNo;
            this.Sign = Sign;
            this.StoreNo = StoreNo;
            this.TillNo = TillNo;
            this.SaleId = SaleId;
            this.SaleDate = SaleDate;
            this.Remarks1 = Remarks1;
            this.Remarks2 = Remarks2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionRetreatRefundResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionRetreatRefundResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionRetreatRefundResponseBody Body;
        
        public VoucherTransactionRetreatRefundResponse()
        {
        }
        
        public VoucherTransactionRetreatRefundResponse(VoucherService.VoucherTransactionRetreatRefundResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionRetreatRefundResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherTransactionRetreatRefundResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherTransactionRetreatRefundResponseBody()
        {
        }
        
        public VoucherTransactionRetreatRefundResponseBody(string VoucherTransactionRetreatRefundResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionRetreatRefundResult = VoucherTransactionRetreatRefundResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionWriteOffRefundRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionWriteOffRefund", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionWriteOffRefundRequestBody Body;
        
        public VoucherTransactionWriteOffRefundRequest()
        {
        }
        
        public VoucherTransactionWriteOffRefundRequest(VoucherService.VoucherTransactionWriteOffRefundRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionWriteOffRefundRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TransNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string TillNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int SaleId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string SaleDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Remarks1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Remarks2;
        
        public VoucherTransactionWriteOffRefundRequestBody()
        {
        }
        
        public VoucherTransactionWriteOffRefundRequestBody(string TransNo, string VoucherNo, string Sign, string StoreNo, string TillNo, int SaleId, string SaleDate, string Remarks1, string Remarks2)
        {
            this.TransNo = TransNo;
            this.VoucherNo = VoucherNo;
            this.Sign = Sign;
            this.StoreNo = StoreNo;
            this.TillNo = TillNo;
            this.SaleId = SaleId;
            this.SaleDate = SaleDate;
            this.Remarks1 = Remarks1;
            this.Remarks2 = Remarks2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherTransactionWriteOffRefundResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherTransactionWriteOffRefundResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherTransactionWriteOffRefundResponseBody Body;
        
        public VoucherTransactionWriteOffRefundResponse()
        {
        }
        
        public VoucherTransactionWriteOffRefundResponse(VoucherService.VoucherTransactionWriteOffRefundResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherTransactionWriteOffRefundResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherTransactionWriteOffRefundResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherTransactionWriteOffRefundResponseBody()
        {
        }
        
        public VoucherTransactionWriteOffRefundResponseBody(string VoucherTransactionWriteOffRefundResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionWriteOffRefundResult = VoucherTransactionWriteOffRefundResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherObsoleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherObsolete", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherObsoleteRequestBody Body;
        
        public VoucherObsoleteRequest()
        {
        }
        
        public VoucherObsoleteRequest(VoucherService.VoucherObsoleteRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherObsoleteRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string UpdateDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Remarks1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Remarks2;
        
        public VoucherObsoleteRequestBody()
        {
        }
        
        public VoucherObsoleteRequestBody(string VoucherNo, string UpdateDate, string Sign, string Remarks1, string Remarks2)
        {
            this.VoucherNo = VoucherNo;
            this.UpdateDate = UpdateDate;
            this.Sign = Sign;
            this.Remarks1 = Remarks1;
            this.Remarks2 = Remarks2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherObsoleteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherObsoleteResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherObsoleteResponseBody Body;
        
        public VoucherObsoleteResponse()
        {
        }
        
        public VoucherObsoleteResponse(VoucherService.VoucherObsoleteResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherObsoleteResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherObsoleteResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherObsoleteResponseBody()
        {
        }
        
        public VoucherObsoleteResponseBody(string VoucherObsoleteResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherObsoleteResult = VoucherObsoleteResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StoreInformationSynchronizeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StoreInformationSynchronize", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.StoreInformationSynchronizeRequestBody Body;
        
        public StoreInformationSynchronizeRequest()
        {
        }
        
        public StoreInformationSynchronizeRequest(VoucherService.StoreInformationSynchronizeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StoreInformationSynchronizeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Province;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string City;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Company;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string StoreName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string StoreAddr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string StoreEmail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string StoreTel;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string StorePosNum;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string OperateType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Remarks1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string Remarks2;
        
        public StoreInformationSynchronizeRequestBody()
        {
        }
        
        public StoreInformationSynchronizeRequestBody(string Province, string City, string Sign, string Company, string StoreNo, string StoreName, string StoreAddr, string StoreEmail, string StoreTel, string StorePosNum, string OperateType, string Remarks1, string Remarks2)
        {
            this.Province = Province;
            this.City = City;
            this.Sign = Sign;
            this.Company = Company;
            this.StoreNo = StoreNo;
            this.StoreName = StoreName;
            this.StoreAddr = StoreAddr;
            this.StoreEmail = StoreEmail;
            this.StoreTel = StoreTel;
            this.StorePosNum = StorePosNum;
            this.OperateType = OperateType;
            this.Remarks1 = Remarks1;
            this.Remarks2 = Remarks2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StoreInformationSynchronizeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StoreInformationSynchronizeResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.StoreInformationSynchronizeResponseBody Body;
        
        public StoreInformationSynchronizeResponse()
        {
        }
        
        public StoreInformationSynchronizeResponse(VoucherService.StoreInformationSynchronizeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StoreInformationSynchronizeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StoreInformationSynchronizeResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public StoreInformationSynchronizeResponseBody()
        {
        }
        
        public StoreInformationSynchronizeResponseBody(string StoreInformationSynchronizeResult, string Sign, string RtnMsg, string RtnMsgNo)
        {
            this.StoreInformationSynchronizeResult = StoreInformationSynchronizeResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCodeSynchronizeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCodeSynchronize", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCodeSynchronizeRequestBody Body;
        
        public VoucherCodeSynchronizeRequest()
        {
        }
        
        public VoucherCodeSynchronizeRequest(VoucherService.VoucherCodeSynchronizeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCodeSynchronizeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string VoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string VoucherQty;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string BarcodeUnit;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string StartDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string ExpiredDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string UpdateDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Remarks1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Remarks2;
        
        public VoucherCodeSynchronizeRequestBody()
        {
        }
        
        public VoucherCodeSynchronizeRequestBody(string VoucherName, string VoucherNo, string VoucherQty, string Sign, string BarcodeUnit, string StartDate, string ExpiredDate, string UpdateDate, string Remarks1, string Remarks2)
        {
            this.VoucherName = VoucherName;
            this.VoucherNo = VoucherNo;
            this.VoucherQty = VoucherQty;
            this.Sign = Sign;
            this.BarcodeUnit = BarcodeUnit;
            this.StartDate = StartDate;
            this.ExpiredDate = ExpiredDate;
            this.UpdateDate = UpdateDate;
            this.Remarks1 = Remarks1;
            this.Remarks2 = Remarks2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherCodeSynchronizeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherCodeSynchronizeResponse", Namespace="http://tempuri.org/", Order=0)]
        public VoucherService.VoucherCodeSynchronizeResponseBody Body;
        
        public VoucherCodeSynchronizeResponse()
        {
        }
        
        public VoucherCodeSynchronizeResponse(VoucherService.VoucherCodeSynchronizeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VoucherCodeSynchronizeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VoucherCodeSynchronizeResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string SNo;
        
        public VoucherCodeSynchronizeResponseBody()
        {
        }
        
        public VoucherCodeSynchronizeResponseBody(string VoucherCodeSynchronizeResult, string Sign, string RtnMsg, string RtnMsgNo, string SNo)
        {
            this.VoucherCodeSynchronizeResult = VoucherCodeSynchronizeResult;
            this.Sign = Sign;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
            this.SNo = SNo;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface VoucherServiceSoapChannel : VoucherService.VoucherServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class VoucherServiceSoapClient : System.ServiceModel.ClientBase<VoucherService.VoucherServiceSoap>, VoucherService.VoucherServiceSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public VoucherServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(VoucherServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), VoucherServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoucherServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(VoucherServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoucherServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(VoucherServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoucherServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherOOResponse> VoucherService.VoucherServiceSoap.VoucherOOAsync(VoucherService.VoucherOORequest request)
        {
            return base.Channel.VoucherOOAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherOOResponse> VoucherOOAsync(string trans_tp, string voucher_no, string voucher_qty, string voucher_bcd, string bizdt_ord, string net_no_ord, string cust_name, string cust_tel, string cust_rmk, string rmk, string Sign)
        {
            VoucherService.VoucherOORequest inValue = new VoucherService.VoucherOORequest();
            inValue.Body = new VoucherService.VoucherOORequestBody();
            inValue.Body.trans_tp = trans_tp;
            inValue.Body.voucher_no = voucher_no;
            inValue.Body.voucher_qty = voucher_qty;
            inValue.Body.voucher_bcd = voucher_bcd;
            inValue.Body.bizdt_ord = bizdt_ord;
            inValue.Body.net_no_ord = net_no_ord;
            inValue.Body.cust_name = cust_name;
            inValue.Body.cust_tel = cust_tel;
            inValue.Body.cust_rmk = cust_rmk;
            inValue.Body.rmk = rmk;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherOOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCheckResponse> VoucherService.VoucherServiceSoap.VoucherCheckAsync(VoucherService.VoucherCheckRequest request)
        {
            return base.Channel.VoucherCheckAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCheckResponse> VoucherCheckAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherCheckRequest inValue = new VoucherService.VoucherCheckRequest();
            inValue.Body = new VoucherService.VoucherCheckRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCheckAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCheckNewResponse> VoucherService.VoucherServiceSoap.VoucherCheckNewAsync(VoucherService.VoucherCheckNewRequest request)
        {
            return base.Channel.VoucherCheckNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCheckNewResponse> VoucherCheckNewAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherCheckNewRequest inValue = new VoucherService.VoucherCheckNewRequest();
            inValue.Body = new VoucherService.VoucherCheckNewRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCheckNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCheckReturnResponse> VoucherService.VoucherServiceSoap.VoucherCheckReturnAsync(VoucherService.VoucherCheckReturnRequest request)
        {
            return base.Channel.VoucherCheckReturnAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCheckReturnResponse> VoucherCheckReturnAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherCheckReturnRequest inValue = new VoucherService.VoucherCheckReturnRequest();
            inValue.Body = new VoucherService.VoucherCheckReturnRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCheckReturnAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCheck_OOResponse> VoucherService.VoucherServiceSoap.VoucherCheck_OOAsync(VoucherService.VoucherCheck_OORequest request)
        {
            return base.Channel.VoucherCheck_OOAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCheck_OOResponse> VoucherCheck_OOAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherCheck_OORequest inValue = new VoucherService.VoucherCheck_OORequest();
            inValue.Body = new VoucherService.VoucherCheck_OORequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCheck_OOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.TestResponse> VoucherService.VoucherServiceSoap.TestAsync(VoucherService.TestRequest request)
        {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.TestResponse> TestAsync()
        {
            VoucherService.TestRequest inValue = new VoucherService.TestRequest();
            inValue.Body = new VoucherService.TestRequestBody();
            return ((VoucherService.VoucherServiceSoap)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.Test2Response> VoucherService.VoucherServiceSoap.Test2Async(VoucherService.Test2Request request)
        {
            return base.Channel.Test2Async(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.Test2Response> Test2Async()
        {
            VoucherService.Test2Request inValue = new VoucherService.Test2Request();
            inValue.Body = new VoucherService.Test2RequestBody();
            return ((VoucherService.VoucherServiceSoap)(this)).Test2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionResponse> VoucherService.VoucherServiceSoap.VoucherTransactionAsync(VoucherService.VoucherTransactionRequest request)
        {
            return base.Channel.VoucherTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherTransactionResponse> VoucherTransactionAsync(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string Sign)
        {
            VoucherService.VoucherTransactionRequest inValue = new VoucherService.VoucherTransactionRequest();
            inValue.Body = new VoucherService.VoucherTransactionRequestBody();
            inValue.Body.IsSale = IsSale;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.UserCode = UserCode;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherTransactionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionNewResponse> VoucherService.VoucherServiceSoap.VoucherTransactionNewAsync(VoucherService.VoucherTransactionNewRequest request)
        {
            return base.Channel.VoucherTransactionNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherTransactionNewResponse> VoucherTransactionNewAsync(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string NetAmt, string Distcount, string Tender, string TtransNo, string Sign)
        {
            VoucherService.VoucherTransactionNewRequest inValue = new VoucherService.VoucherTransactionNewRequest();
            inValue.Body = new VoucherService.VoucherTransactionNewRequestBody();
            inValue.Body.IsSale = IsSale;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.UserCode = UserCode;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.NetAmt = NetAmt;
            inValue.Body.Distcount = Distcount;
            inValue.Body.Tender = Tender;
            inValue.Body.TtransNo = TtransNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherTransactionNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionReturnResponse> VoucherService.VoucherServiceSoap.VoucherTransactionReturnAsync(VoucherService.VoucherTransactionReturnRequest request)
        {
            return base.Channel.VoucherTransactionReturnAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherTransactionReturnResponse> VoucherTransactionReturnAsync(int IsRtn, string VoucherNo, string StoreNo, string TillNo, int SaleId, string StaffNo, string RtnDate, string TtransNo, string Sign)
        {
            VoucherService.VoucherTransactionReturnRequest inValue = new VoucherService.VoucherTransactionReturnRequest();
            inValue.Body = new VoucherService.VoucherTransactionReturnRequestBody();
            inValue.Body.IsRtn = IsRtn;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.StaffNo = StaffNo;
            inValue.Body.RtnDate = RtnDate;
            inValue.Body.TtransNo = TtransNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherTransactionReturnAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherSalesCheckResponse> VoucherService.VoucherServiceSoap.VoucherSalesCheckAsync(VoucherService.VoucherSalesCheckRequest request)
        {
            return base.Channel.VoucherSalesCheckAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherSalesCheckResponse> VoucherSalesCheckAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherSalesCheckRequest inValue = new VoucherService.VoucherSalesCheckRequest();
            inValue.Body = new VoucherService.VoucherSalesCheckRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherSalesCheckAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCheck_BCPResponse> VoucherService.VoucherServiceSoap.VoucherCheck_BCPAsync(VoucherService.VoucherCheck_BCPRequest request)
        {
            return base.Channel.VoucherCheck_BCPAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCheck_BCPResponse> VoucherCheck_BCPAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherCheck_BCPRequest inValue = new VoucherService.VoucherCheck_BCPRequest();
            inValue.Body = new VoucherService.VoucherCheck_BCPRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCheck_BCPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCheck_BCPNewResponse> VoucherService.VoucherServiceSoap.VoucherCheck_BCPNewAsync(VoucherService.VoucherCheck_BCPNewRequest request)
        {
            return base.Channel.VoucherCheck_BCPNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCheck_BCPNewResponse> VoucherCheck_BCPNewAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherCheck_BCPNewRequest inValue = new VoucherService.VoucherCheck_BCPNewRequest();
            inValue.Body = new VoucherService.VoucherCheck_BCPNewRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCheck_BCPNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherQueryResponse> VoucherService.VoucherServiceSoap.VoucherQueryAsync(VoucherService.VoucherQueryRequest request)
        {
            return base.Channel.VoucherQueryAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherQueryResponse> VoucherQueryAsync(string VoucherNo, string StoreNo, string Sign)
        {
            VoucherService.VoucherQueryRequest inValue = new VoucherService.VoucherQueryRequest();
            inValue.Body = new VoucherService.VoucherQueryRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherQueryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherQueryNewResponse> VoucherService.VoucherServiceSoap.VoucherQueryNewAsync(VoucherService.VoucherQueryNewRequest request)
        {
            return base.Channel.VoucherQueryNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherQueryNewResponse> VoucherQueryNewAsync(string VoucherNo, string Sign)
        {
            VoucherService.VoucherQueryNewRequest inValue = new VoucherService.VoucherQueryNewRequest();
            inValue.Body = new VoucherService.VoucherQueryNewRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherQueryNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionRetreatRefundResponse> VoucherService.VoucherServiceSoap.VoucherTransactionRetreatRefundAsync(VoucherService.VoucherTransactionRetreatRefundRequest request)
        {
            return base.Channel.VoucherTransactionRetreatRefundAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherTransactionRetreatRefundResponse> VoucherTransactionRetreatRefundAsync(string TransNo, string VoucherNo, string Sign, string StoreNo, string TillNo, int SaleId, string SaleDate, string Remarks1, string Remarks2)
        {
            VoucherService.VoucherTransactionRetreatRefundRequest inValue = new VoucherService.VoucherTransactionRetreatRefundRequest();
            inValue.Body = new VoucherService.VoucherTransactionRetreatRefundRequestBody();
            inValue.Body.TransNo = TransNo;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherTransactionRetreatRefundAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherTransactionWriteOffRefundResponse> VoucherService.VoucherServiceSoap.VoucherTransactionWriteOffRefundAsync(VoucherService.VoucherTransactionWriteOffRefundRequest request)
        {
            return base.Channel.VoucherTransactionWriteOffRefundAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherTransactionWriteOffRefundResponse> VoucherTransactionWriteOffRefundAsync(string TransNo, string VoucherNo, string Sign, string StoreNo, string TillNo, int SaleId, string SaleDate, string Remarks1, string Remarks2)
        {
            VoucherService.VoucherTransactionWriteOffRefundRequest inValue = new VoucherService.VoucherTransactionWriteOffRefundRequest();
            inValue.Body = new VoucherService.VoucherTransactionWriteOffRefundRequestBody();
            inValue.Body.TransNo = TransNo;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherTransactionWriteOffRefundAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherObsoleteResponse> VoucherService.VoucherServiceSoap.VoucherObsoleteAsync(VoucherService.VoucherObsoleteRequest request)
        {
            return base.Channel.VoucherObsoleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherObsoleteResponse> VoucherObsoleteAsync(string VoucherNo, string UpdateDate, string Sign, string Remarks1, string Remarks2)
        {
            VoucherService.VoucherObsoleteRequest inValue = new VoucherService.VoucherObsoleteRequest();
            inValue.Body = new VoucherService.VoucherObsoleteRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.UpdateDate = UpdateDate;
            inValue.Body.Sign = Sign;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherObsoleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.StoreInformationSynchronizeResponse> VoucherService.VoucherServiceSoap.StoreInformationSynchronizeAsync(VoucherService.StoreInformationSynchronizeRequest request)
        {
            return base.Channel.StoreInformationSynchronizeAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.StoreInformationSynchronizeResponse> StoreInformationSynchronizeAsync(string Province, string City, string Sign, string Company, string StoreNo, string StoreName, string StoreAddr, string StoreEmail, string StoreTel, string StorePosNum, string OperateType, string Remarks1, string Remarks2)
        {
            VoucherService.StoreInformationSynchronizeRequest inValue = new VoucherService.StoreInformationSynchronizeRequest();
            inValue.Body = new VoucherService.StoreInformationSynchronizeRequestBody();
            inValue.Body.Province = Province;
            inValue.Body.City = City;
            inValue.Body.Sign = Sign;
            inValue.Body.Company = Company;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.StoreName = StoreName;
            inValue.Body.StoreAddr = StoreAddr;
            inValue.Body.StoreEmail = StoreEmail;
            inValue.Body.StoreTel = StoreTel;
            inValue.Body.StorePosNum = StorePosNum;
            inValue.Body.OperateType = OperateType;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((VoucherService.VoucherServiceSoap)(this)).StoreInformationSynchronizeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VoucherService.VoucherCodeSynchronizeResponse> VoucherService.VoucherServiceSoap.VoucherCodeSynchronizeAsync(VoucherService.VoucherCodeSynchronizeRequest request)
        {
            return base.Channel.VoucherCodeSynchronizeAsync(request);
        }
        
        public System.Threading.Tasks.Task<VoucherService.VoucherCodeSynchronizeResponse> VoucherCodeSynchronizeAsync(string VoucherName, string VoucherNo, string VoucherQty, string Sign, string BarcodeUnit, string StartDate, string ExpiredDate, string UpdateDate, string Remarks1, string Remarks2)
        {
            VoucherService.VoucherCodeSynchronizeRequest inValue = new VoucherService.VoucherCodeSynchronizeRequest();
            inValue.Body = new VoucherService.VoucherCodeSynchronizeRequestBody();
            inValue.Body.VoucherName = VoucherName;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.VoucherQty = VoucherQty;
            inValue.Body.Sign = Sign;
            inValue.Body.BarcodeUnit = BarcodeUnit;
            inValue.Body.StartDate = StartDate;
            inValue.Body.ExpiredDate = ExpiredDate;
            inValue.Body.UpdateDate = UpdateDate;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((VoucherService.VoucherServiceSoap)(this)).VoucherCodeSynchronizeAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.VoucherServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.VoucherServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.VoucherServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:13728/voucherService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.VoucherServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:13728/voucherService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            VoucherServiceSoap,
            
            VoucherServiceSoap12,
        }
    }
}
