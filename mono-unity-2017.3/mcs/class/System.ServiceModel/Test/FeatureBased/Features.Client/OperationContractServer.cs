﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proxy.MonoTests.Features.Client
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MonoTests.Features.Contracts", ConfigurationName="Proxy.MonoTests.Features.Client.IOperationContract")]
    public interface IOperationContract
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MonoTests.Features.Contracts/IOperationContract/RenamedMethod", ReplyAction="http://MonoTests.Features.Contracts/IOperationContract/RenamedMethodResponse")]
        int RenamedMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MonoTests.Features.Contracts/IOperationContract/OrigMethod", ReplyAction="http://MonoTests.Features.Contracts/IOperationContract/OrigMethodResponse")]
        int OrigMethod();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://MonoTests.Features.Contracts/IOperationContract/Sleep")]
        void Sleep(int mili);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IOperationContractChannel : Proxy.MonoTests.Features.Client.IOperationContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class OperationContractClient : System.ServiceModel.ClientBase<Proxy.MonoTests.Features.Client.IOperationContract>, Proxy.MonoTests.Features.Client.IOperationContract
    {
        
        public OperationContractClient()
        {
        }
        
        public OperationContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public OperationContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public OperationContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public OperationContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int RenamedMethod()
        {
            return base.Channel.RenamedMethod();
        }
        
        public int OrigMethod()
        {
            return base.Channel.OrigMethod();
        }
        
        public void Sleep(int mili)
        {
            base.Channel.Sleep(mili);
        }
    }
}
