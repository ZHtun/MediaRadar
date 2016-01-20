﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zin_MediaRadar.AdDataService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ad", Namespace="http://schemas.datacontract.org/2004/07/AdDataService")]
    [System.SerializableAttribute()]
    public partial class Ad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AdIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Zin_MediaRadar.AdDataService.Brand BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal NumPagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionField;
        
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
        public int AdId {
            get {
                return this.AdIdField;
            }
            set {
                if ((this.AdIdField.Equals(value) != true)) {
                    this.AdIdField = value;
                    this.RaisePropertyChanged("AdId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Zin_MediaRadar.AdDataService.Brand Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal NumPages {
            get {
                return this.NumPagesField;
            }
            set {
                if ((this.NumPagesField.Equals(value) != true)) {
                    this.NumPagesField = value;
                    this.RaisePropertyChanged("NumPages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Brand", Namespace="http://schemas.datacontract.org/2004/07/AdDataService")]
    [System.SerializableAttribute()]
    public partial class Brand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BrandIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandNameField;
        
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
        public int BrandId {
            get {
                return this.BrandIdField;
            }
            set {
                if ((this.BrandIdField.Equals(value) != true)) {
                    this.BrandIdField = value;
                    this.RaisePropertyChanged("BrandId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BrandName {
            get {
                return this.BrandNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandNameField, value) != true)) {
                    this.BrandNameField = value;
                    this.RaisePropertyChanged("BrandName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdDataService.IAdDataService")]
    public interface IAdDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdDataService/GetAdDataByDateRange", ReplyAction="http://tempuri.org/IAdDataService/GetAdDataByDateRangeResponse")]
        Zin_MediaRadar.AdDataService.Ad[] GetAdDataByDateRange(System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdDataService/GetAdDataByDateRange", ReplyAction="http://tempuri.org/IAdDataService/GetAdDataByDateRangeResponse")]
        System.Threading.Tasks.Task<Zin_MediaRadar.AdDataService.Ad[]> GetAdDataByDateRangeAsync(System.DateTime startDate, System.DateTime endDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdDataServiceChannel : Zin_MediaRadar.AdDataService.IAdDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdDataServiceClient : System.ServiceModel.ClientBase<Zin_MediaRadar.AdDataService.IAdDataService>, Zin_MediaRadar.AdDataService.IAdDataService {
        
        public AdDataServiceClient() {
        }
        
        public AdDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zin_MediaRadar.AdDataService.Ad[] GetAdDataByDateRange(System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetAdDataByDateRange(startDate, endDate);
        }
        
        public System.Threading.Tasks.Task<Zin_MediaRadar.AdDataService.Ad[]> GetAdDataByDateRangeAsync(System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetAdDataByDateRangeAsync(startDate, endDate);
        }
    }
}