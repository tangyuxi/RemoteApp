﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteConfig.RDPSrv {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://RDPServie/Lucy", ConfigurationName="RDPSrv.IRDPService", CallbackContract=typeof(RemoteConfig.RDPSrv.IRDPServiceCallback))]
    public interface IRDPService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://RDPServie/Lucy/IRDPService/GetDesktopSharedString", ReplyAction="http://RDPServie/Lucy/IRDPService/GetDesktopSharedStringResponse")]
        bool GetDesktopSharedString(out string cstring, out string msg, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://RDPServie/Lucy/IRDPService/SetDesktopSharedRect", ReplyAction="http://RDPServie/Lucy/IRDPService/SetDesktopSharedRectResponse")]
        void SetDesktopSharedRect(System.Drawing.Rectangle rect);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://RDPServie/Lucy/IRDPService/GetDesktopSharedRect", ReplyAction="http://RDPServie/Lucy/IRDPService/GetDesktopSharedRectResponse")]
        System.Drawing.Size GetDesktopSharedRect();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRDPServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://RDPServie/Lucy/IRDPService/NotifyMsg", ReplyAction="http://RDPServie/Lucy/IRDPService/NotifyMsgResponse")]
        void NotifyMsg(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRDPServiceChannel : RemoteConfig.RDPSrv.IRDPService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RDPServiceClient : System.ServiceModel.DuplexClientBase<RemoteConfig.RDPSrv.IRDPService>, RemoteConfig.RDPSrv.IRDPService {
        
        public RDPServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public RDPServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public RDPServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RDPServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RDPServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool GetDesktopSharedString(out string cstring, out string msg, string username, string password) {
            return base.Channel.GetDesktopSharedString(out cstring, out msg, username, password);
        }
        
        public void SetDesktopSharedRect(System.Drawing.Rectangle rect) {
            base.Channel.SetDesktopSharedRect(rect);
        }
        
        public System.Drawing.Size GetDesktopSharedRect() {
            return base.Channel.GetDesktopSharedRect();
        }
    }
}
