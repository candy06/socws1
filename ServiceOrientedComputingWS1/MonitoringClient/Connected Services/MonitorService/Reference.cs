﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringClient.MonitorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MonitorService.IMonitorService")]
    public interface IMonitorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetConnectedClients", ReplyAction="http://tempuri.org/IMonitorService/GetConnectedClientsResponse")]
        int GetConnectedClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetConnectedClients", ReplyAction="http://tempuri.org/IMonitorService/GetConnectedClientsResponse")]
        System.Threading.Tasks.Task<int> GetConnectedClientsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMonitorServiceChannel : MonitoringClient.MonitorService.IMonitorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MonitorServiceClient : System.ServiceModel.ClientBase<MonitoringClient.MonitorService.IMonitorService>, MonitoringClient.MonitorService.IMonitorService {
        
        public MonitorServiceClient() {
        }
        
        public MonitorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MonitorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetConnectedClients() {
            return base.Channel.GetConnectedClients();
        }
        
        public System.Threading.Tasks.Task<int> GetConnectedClientsAsync() {
            return base.Channel.GetConnectedClientsAsync();
        }
    }
}
