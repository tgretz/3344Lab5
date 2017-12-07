﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VINField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string makeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string modelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string yearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
        private decimal pricePerDayField;
        
        private bool availabilityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string pictureField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string VIN {
            get {
                return this.VINField;
            }
            set {
                if ((object.ReferenceEquals(this.VINField, value) != true)) {
                    this.VINField = value;
                    this.RaisePropertyChanged("VIN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string make {
            get {
                return this.makeField;
            }
            set {
                if ((object.ReferenceEquals(this.makeField, value) != true)) {
                    this.makeField = value;
                    this.RaisePropertyChanged("make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string model {
            get {
                return this.modelField;
            }
            set {
                if ((object.ReferenceEquals(this.modelField, value) != true)) {
                    this.modelField = value;
                    this.RaisePropertyChanged("model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string year {
            get {
                return this.yearField;
            }
            set {
                if ((object.ReferenceEquals(this.yearField, value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public decimal pricePerDay {
            get {
                return this.pricePerDayField;
            }
            set {
                if ((this.pricePerDayField.Equals(value) != true)) {
                    this.pricePerDayField = value;
                    this.RaisePropertyChanged("pricePerDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public bool availability {
            get {
                return this.availabilityField;
            }
            set {
                if ((this.availabilityField.Equals(value) != true)) {
                    this.availabilityField = value;
                    this.RaisePropertyChanged("availability");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string picture {
            get {
                return this.pictureField;
            }
            set {
                if ((object.ReferenceEquals(this.pictureField, value) != true)) {
                    this.pictureField = value;
                    this.RaisePropertyChanged("picture");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.CarServiceSoap")]
    public interface CarServiceSoap {
        
        // CODEGEN: Generating message contract since element name carObj from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StoreCar", ReplyAction="*")]
        Lab5.ServiceReference2.StoreCarResponse StoreCar(Lab5.ServiceReference2.StoreCarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StoreCar", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.StoreCarResponse> StoreCarAsync(Lab5.ServiceReference2.StoreCarRequest request);
        
        // CODEGEN: Generating message contract since element name VIN from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCarByVIN", ReplyAction="*")]
        Lab5.ServiceReference2.GetCarByVINResponse GetCarByVIN(Lab5.ServiceReference2.GetCarByVINRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCarByVIN", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.GetCarByVINResponse> GetCarByVINAsync(Lab5.ServiceReference2.GetCarByVINRequest request);
        
        // CODEGEN: Generating message contract since element name Type from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCarsByType", ReplyAction="*")]
        Lab5.ServiceReference2.GetCarsByTypeResponse GetCarsByType(Lab5.ServiceReference2.GetCarsByTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCarsByType", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.GetCarsByTypeResponse> GetCarsByTypeAsync(Lab5.ServiceReference2.GetCarsByTypeRequest request);
        
        // CODEGEN: Generating message contract since element name VIN from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeAvailability", ReplyAction="*")]
        Lab5.ServiceReference2.ChangeAvailabilityResponse ChangeAvailability(Lab5.ServiceReference2.ChangeAvailabilityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeAvailability", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.ChangeAvailabilityResponse> ChangeAvailabilityAsync(Lab5.ServiceReference2.ChangeAvailabilityRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StoreCarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StoreCar", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.StoreCarRequestBody Body;
        
        public StoreCarRequest() {
        }
        
        public StoreCarRequest(Lab5.ServiceReference2.StoreCarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StoreCarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Lab5.ServiceReference2.Car carObj;
        
        public StoreCarRequestBody() {
        }
        
        public StoreCarRequestBody(Lab5.ServiceReference2.Car carObj) {
            this.carObj = carObj;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StoreCarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StoreCarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.StoreCarResponseBody Body;
        
        public StoreCarResponse() {
        }
        
        public StoreCarResponse(Lab5.ServiceReference2.StoreCarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StoreCarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool StoreCarResult;
        
        public StoreCarResponseBody() {
        }
        
        public StoreCarResponseBody(bool StoreCarResult) {
            this.StoreCarResult = StoreCarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCarByVINRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCarByVIN", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.GetCarByVINRequestBody Body;
        
        public GetCarByVINRequest() {
        }
        
        public GetCarByVINRequest(Lab5.ServiceReference2.GetCarByVINRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCarByVINRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VIN;
        
        public GetCarByVINRequestBody() {
        }
        
        public GetCarByVINRequestBody(string VIN) {
            this.VIN = VIN;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCarByVINResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCarByVINResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.GetCarByVINResponseBody Body;
        
        public GetCarByVINResponse() {
        }
        
        public GetCarByVINResponse(Lab5.ServiceReference2.GetCarByVINResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCarByVINResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Lab5.ServiceReference2.Car GetCarByVINResult;
        
        public GetCarByVINResponseBody() {
        }
        
        public GetCarByVINResponseBody(Lab5.ServiceReference2.Car GetCarByVINResult) {
            this.GetCarByVINResult = GetCarByVINResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCarsByTypeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCarsByType", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.GetCarsByTypeRequestBody Body;
        
        public GetCarsByTypeRequest() {
        }
        
        public GetCarsByTypeRequest(Lab5.ServiceReference2.GetCarsByTypeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCarsByTypeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Type;
        
        public GetCarsByTypeRequestBody() {
        }
        
        public GetCarsByTypeRequestBody(string Type) {
            this.Type = Type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCarsByTypeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCarsByTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.GetCarsByTypeResponseBody Body;
        
        public GetCarsByTypeResponse() {
        }
        
        public GetCarsByTypeResponse(Lab5.ServiceReference2.GetCarsByTypeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCarsByTypeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Lab5.ServiceReference2.Car[] GetCarsByTypeResult;
        
        public GetCarsByTypeResponseBody() {
        }
        
        public GetCarsByTypeResponseBody(Lab5.ServiceReference2.Car[] GetCarsByTypeResult) {
            this.GetCarsByTypeResult = GetCarsByTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeAvailabilityRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeAvailability", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.ChangeAvailabilityRequestBody Body;
        
        public ChangeAvailabilityRequest() {
        }
        
        public ChangeAvailabilityRequest(Lab5.ServiceReference2.ChangeAvailabilityRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeAvailabilityRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VIN;
        
        public ChangeAvailabilityRequestBody() {
        }
        
        public ChangeAvailabilityRequestBody(string VIN) {
            this.VIN = VIN;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeAvailabilityResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeAvailabilityResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab5.ServiceReference2.ChangeAvailabilityResponseBody Body;
        
        public ChangeAvailabilityResponse() {
        }
        
        public ChangeAvailabilityResponse(Lab5.ServiceReference2.ChangeAvailabilityResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ChangeAvailabilityResponseBody {
        
        public ChangeAvailabilityResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CarServiceSoapChannel : Lab5.ServiceReference2.CarServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceSoapClient : System.ServiceModel.ClientBase<Lab5.ServiceReference2.CarServiceSoap>, Lab5.ServiceReference2.CarServiceSoap {
        
        public CarServiceSoapClient() {
        }
        
        public CarServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab5.ServiceReference2.StoreCarResponse Lab5.ServiceReference2.CarServiceSoap.StoreCar(Lab5.ServiceReference2.StoreCarRequest request) {
            return base.Channel.StoreCar(request);
        }
        
        public bool StoreCar(Lab5.ServiceReference2.Car carObj) {
            Lab5.ServiceReference2.StoreCarRequest inValue = new Lab5.ServiceReference2.StoreCarRequest();
            inValue.Body = new Lab5.ServiceReference2.StoreCarRequestBody();
            inValue.Body.carObj = carObj;
            Lab5.ServiceReference2.StoreCarResponse retVal = ((Lab5.ServiceReference2.CarServiceSoap)(this)).StoreCar(inValue);
            return retVal.Body.StoreCarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.StoreCarResponse> Lab5.ServiceReference2.CarServiceSoap.StoreCarAsync(Lab5.ServiceReference2.StoreCarRequest request) {
            return base.Channel.StoreCarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab5.ServiceReference2.StoreCarResponse> StoreCarAsync(Lab5.ServiceReference2.Car carObj) {
            Lab5.ServiceReference2.StoreCarRequest inValue = new Lab5.ServiceReference2.StoreCarRequest();
            inValue.Body = new Lab5.ServiceReference2.StoreCarRequestBody();
            inValue.Body.carObj = carObj;
            return ((Lab5.ServiceReference2.CarServiceSoap)(this)).StoreCarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab5.ServiceReference2.GetCarByVINResponse Lab5.ServiceReference2.CarServiceSoap.GetCarByVIN(Lab5.ServiceReference2.GetCarByVINRequest request) {
            return base.Channel.GetCarByVIN(request);
        }
        
        public Lab5.ServiceReference2.Car GetCarByVIN(string VIN) {
            Lab5.ServiceReference2.GetCarByVINRequest inValue = new Lab5.ServiceReference2.GetCarByVINRequest();
            inValue.Body = new Lab5.ServiceReference2.GetCarByVINRequestBody();
            inValue.Body.VIN = VIN;
            Lab5.ServiceReference2.GetCarByVINResponse retVal = ((Lab5.ServiceReference2.CarServiceSoap)(this)).GetCarByVIN(inValue);
            return retVal.Body.GetCarByVINResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.GetCarByVINResponse> Lab5.ServiceReference2.CarServiceSoap.GetCarByVINAsync(Lab5.ServiceReference2.GetCarByVINRequest request) {
            return base.Channel.GetCarByVINAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab5.ServiceReference2.GetCarByVINResponse> GetCarByVINAsync(string VIN) {
            Lab5.ServiceReference2.GetCarByVINRequest inValue = new Lab5.ServiceReference2.GetCarByVINRequest();
            inValue.Body = new Lab5.ServiceReference2.GetCarByVINRequestBody();
            inValue.Body.VIN = VIN;
            return ((Lab5.ServiceReference2.CarServiceSoap)(this)).GetCarByVINAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab5.ServiceReference2.GetCarsByTypeResponse Lab5.ServiceReference2.CarServiceSoap.GetCarsByType(Lab5.ServiceReference2.GetCarsByTypeRequest request) {
            return base.Channel.GetCarsByType(request);
        }
        
        public Lab5.ServiceReference2.Car[] GetCarsByType(string Type) {
            Lab5.ServiceReference2.GetCarsByTypeRequest inValue = new Lab5.ServiceReference2.GetCarsByTypeRequest();
            inValue.Body = new Lab5.ServiceReference2.GetCarsByTypeRequestBody();
            inValue.Body.Type = Type;
            Lab5.ServiceReference2.GetCarsByTypeResponse retVal = ((Lab5.ServiceReference2.CarServiceSoap)(this)).GetCarsByType(inValue);
            return retVal.Body.GetCarsByTypeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.GetCarsByTypeResponse> Lab5.ServiceReference2.CarServiceSoap.GetCarsByTypeAsync(Lab5.ServiceReference2.GetCarsByTypeRequest request) {
            return base.Channel.GetCarsByTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab5.ServiceReference2.GetCarsByTypeResponse> GetCarsByTypeAsync(string Type) {
            Lab5.ServiceReference2.GetCarsByTypeRequest inValue = new Lab5.ServiceReference2.GetCarsByTypeRequest();
            inValue.Body = new Lab5.ServiceReference2.GetCarsByTypeRequestBody();
            inValue.Body.Type = Type;
            return ((Lab5.ServiceReference2.CarServiceSoap)(this)).GetCarsByTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab5.ServiceReference2.ChangeAvailabilityResponse Lab5.ServiceReference2.CarServiceSoap.ChangeAvailability(Lab5.ServiceReference2.ChangeAvailabilityRequest request) {
            return base.Channel.ChangeAvailability(request);
        }
        
        public void ChangeAvailability(string VIN) {
            Lab5.ServiceReference2.ChangeAvailabilityRequest inValue = new Lab5.ServiceReference2.ChangeAvailabilityRequest();
            inValue.Body = new Lab5.ServiceReference2.ChangeAvailabilityRequestBody();
            inValue.Body.VIN = VIN;
            Lab5.ServiceReference2.ChangeAvailabilityResponse retVal = ((Lab5.ServiceReference2.CarServiceSoap)(this)).ChangeAvailability(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab5.ServiceReference2.ChangeAvailabilityResponse> Lab5.ServiceReference2.CarServiceSoap.ChangeAvailabilityAsync(Lab5.ServiceReference2.ChangeAvailabilityRequest request) {
            return base.Channel.ChangeAvailabilityAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab5.ServiceReference2.ChangeAvailabilityResponse> ChangeAvailabilityAsync(string VIN) {
            Lab5.ServiceReference2.ChangeAvailabilityRequest inValue = new Lab5.ServiceReference2.ChangeAvailabilityRequest();
            inValue.Body = new Lab5.ServiceReference2.ChangeAvailabilityRequestBody();
            inValue.Body.VIN = VIN;
            return ((Lab5.ServiceReference2.CarServiceSoap)(this)).ChangeAvailabilityAsync(inValue);
        }
    }
}
