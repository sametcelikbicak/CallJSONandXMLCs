﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallJSONandXMLCs.JSONandXMLCs {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Member", Namespace="http://sametcelikbicak.com/")]
    [System.SerializableAttribute()]
    public partial class Member : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int SalaryField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sametcelikbicak.com/", ConfigurationName="JSONandXMLCs.JSONandXMLSoap")]
    public interface JSONandXMLSoap {
        
        // CODEGEN: Generating message contract since element name GetTeamFromXMLResult from namespace http://sametcelikbicak.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sametcelikbicak.com/GetTeamFromXML", ReplyAction="*")]
        CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponse GetTeamFromXML(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sametcelikbicak.com/GetTeamFromXML", ReplyAction="*")]
        System.Threading.Tasks.Task<CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponse> GetTeamFromXMLAsync(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest request);
        
        // CODEGEN: Generating message contract since element name GetTeamFromJSONResult from namespace http://sametcelikbicak.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sametcelikbicak.com/GetTeamFromJSON", ReplyAction="*")]
        CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponse GetTeamFromJSON(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sametcelikbicak.com/GetTeamFromJSON", ReplyAction="*")]
        System.Threading.Tasks.Task<CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponse> GetTeamFromJSONAsync(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTeamFromXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTeamFromXML", Namespace="http://sametcelikbicak.com/", Order=0)]
        public CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequestBody Body;
        
        public GetTeamFromXMLRequest() {
        }
        
        public GetTeamFromXMLRequest(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetTeamFromXMLRequestBody {
        
        public GetTeamFromXMLRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTeamFromXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTeamFromXMLResponse", Namespace="http://sametcelikbicak.com/", Order=0)]
        public CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponseBody Body;
        
        public GetTeamFromXMLResponse() {
        }
        
        public GetTeamFromXMLResponse(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sametcelikbicak.com/")]
    public partial class GetTeamFromXMLResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CallJSONandXMLCs.JSONandXMLCs.Member[] GetTeamFromXMLResult;
        
        public GetTeamFromXMLResponseBody() {
        }
        
        public GetTeamFromXMLResponseBody(CallJSONandXMLCs.JSONandXMLCs.Member[] GetTeamFromXMLResult) {
            this.GetTeamFromXMLResult = GetTeamFromXMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTeamFromJSONRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTeamFromJSON", Namespace="http://sametcelikbicak.com/", Order=0)]
        public CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequestBody Body;
        
        public GetTeamFromJSONRequest() {
        }
        
        public GetTeamFromJSONRequest(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetTeamFromJSONRequestBody {
        
        public GetTeamFromJSONRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTeamFromJSONResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTeamFromJSONResponse", Namespace="http://sametcelikbicak.com/", Order=0)]
        public CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponseBody Body;
        
        public GetTeamFromJSONResponse() {
        }
        
        public GetTeamFromJSONResponse(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sametcelikbicak.com/")]
    public partial class GetTeamFromJSONResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTeamFromJSONResult;
        
        public GetTeamFromJSONResponseBody() {
        }
        
        public GetTeamFromJSONResponseBody(string GetTeamFromJSONResult) {
            this.GetTeamFromJSONResult = GetTeamFromJSONResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface JSONandXMLSoapChannel : CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JSONandXMLSoapClient : System.ServiceModel.ClientBase<CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap>, CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap {
        
        public JSONandXMLSoapClient() {
        }
        
        public JSONandXMLSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JSONandXMLSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JSONandXMLSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JSONandXMLSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponse CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap.GetTeamFromXML(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest request) {
            return base.Channel.GetTeamFromXML(request);
        }
        
        public CallJSONandXMLCs.JSONandXMLCs.Member[] GetTeamFromXML() {
            CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest inValue = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest();
            inValue.Body = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequestBody();
            CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponse retVal = ((CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap)(this)).GetTeamFromXML(inValue);
            return retVal.Body.GetTeamFromXMLResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponse> CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap.GetTeamFromXMLAsync(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest request) {
            return base.Channel.GetTeamFromXMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLResponse> GetTeamFromXMLAsync() {
            CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest inValue = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequest();
            inValue.Body = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromXMLRequestBody();
            return ((CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap)(this)).GetTeamFromXMLAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponse CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap.GetTeamFromJSON(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest request) {
            return base.Channel.GetTeamFromJSON(request);
        }
        
        public string GetTeamFromJSON() {
            CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest inValue = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest();
            inValue.Body = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequestBody();
            CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponse retVal = ((CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap)(this)).GetTeamFromJSON(inValue);
            return retVal.Body.GetTeamFromJSONResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponse> CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap.GetTeamFromJSONAsync(CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest request) {
            return base.Channel.GetTeamFromJSONAsync(request);
        }
        
        public System.Threading.Tasks.Task<CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONResponse> GetTeamFromJSONAsync() {
            CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest inValue = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequest();
            inValue.Body = new CallJSONandXMLCs.JSONandXMLCs.GetTeamFromJSONRequestBody();
            return ((CallJSONandXMLCs.JSONandXMLCs.JSONandXMLSoap)(this)).GetTeamFromJSONAsync(inValue);
        }
    }
}
