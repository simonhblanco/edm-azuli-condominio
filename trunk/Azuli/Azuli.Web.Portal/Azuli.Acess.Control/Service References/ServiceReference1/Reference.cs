﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace Azuli.Acess.Control.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceAzuliSoap")]
    public interface WebServiceAzuliSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/cadastraFoto", ReplyAction="*")]
        System.IAsyncResult BegincadastraFoto(Azuli.Acess.Control.ServiceReference1.cadastraFotoRequest request, System.AsyncCallback callback, object asyncState);
        
        Azuli.Acess.Control.ServiceReference1.cadastraFotoResponse EndcadastraFoto(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class cadastraFotoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="cadastraFoto", Namespace="http://tempuri.org/", Order=0)]
        public Azuli.Acess.Control.ServiceReference1.cadastraFotoRequestBody Body;
        
        public cadastraFotoRequest() {
        }
        
        public cadastraFotoRequest(Azuli.Acess.Control.ServiceReference1.cadastraFotoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class cadastraFotoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] foto;
        
        public cadastraFotoRequestBody() {
        }
        
        public cadastraFotoRequestBody(byte[] foto) {
            this.foto = foto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class cadastraFotoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="cadastraFotoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Azuli.Acess.Control.ServiceReference1.cadastraFotoResponseBody Body;
        
        public cadastraFotoResponse() {
        }
        
        public cadastraFotoResponse(Azuli.Acess.Control.ServiceReference1.cadastraFotoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class cadastraFotoResponseBody {
        
        public cadastraFotoResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceAzuliSoapChannel : Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAzuliSoapClient : System.ServiceModel.ClientBase<Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap>, Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap {
        
        private BeginOperationDelegate onBegincadastraFotoDelegate;
        
        private EndOperationDelegate onEndcadastraFotoDelegate;
        
        private System.Threading.SendOrPostCallback oncadastraFotoCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WebServiceAzuliSoapClient() {
        }
        
        public WebServiceAzuliSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAzuliSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAzuliSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAzuliSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> cadastraFotoCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap.BegincadastraFoto(Azuli.Acess.Control.ServiceReference1.cadastraFotoRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegincadastraFoto(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BegincadastraFoto(byte[] foto, System.AsyncCallback callback, object asyncState) {
            Azuli.Acess.Control.ServiceReference1.cadastraFotoRequest inValue = new Azuli.Acess.Control.ServiceReference1.cadastraFotoRequest();
            inValue.Body = new Azuli.Acess.Control.ServiceReference1.cadastraFotoRequestBody();
            inValue.Body.foto = foto;
            return ((Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap)(this)).BegincadastraFoto(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Azuli.Acess.Control.ServiceReference1.cadastraFotoResponse Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap.EndcadastraFoto(System.IAsyncResult result) {
            return base.Channel.EndcadastraFoto(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private void EndcadastraFoto(System.IAsyncResult result) {
            Azuli.Acess.Control.ServiceReference1.cadastraFotoResponse retVal = ((Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap)(this)).EndcadastraFoto(result);
        }
        
        private System.IAsyncResult OnBegincadastraFoto(object[] inValues, System.AsyncCallback callback, object asyncState) {
            byte[] foto = ((byte[])(inValues[0]));
            return this.BegincadastraFoto(foto, callback, asyncState);
        }
        
        private object[] OnEndcadastraFoto(System.IAsyncResult result) {
            this.EndcadastraFoto(result);
            return null;
        }
        
        private void OncadastraFotoCompleted(object state) {
            if ((this.cadastraFotoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.cadastraFotoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void cadastraFotoAsync(byte[] foto) {
            this.cadastraFotoAsync(foto, null);
        }
        
        public void cadastraFotoAsync(byte[] foto, object userState) {
            if ((this.onBegincadastraFotoDelegate == null)) {
                this.onBegincadastraFotoDelegate = new BeginOperationDelegate(this.OnBegincadastraFoto);
            }
            if ((this.onEndcadastraFotoDelegate == null)) {
                this.onEndcadastraFotoDelegate = new EndOperationDelegate(this.OnEndcadastraFoto);
            }
            if ((this.oncadastraFotoCompletedDelegate == null)) {
                this.oncadastraFotoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OncadastraFotoCompleted);
            }
            base.InvokeAsync(this.onBegincadastraFotoDelegate, new object[] {
                        foto}, this.onEndcadastraFotoDelegate, this.oncadastraFotoCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap CreateChannel() {
            return new WebServiceAzuliSoapClientChannel(this);
        }
        
        private class WebServiceAzuliSoapClientChannel : ChannelBase<Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap>, Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap {
            
            public WebServiceAzuliSoapClientChannel(System.ServiceModel.ClientBase<Azuli.Acess.Control.ServiceReference1.WebServiceAzuliSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BegincadastraFoto(Azuli.Acess.Control.ServiceReference1.cadastraFotoRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("cadastraFoto", _args, callback, asyncState);
                return _result;
            }
            
            public Azuli.Acess.Control.ServiceReference1.cadastraFotoResponse EndcadastraFoto(System.IAsyncResult result) {
                object[] _args = new object[0];
                Azuli.Acess.Control.ServiceReference1.cadastraFotoResponse _result = ((Azuli.Acess.Control.ServiceReference1.cadastraFotoResponse)(base.EndInvoke("cadastraFoto", _args, result)));
                return _result;
            }
        }
    }
}
