﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJsAppDemo.DAL.MyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/MyName", ReplyAction="http://tempuri.org/IUserService/MyNameResponse")]
        string MyName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/MyName", ReplyAction="http://tempuri.org/IUserService/MyNameResponse")]
        System.Threading.Tasks.Task<string> MyNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/View", ReplyAction="http://tempuri.org/IUserService/ViewResponse")]
        AngularJsAppDemo.DOL.User[] View();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/View", ReplyAction="http://tempuri.org/IUserService/ViewResponse")]
        System.Threading.Tasks.Task<AngularJsAppDemo.DOL.User[]> ViewAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : AngularJsAppDemo.DAL.MyServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<AngularJsAppDemo.DAL.MyServiceReference.IUserService>, AngularJsAppDemo.DAL.MyServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string MyName() {
            return base.Channel.MyName();
        }
        
        public System.Threading.Tasks.Task<string> MyNameAsync() {
            return base.Channel.MyNameAsync();
        }
        
        public AngularJsAppDemo.DOL.User[] View() {
            return base.Channel.View();
        }
        
        public System.Threading.Tasks.Task<AngularJsAppDemo.DOL.User[]> ViewAsync() {
            return base.Channel.ViewAsync();
        }
    }
}
