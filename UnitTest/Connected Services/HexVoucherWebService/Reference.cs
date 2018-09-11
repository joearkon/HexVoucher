//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace HexVoucherWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HexVoucherWebService.VoucherServiceSoap")]
    public interface VoucherServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherOO", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherOOResponse> VoucherOOAsync(HexVoucherWebService.VoucherOORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckResponse> VoucherCheckAsync(HexVoucherWebService.VoucherCheckRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheckNew", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckNewResponse> VoucherCheckNewAsync(HexVoucherWebService.VoucherCheckNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheckReturn", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckReturnResponse> VoucherCheckReturnAsync(HexVoucherWebService.VoucherCheckReturnRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck_OO", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_OOResponse> VoucherCheck_OOAsync(HexVoucherWebService.VoucherCheck_OORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Test", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.TestResponse> TestAsync(HexVoucherWebService.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Test2", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.Test2Response> Test2Async(HexVoucherWebService.Test2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransaction", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionResponse> VoucherTransactionAsync(HexVoucherWebService.VoucherTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionNew", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionNewResponse> VoucherTransactionNewAsync(HexVoucherWebService.VoucherTransactionNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionReturn", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionReturnResponse> VoucherTransactionReturnAsync(HexVoucherWebService.VoucherTransactionReturnRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherSalesCheck", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherSalesCheckResponse> VoucherSalesCheckAsync(HexVoucherWebService.VoucherSalesCheckRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck_BCP", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_BCPResponse> VoucherCheck_BCPAsync(HexVoucherWebService.VoucherCheck_BCPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCheck_BCPNew", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_BCPNewResponse> VoucherCheck_BCPNewAsync(HexVoucherWebService.VoucherCheck_BCPNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherQuery", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherQueryResponse> VoucherQueryAsync(HexVoucherWebService.VoucherQueryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherQueryNew", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherQueryNewResponse> VoucherQueryNewAsync(HexVoucherWebService.VoucherQueryNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionRetreatRefund", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionRetreatRefundResponse> VoucherTransactionRetreatRefundAsync(HexVoucherWebService.VoucherTransactionRetreatRefundRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherTransactionWriteOffRefund", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionWriteOffRefundResponse> VoucherTransactionWriteOffRefundAsync(HexVoucherWebService.VoucherTransactionWriteOffRefundRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherObsolete", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherObsoleteResponse> VoucherObsoleteAsync(HexVoucherWebService.VoucherObsoleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StoreInformationSynchronize", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.StoreInformationSynchronizeResponse> StoreInformationSynchronizeAsync(HexVoucherWebService.StoreInformationSynchronizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VoucherCodeSynchronize", ReplyAction="*")]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCodeSynchronizeResponse> VoucherCodeSynchronizeAsync(HexVoucherWebService.VoucherCodeSynchronizeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VoucherOORequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VoucherOO", Namespace="http://tempuri.org/", Order=0)]
        public HexVoucherWebService.VoucherOORequestBody Body;
        
        public VoucherOORequest()
        {
        }
        
        public VoucherOORequest(HexVoucherWebService.VoucherOORequestBody Body)
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
        public HexVoucherWebService.VoucherOOResponseBody Body;
        
        public VoucherOOResponse()
        {
        }
        
        public VoucherOOResponse(HexVoucherWebService.VoucherOOResponseBody Body)
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
        public string RtnTransTp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnVoucherBcd;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnVoucherItem;
        
        public VoucherOOResponseBody()
        {
        }
        
        public VoucherOOResponseBody(string VoucherOOResult, string RtnTransTp, string RtnMsg, string RtnMsgNo, string RtnVoucherBcd, string RtnVoucherItem)
        {
            this.VoucherOOResult = VoucherOOResult;
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
        public HexVoucherWebService.VoucherCheckRequestBody Body;
        
        public VoucherCheckRequest()
        {
        }
        
        public VoucherCheckRequest(HexVoucherWebService.VoucherCheckRequestBody Body)
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
        public HexVoucherWebService.VoucherCheckResponseBody Body;
        
        public VoucherCheckResponse()
        {
        }
        
        public VoucherCheckResponse(HexVoucherWebService.VoucherCheckResponseBody Body)
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
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherCheckResponseBody()
        {
        }
        
        public VoucherCheckResponseBody(string VoucherCheckResult, string DisNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheckResult = VoucherCheckResult;
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
        public HexVoucherWebService.VoucherCheckNewRequestBody Body;
        
        public VoucherCheckNewRequest()
        {
        }
        
        public VoucherCheckNewRequest(HexVoucherWebService.VoucherCheckNewRequestBody Body)
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
        public HexVoucherWebService.VoucherCheckNewResponseBody Body;
        
        public VoucherCheckNewResponse()
        {
        }
        
        public VoucherCheckNewResponse(HexVoucherWebService.VoucherCheckNewResponseBody Body)
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
        public string VoucherItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnMsgNo;
        
        public VoucherCheckNewResponseBody()
        {
        }
        
        public VoucherCheckNewResponseBody(string VoucherCheckNewResult, string VoucherItemNo, string DisNo, string NetAmt, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheckNewResult = VoucherCheckNewResult;
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
        public HexVoucherWebService.VoucherCheckReturnRequestBody Body;
        
        public VoucherCheckReturnRequest()
        {
        }
        
        public VoucherCheckReturnRequest(HexVoucherWebService.VoucherCheckReturnRequestBody Body)
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
        public HexVoucherWebService.VoucherCheckReturnResponseBody Body;
        
        public VoucherCheckReturnResponse()
        {
        }
        
        public VoucherCheckReturnResponse(HexVoucherWebService.VoucherCheckReturnResponseBody Body)
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
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string TenderNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnMsgNo;
        
        public VoucherCheckReturnResponseBody()
        {
        }
        
        public VoucherCheckReturnResponseBody(string VoucherCheckReturnResult, string DisNo, string NetAmt, string ItemNo, string TenderNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheckReturnResult = VoucherCheckReturnResult;
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
        public HexVoucherWebService.VoucherCheck_OORequestBody Body;
        
        public VoucherCheck_OORequest()
        {
        }
        
        public VoucherCheck_OORequest(HexVoucherWebService.VoucherCheck_OORequestBody Body)
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
        public HexVoucherWebService.VoucherCheck_OOResponseBody Body;
        
        public VoucherCheck_OOResponse()
        {
        }
        
        public VoucherCheck_OOResponse(HexVoucherWebService.VoucherCheck_OOResponseBody Body)
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
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherCheck_OOResponseBody()
        {
        }
        
        public VoucherCheck_OOResponseBody(string VoucherCheck_OOResult, string DisNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheck_OOResult = VoucherCheck_OOResult;
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
        public HexVoucherWebService.TestRequestBody Body;
        
        public TestRequest()
        {
        }
        
        public TestRequest(HexVoucherWebService.TestRequestBody Body)
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
        public HexVoucherWebService.TestResponseBody Body;
        
        public TestResponse()
        {
        }
        
        public TestResponse(HexVoucherWebService.TestResponseBody Body)
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
        public HexVoucherWebService.Test2RequestBody Body;
        
        public Test2Request()
        {
        }
        
        public Test2Request(HexVoucherWebService.Test2RequestBody Body)
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
        public HexVoucherWebService.Test2ResponseBody Body;
        
        public Test2Response()
        {
        }
        
        public Test2Response(HexVoucherWebService.Test2ResponseBody Body)
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
        public HexVoucherWebService.VoucherTransactionRequestBody Body;
        
        public VoucherTransactionRequest()
        {
        }
        
        public VoucherTransactionRequest(HexVoucherWebService.VoucherTransactionRequestBody Body)
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
        public HexVoucherWebService.VoucherTransactionResponseBody Body;
        
        public VoucherTransactionResponse()
        {
        }
        
        public VoucherTransactionResponse(HexVoucherWebService.VoucherTransactionResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public VoucherTransactionResponseBody()
        {
        }
        
        public VoucherTransactionResponseBody(string VoucherTransactionResult, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionResult = VoucherTransactionResult;
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
        public HexVoucherWebService.VoucherTransactionNewRequestBody Body;
        
        public VoucherTransactionNewRequest()
        {
        }
        
        public VoucherTransactionNewRequest(HexVoucherWebService.VoucherTransactionNewRequestBody Body)
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
        public HexVoucherWebService.VoucherTransactionNewResponseBody Body;
        
        public VoucherTransactionNewResponse()
        {
        }
        
        public VoucherTransactionNewResponse(HexVoucherWebService.VoucherTransactionNewResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public VoucherTransactionNewResponseBody()
        {
        }
        
        public VoucherTransactionNewResponseBody(string VoucherTransactionNewResult, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionNewResult = VoucherTransactionNewResult;
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
        public HexVoucherWebService.VoucherTransactionReturnRequestBody Body;
        
        public VoucherTransactionReturnRequest()
        {
        }
        
        public VoucherTransactionReturnRequest(HexVoucherWebService.VoucherTransactionReturnRequestBody Body)
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
        public HexVoucherWebService.VoucherTransactionReturnResponseBody Body;
        
        public VoucherTransactionReturnResponse()
        {
        }
        
        public VoucherTransactionReturnResponse(HexVoucherWebService.VoucherTransactionReturnResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public VoucherTransactionReturnResponseBody()
        {
        }
        
        public VoucherTransactionReturnResponseBody(string VoucherTransactionReturnResult, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionReturnResult = VoucherTransactionReturnResult;
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
        public HexVoucherWebService.VoucherSalesCheckRequestBody Body;
        
        public VoucherSalesCheckRequest()
        {
        }
        
        public VoucherSalesCheckRequest(HexVoucherWebService.VoucherSalesCheckRequestBody Body)
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
        public HexVoucherWebService.VoucherSalesCheckResponseBody Body;
        
        public VoucherSalesCheckResponse()
        {
        }
        
        public VoucherSalesCheckResponse(HexVoucherWebService.VoucherSalesCheckResponseBody Body)
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
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsgNo;
        
        public VoucherSalesCheckResponseBody()
        {
        }
        
        public VoucherSalesCheckResponseBody(string VoucherSalesCheckResult, string ItemNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherSalesCheckResult = VoucherSalesCheckResult;
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
        public HexVoucherWebService.VoucherCheck_BCPRequestBody Body;
        
        public VoucherCheck_BCPRequest()
        {
        }
        
        public VoucherCheck_BCPRequest(HexVoucherWebService.VoucherCheck_BCPRequestBody Body)
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
        public HexVoucherWebService.VoucherCheck_BCPResponseBody Body;
        
        public VoucherCheck_BCPResponse()
        {
        }
        
        public VoucherCheck_BCPResponse(HexVoucherWebService.VoucherCheck_BCPResponseBody Body)
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
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnMsgNo;
        
        public VoucherCheck_BCPResponseBody()
        {
        }
        
        public VoucherCheck_BCPResponseBody(string VoucherCheck_BCPResult, string ItemNo, string DisNo, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheck_BCPResult = VoucherCheck_BCPResult;
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
        public HexVoucherWebService.VoucherCheck_BCPNewRequestBody Body;
        
        public VoucherCheck_BCPNewRequest()
        {
        }
        
        public VoucherCheck_BCPNewRequest(HexVoucherWebService.VoucherCheck_BCPNewRequestBody Body)
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
        public HexVoucherWebService.VoucherCheck_BCPNewResponseBody Body;
        
        public VoucherCheck_BCPNewResponse()
        {
        }
        
        public VoucherCheck_BCPNewResponse(HexVoucherWebService.VoucherCheck_BCPNewResponseBody Body)
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
        public string VoucherItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string DisNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string NetAmt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RtnMsgNo;
        
        public VoucherCheck_BCPNewResponseBody()
        {
        }
        
        public VoucherCheck_BCPNewResponseBody(string VoucherCheck_BCPNewResult, string VoucherItemNo, string ItemNo, string DisNo, string NetAmt, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherCheck_BCPNewResult = VoucherCheck_BCPNewResult;
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
        public HexVoucherWebService.VoucherQueryRequestBody Body;
        
        public VoucherQueryRequest()
        {
        }
        
        public VoucherQueryRequest(HexVoucherWebService.VoucherQueryRequestBody Body)
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
        public HexVoucherWebService.VoucherQueryResponseBody Body;
        
        public VoucherQueryResponse()
        {
        }
        
        public VoucherQueryResponse(HexVoucherWebService.VoucherQueryResponseBody Body)
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
        public HexVoucherWebService.VoucherQueryNewRequestBody Body;
        
        public VoucherQueryNewRequest()
        {
        }
        
        public VoucherQueryNewRequest(HexVoucherWebService.VoucherQueryNewRequestBody Body)
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
        public HexVoucherWebService.VoucherQueryNewResponseBody Body;
        
        public VoucherQueryNewResponse()
        {
        }
        
        public VoucherQueryNewResponse(HexVoucherWebService.VoucherQueryNewResponseBody Body)
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
        public string VoucherType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string VoucherItemNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string VoucherNos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string VoucherStatus;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string StoreNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string ActivedTime;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string CertificatedTime;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string RtnMsgNo;
        
        public VoucherQueryNewResponseBody()
        {
        }
        
        public VoucherQueryNewResponseBody(string VoucherQueryNewResult, string VoucherType, string VoucherItemNo, string VoucherNos, string VoucherStatus, string StoreNo, string ActivedTime, string CertificatedTime, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherQueryNewResult = VoucherQueryNewResult;
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
        public HexVoucherWebService.VoucherTransactionRetreatRefundRequestBody Body;
        
        public VoucherTransactionRetreatRefundRequest()
        {
        }
        
        public VoucherTransactionRetreatRefundRequest(HexVoucherWebService.VoucherTransactionRetreatRefundRequestBody Body)
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
        public HexVoucherWebService.VoucherTransactionRetreatRefundResponseBody Body;
        
        public VoucherTransactionRetreatRefundResponse()
        {
        }
        
        public VoucherTransactionRetreatRefundResponse(HexVoucherWebService.VoucherTransactionRetreatRefundResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public VoucherTransactionRetreatRefundResponseBody()
        {
        }
        
        public VoucherTransactionRetreatRefundResponseBody(string VoucherTransactionRetreatRefundResult, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionRetreatRefundResult = VoucherTransactionRetreatRefundResult;
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
        public HexVoucherWebService.VoucherTransactionWriteOffRefundRequestBody Body;
        
        public VoucherTransactionWriteOffRefundRequest()
        {
        }
        
        public VoucherTransactionWriteOffRefundRequest(HexVoucherWebService.VoucherTransactionWriteOffRefundRequestBody Body)
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
        public HexVoucherWebService.VoucherTransactionWriteOffRefundResponseBody Body;
        
        public VoucherTransactionWriteOffRefundResponse()
        {
        }
        
        public VoucherTransactionWriteOffRefundResponse(HexVoucherWebService.VoucherTransactionWriteOffRefundResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public VoucherTransactionWriteOffRefundResponseBody()
        {
        }
        
        public VoucherTransactionWriteOffRefundResponseBody(string VoucherTransactionWriteOffRefundResult, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherTransactionWriteOffRefundResult = VoucherTransactionWriteOffRefundResult;
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
        public HexVoucherWebService.VoucherObsoleteRequestBody Body;
        
        public VoucherObsoleteRequest()
        {
        }
        
        public VoucherObsoleteRequest(HexVoucherWebService.VoucherObsoleteRequestBody Body)
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
        public HexVoucherWebService.VoucherObsoleteResponseBody Body;
        
        public VoucherObsoleteResponse()
        {
        }
        
        public VoucherObsoleteResponse(HexVoucherWebService.VoucherObsoleteResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public VoucherObsoleteResponseBody()
        {
        }
        
        public VoucherObsoleteResponseBody(string VoucherObsoleteResult, string RtnMsg, string RtnMsgNo)
        {
            this.VoucherObsoleteResult = VoucherObsoleteResult;
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
        public HexVoucherWebService.StoreInformationSynchronizeRequestBody Body;
        
        public StoreInformationSynchronizeRequest()
        {
        }
        
        public StoreInformationSynchronizeRequest(HexVoucherWebService.StoreInformationSynchronizeRequestBody Body)
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
        public HexVoucherWebService.StoreInformationSynchronizeResponseBody Body;
        
        public StoreInformationSynchronizeResponse()
        {
        }
        
        public StoreInformationSynchronizeResponse(HexVoucherWebService.StoreInformationSynchronizeResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        public StoreInformationSynchronizeResponseBody()
        {
        }
        
        public StoreInformationSynchronizeResponseBody(string StoreInformationSynchronizeResult, string RtnMsg, string RtnMsgNo)
        {
            this.StoreInformationSynchronizeResult = StoreInformationSynchronizeResult;
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
        public HexVoucherWebService.VoucherCodeSynchronizeRequestBody Body;
        
        public VoucherCodeSynchronizeRequest()
        {
        }
        
        public VoucherCodeSynchronizeRequest(HexVoucherWebService.VoucherCodeSynchronizeRequestBody Body)
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
        public string Sign;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string BarcodeUnit;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string StartDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ExpiredDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string UpdateDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Remarks1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Remarks2;
        
        public VoucherCodeSynchronizeRequestBody()
        {
        }
        
        public VoucherCodeSynchronizeRequestBody(string VoucherName, string VoucherNo, string Sign, string BarcodeUnit, string StartDate, string ExpiredDate, string UpdateDate, string Remarks1, string Remarks2)
        {
            this.VoucherName = VoucherName;
            this.VoucherNo = VoucherNo;
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
        public HexVoucherWebService.VoucherCodeSynchronizeResponseBody Body;
        
        public VoucherCodeSynchronizeResponse()
        {
        }
        
        public VoucherCodeSynchronizeResponse(HexVoucherWebService.VoucherCodeSynchronizeResponseBody Body)
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
        public string RtnMsg;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string RtnMsgNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RtnVoucherName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string RtnVoucherNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RtnVoucherBCD;
        
        public VoucherCodeSynchronizeResponseBody()
        {
        }
        
        public VoucherCodeSynchronizeResponseBody(string VoucherCodeSynchronizeResult, string RtnMsg, string RtnMsgNo, string RtnVoucherName, string RtnVoucherNo, string RtnVoucherBCD)
        {
            this.VoucherCodeSynchronizeResult = VoucherCodeSynchronizeResult;
            this.RtnMsg = RtnMsg;
            this.RtnMsgNo = RtnMsgNo;
            this.RtnVoucherName = RtnVoucherName;
            this.RtnVoucherNo = RtnVoucherNo;
            this.RtnVoucherBCD = RtnVoucherBCD;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface VoucherServiceSoapChannel : HexVoucherWebService.VoucherServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class VoucherServiceSoapClient : System.ServiceModel.ClientBase<HexVoucherWebService.VoucherServiceSoap>, HexVoucherWebService.VoucherServiceSoap
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
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherOOResponse> HexVoucherWebService.VoucherServiceSoap.VoucherOOAsync(HexVoucherWebService.VoucherOORequest request)
        {
            return base.Channel.VoucherOOAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherOOResponse> VoucherOOAsync(string trans_tp, string voucher_no, string voucher_qty, string voucher_bcd, string bizdt_ord, string net_no_ord, string cust_name, string cust_tel, string cust_rmk, string rmk, string Sign)
        {
            HexVoucherWebService.VoucherOORequest inValue = new HexVoucherWebService.VoucherOORequest();
            inValue.Body = new HexVoucherWebService.VoucherOORequestBody();
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
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherOOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCheckAsync(HexVoucherWebService.VoucherCheckRequest request)
        {
            return base.Channel.VoucherCheckAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckResponse> VoucherCheckAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherCheckRequest inValue = new HexVoucherWebService.VoucherCheckRequest();
            inValue.Body = new HexVoucherWebService.VoucherCheckRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCheckAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckNewResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCheckNewAsync(HexVoucherWebService.VoucherCheckNewRequest request)
        {
            return base.Channel.VoucherCheckNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckNewResponse> VoucherCheckNewAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherCheckNewRequest inValue = new HexVoucherWebService.VoucherCheckNewRequest();
            inValue.Body = new HexVoucherWebService.VoucherCheckNewRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCheckNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckReturnResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCheckReturnAsync(HexVoucherWebService.VoucherCheckReturnRequest request)
        {
            return base.Channel.VoucherCheckReturnAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheckReturnResponse> VoucherCheckReturnAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherCheckReturnRequest inValue = new HexVoucherWebService.VoucherCheckReturnRequest();
            inValue.Body = new HexVoucherWebService.VoucherCheckReturnRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCheckReturnAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_OOResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCheck_OOAsync(HexVoucherWebService.VoucherCheck_OORequest request)
        {
            return base.Channel.VoucherCheck_OOAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_OOResponse> VoucherCheck_OOAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherCheck_OORequest inValue = new HexVoucherWebService.VoucherCheck_OORequest();
            inValue.Body = new HexVoucherWebService.VoucherCheck_OORequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCheck_OOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.TestResponse> HexVoucherWebService.VoucherServiceSoap.TestAsync(HexVoucherWebService.TestRequest request)
        {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.TestResponse> TestAsync()
        {
            HexVoucherWebService.TestRequest inValue = new HexVoucherWebService.TestRequest();
            inValue.Body = new HexVoucherWebService.TestRequestBody();
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.Test2Response> HexVoucherWebService.VoucherServiceSoap.Test2Async(HexVoucherWebService.Test2Request request)
        {
            return base.Channel.Test2Async(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.Test2Response> Test2Async()
        {
            HexVoucherWebService.Test2Request inValue = new HexVoucherWebService.Test2Request();
            inValue.Body = new HexVoucherWebService.Test2RequestBody();
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).Test2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionResponse> HexVoucherWebService.VoucherServiceSoap.VoucherTransactionAsync(HexVoucherWebService.VoucherTransactionRequest request)
        {
            return base.Channel.VoucherTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionResponse> VoucherTransactionAsync(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string Sign)
        {
            HexVoucherWebService.VoucherTransactionRequest inValue = new HexVoucherWebService.VoucherTransactionRequest();
            inValue.Body = new HexVoucherWebService.VoucherTransactionRequestBody();
            inValue.Body.IsSale = IsSale;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.UserCode = UserCode;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherTransactionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionNewResponse> HexVoucherWebService.VoucherServiceSoap.VoucherTransactionNewAsync(HexVoucherWebService.VoucherTransactionNewRequest request)
        {
            return base.Channel.VoucherTransactionNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionNewResponse> VoucherTransactionNewAsync(int IsSale, string VoucherNo, string StoreNo, string TillNo, int SaleId, string UserCode, string SaleDate, string NetAmt, string Distcount, string Tender, string TtransNo, string Sign)
        {
            HexVoucherWebService.VoucherTransactionNewRequest inValue = new HexVoucherWebService.VoucherTransactionNewRequest();
            inValue.Body = new HexVoucherWebService.VoucherTransactionNewRequestBody();
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
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherTransactionNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionReturnResponse> HexVoucherWebService.VoucherServiceSoap.VoucherTransactionReturnAsync(HexVoucherWebService.VoucherTransactionReturnRequest request)
        {
            return base.Channel.VoucherTransactionReturnAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionReturnResponse> VoucherTransactionReturnAsync(int IsRtn, string VoucherNo, string StoreNo, string TillNo, int SaleId, string StaffNo, string RtnDate, string TtransNo, string Sign)
        {
            HexVoucherWebService.VoucherTransactionReturnRequest inValue = new HexVoucherWebService.VoucherTransactionReturnRequest();
            inValue.Body = new HexVoucherWebService.VoucherTransactionReturnRequestBody();
            inValue.Body.IsRtn = IsRtn;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.StaffNo = StaffNo;
            inValue.Body.RtnDate = RtnDate;
            inValue.Body.TtransNo = TtransNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherTransactionReturnAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherSalesCheckResponse> HexVoucherWebService.VoucherServiceSoap.VoucherSalesCheckAsync(HexVoucherWebService.VoucherSalesCheckRequest request)
        {
            return base.Channel.VoucherSalesCheckAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherSalesCheckResponse> VoucherSalesCheckAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherSalesCheckRequest inValue = new HexVoucherWebService.VoucherSalesCheckRequest();
            inValue.Body = new HexVoucherWebService.VoucherSalesCheckRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherSalesCheckAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_BCPResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCheck_BCPAsync(HexVoucherWebService.VoucherCheck_BCPRequest request)
        {
            return base.Channel.VoucherCheck_BCPAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_BCPResponse> VoucherCheck_BCPAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherCheck_BCPRequest inValue = new HexVoucherWebService.VoucherCheck_BCPRequest();
            inValue.Body = new HexVoucherWebService.VoucherCheck_BCPRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCheck_BCPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_BCPNewResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCheck_BCPNewAsync(HexVoucherWebService.VoucherCheck_BCPNewRequest request)
        {
            return base.Channel.VoucherCheck_BCPNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCheck_BCPNewResponse> VoucherCheck_BCPNewAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherCheck_BCPNewRequest inValue = new HexVoucherWebService.VoucherCheck_BCPNewRequest();
            inValue.Body = new HexVoucherWebService.VoucherCheck_BCPNewRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCheck_BCPNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherQueryResponse> HexVoucherWebService.VoucherServiceSoap.VoucherQueryAsync(HexVoucherWebService.VoucherQueryRequest request)
        {
            return base.Channel.VoucherQueryAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherQueryResponse> VoucherQueryAsync(string VoucherNo, string StoreNo, string Sign)
        {
            HexVoucherWebService.VoucherQueryRequest inValue = new HexVoucherWebService.VoucherQueryRequest();
            inValue.Body = new HexVoucherWebService.VoucherQueryRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherQueryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherQueryNewResponse> HexVoucherWebService.VoucherServiceSoap.VoucherQueryNewAsync(HexVoucherWebService.VoucherQueryNewRequest request)
        {
            return base.Channel.VoucherQueryNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherQueryNewResponse> VoucherQueryNewAsync(string VoucherNo, string Sign)
        {
            HexVoucherWebService.VoucherQueryNewRequest inValue = new HexVoucherWebService.VoucherQueryNewRequest();
            inValue.Body = new HexVoucherWebService.VoucherQueryNewRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherQueryNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionRetreatRefundResponse> HexVoucherWebService.VoucherServiceSoap.VoucherTransactionRetreatRefundAsync(HexVoucherWebService.VoucherTransactionRetreatRefundRequest request)
        {
            return base.Channel.VoucherTransactionRetreatRefundAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionRetreatRefundResponse> VoucherTransactionRetreatRefundAsync(string TransNo, string VoucherNo, string Sign, string StoreNo, string TillNo, int SaleId, string SaleDate, string Remarks1, string Remarks2)
        {
            HexVoucherWebService.VoucherTransactionRetreatRefundRequest inValue = new HexVoucherWebService.VoucherTransactionRetreatRefundRequest();
            inValue.Body = new HexVoucherWebService.VoucherTransactionRetreatRefundRequestBody();
            inValue.Body.TransNo = TransNo;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherTransactionRetreatRefundAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionWriteOffRefundResponse> HexVoucherWebService.VoucherServiceSoap.VoucherTransactionWriteOffRefundAsync(HexVoucherWebService.VoucherTransactionWriteOffRefundRequest request)
        {
            return base.Channel.VoucherTransactionWriteOffRefundAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherTransactionWriteOffRefundResponse> VoucherTransactionWriteOffRefundAsync(string TransNo, string VoucherNo, string Sign, string StoreNo, string TillNo, int SaleId, string SaleDate, string Remarks1, string Remarks2)
        {
            HexVoucherWebService.VoucherTransactionWriteOffRefundRequest inValue = new HexVoucherWebService.VoucherTransactionWriteOffRefundRequest();
            inValue.Body = new HexVoucherWebService.VoucherTransactionWriteOffRefundRequestBody();
            inValue.Body.TransNo = TransNo;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            inValue.Body.StoreNo = StoreNo;
            inValue.Body.TillNo = TillNo;
            inValue.Body.SaleId = SaleId;
            inValue.Body.SaleDate = SaleDate;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherTransactionWriteOffRefundAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherObsoleteResponse> HexVoucherWebService.VoucherServiceSoap.VoucherObsoleteAsync(HexVoucherWebService.VoucherObsoleteRequest request)
        {
            return base.Channel.VoucherObsoleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherObsoleteResponse> VoucherObsoleteAsync(string VoucherNo, string UpdateDate, string Sign, string Remarks1, string Remarks2)
        {
            HexVoucherWebService.VoucherObsoleteRequest inValue = new HexVoucherWebService.VoucherObsoleteRequest();
            inValue.Body = new HexVoucherWebService.VoucherObsoleteRequestBody();
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.UpdateDate = UpdateDate;
            inValue.Body.Sign = Sign;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherObsoleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.StoreInformationSynchronizeResponse> HexVoucherWebService.VoucherServiceSoap.StoreInformationSynchronizeAsync(HexVoucherWebService.StoreInformationSynchronizeRequest request)
        {
            return base.Channel.StoreInformationSynchronizeAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.StoreInformationSynchronizeResponse> StoreInformationSynchronizeAsync(string Province, string City, string Sign, string Company, string StoreNo, string StoreName, string StoreAddr, string StoreEmail, string StoreTel, string StorePosNum, string OperateType, string Remarks1, string Remarks2)
        {
            HexVoucherWebService.StoreInformationSynchronizeRequest inValue = new HexVoucherWebService.StoreInformationSynchronizeRequest();
            inValue.Body = new HexVoucherWebService.StoreInformationSynchronizeRequestBody();
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
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).StoreInformationSynchronizeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HexVoucherWebService.VoucherCodeSynchronizeResponse> HexVoucherWebService.VoucherServiceSoap.VoucherCodeSynchronizeAsync(HexVoucherWebService.VoucherCodeSynchronizeRequest request)
        {
            return base.Channel.VoucherCodeSynchronizeAsync(request);
        }
        
        public System.Threading.Tasks.Task<HexVoucherWebService.VoucherCodeSynchronizeResponse> VoucherCodeSynchronizeAsync(string VoucherName, string VoucherNo, string Sign, string BarcodeUnit, string StartDate, string ExpiredDate, string UpdateDate, string Remarks1, string Remarks2)
        {
            HexVoucherWebService.VoucherCodeSynchronizeRequest inValue = new HexVoucherWebService.VoucherCodeSynchronizeRequest();
            inValue.Body = new HexVoucherWebService.VoucherCodeSynchronizeRequestBody();
            inValue.Body.VoucherName = VoucherName;
            inValue.Body.VoucherNo = VoucherNo;
            inValue.Body.Sign = Sign;
            inValue.Body.BarcodeUnit = BarcodeUnit;
            inValue.Body.StartDate = StartDate;
            inValue.Body.ExpiredDate = ExpiredDate;
            inValue.Body.UpdateDate = UpdateDate;
            inValue.Body.Remarks1 = Remarks1;
            inValue.Body.Remarks2 = Remarks2;
            return ((HexVoucherWebService.VoucherServiceSoap)(this)).VoucherCodeSynchronizeAsync(inValue);
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
                return new System.ServiceModel.EndpointAddress("http://localhost:13728/VoucherService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.VoucherServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:13728/VoucherService.asmx");
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
