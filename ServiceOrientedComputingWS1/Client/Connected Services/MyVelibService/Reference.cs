﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MyVelibService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyVelibService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        string[] GetCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        System.Threading.Tasks.Task<string[]> GetCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStationsNameForCity", ReplyAction="http://tempuri.org/IService/GetStationsNameForCityResponse")]
        string[] GetStationsNameForCity(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStationsNameForCity", ReplyAction="http://tempuri.org/IService/GetStationsNameForCityResponse")]
        System.Threading.Tasks.Task<string[]> GetStationsNameForCityAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAvailableBikesForStation", ReplyAction="http://tempuri.org/IService/GetAvailableBikesForStationResponse")]
        int GetAvailableBikesForStation(string stationName, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAvailableBikesForStation", ReplyAction="http://tempuri.org/IService/GetAvailableBikesForStationResponse")]
        System.Threading.Tasks.Task<int> GetAvailableBikesForStationAsync(string stationName, string cityName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.MyVelibService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.MyVelibService.IService>, Client.MyVelibService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetCities() {
            return base.Channel.GetCities();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCitiesAsync() {
            return base.Channel.GetCitiesAsync();
        }
        
        public string[] GetStationsNameForCity(string name) {
            return base.Channel.GetStationsNameForCity(name);
        }
        
        public System.Threading.Tasks.Task<string[]> GetStationsNameForCityAsync(string name) {
            return base.Channel.GetStationsNameForCityAsync(name);
        }
        
        public int GetAvailableBikesForStation(string stationName, string cityName) {
            return base.Channel.GetAvailableBikesForStation(stationName, cityName);
        }
        
        public System.Threading.Tasks.Task<int> GetAvailableBikesForStationAsync(string stationName, string cityName) {
            return base.Channel.GetAvailableBikesForStationAsync(stationName, cityName);
        }
    }
}