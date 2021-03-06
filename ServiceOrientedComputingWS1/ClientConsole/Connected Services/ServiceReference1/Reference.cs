﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsole.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/SOAPLibraryVelib")]
    [System.SerializableAttribute()]
    public partial class City : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] CitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Commercial_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Country_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Cities {
            get {
                return this.CitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.CitiesField, value) != true)) {
                    this.CitiesField = value;
                    this.RaisePropertyChanged("Cities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Commercial_name {
            get {
                return this.Commercial_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Commercial_nameField, value) != true)) {
                    this.Commercial_nameField = value;
                    this.RaisePropertyChanged("Commercial_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country_code {
            get {
                return this.Country_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.Country_codeField, value) != true)) {
                    this.Country_codeField = value;
                    this.RaisePropertyChanged("Country_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/SOAPLibraryVelib")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Available_bikes {
            get {
                return this.Available_bikesField;
            }
            set {
                if ((this.Available_bikesField.Equals(value) != true)) {
                    this.Available_bikesField = value;
                    this.RaisePropertyChanged("Available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAvailableBikesForStation", ReplyAction="http://tempuri.org/IService/GetAvailableBikesForStationResponse")]
        int GetAvailableBikesForStation(string stationName, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAvailableBikesForStation", ReplyAction="http://tempuri.org/IService/GetAvailableBikesForStationResponse")]
        System.Threading.Tasks.Task<int> GetAvailableBikesForStationAsync(string stationName, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        ClientConsole.ServiceReference1.City[] GetCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        System.Threading.Tasks.Task<ClientConsole.ServiceReference1.City[]> GetCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStationsOf", ReplyAction="http://tempuri.org/IService/GetStationsOfResponse")]
        ClientConsole.ServiceReference1.Station[] GetStationsOf(string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStationsOf", ReplyAction="http://tempuri.org/IService/GetStationsOfResponse")]
        System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station[]> GetStationsOfAsync(string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllStations", ReplyAction="http://tempuri.org/IService/GetAllStationsResponse")]
        ClientConsole.ServiceReference1.Station[] GetAllStations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllStations", ReplyAction="http://tempuri.org/IService/GetAllStationsResponse")]
        System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station[]> GetAllStationsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClientConsole.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientConsole.ServiceReference1.IService>, ClientConsole.ServiceReference1.IService {
        
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
        
        public int GetAvailableBikesForStation(string stationName, string cityName) {
            return base.Channel.GetAvailableBikesForStation(stationName, cityName);
        }
        
        public System.Threading.Tasks.Task<int> GetAvailableBikesForStationAsync(string stationName, string cityName) {
            return base.Channel.GetAvailableBikesForStationAsync(stationName, cityName);
        }
        
        public ClientConsole.ServiceReference1.City[] GetCities() {
            return base.Channel.GetCities();
        }
        
        public System.Threading.Tasks.Task<ClientConsole.ServiceReference1.City[]> GetCitiesAsync() {
            return base.Channel.GetCitiesAsync();
        }
        
        public ClientConsole.ServiceReference1.Station[] GetStationsOf(string cityName) {
            return base.Channel.GetStationsOf(cityName);
        }
        
        public System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station[]> GetStationsOfAsync(string cityName) {
            return base.Channel.GetStationsOfAsync(cityName);
        }
        
        public ClientConsole.ServiceReference1.Station[] GetAllStations() {
            return base.Channel.GetAllStations();
        }
        
        public System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station[]> GetAllStationsAsync() {
            return base.Channel.GetAllStationsAsync();
        }
    }
}
