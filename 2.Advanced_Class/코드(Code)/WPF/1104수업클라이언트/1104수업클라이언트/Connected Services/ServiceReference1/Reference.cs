﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace _1104수업클라이언트.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IHelloWorld")]
    public interface IHelloWorld {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorld/SayHello", ReplyAction="http://tempuri.org/IHelloWorld/SayHelloResponse")]
        string SayHello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorld/SayHello", ReplyAction="http://tempuri.org/IHelloWorld/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldChannel : _1104수업클라이언트.ServiceReference1.IHelloWorld, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldClient : System.ServiceModel.ClientBase<_1104수업클라이언트.ServiceReference1.IHelloWorld>, _1104수업클라이언트.ServiceReference1.IHelloWorld {
        
        public HelloWorldClient() {
        }
        
        public HelloWorldClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello() {
            return base.Channel.SayHello();
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync() {
            return base.Channel.SayHelloAsync();
        }

        internal bool Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
