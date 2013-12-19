﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace PhoneApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IScaviService")]
    public interface IScaviService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IScaviService/GetPointsOfInterestRSSAsync", ReplyAction="http://tempuri.org/IScaviService/GetPointsOfInterestRSSAsyncResponse")]
        System.IAsyncResult BeginGetPointsOfInterestRSSAsync(System.AsyncCallback callback, object asyncState);
        
        string EndGetPointsOfInterestRSSAsync(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScaviServiceChannel : PhoneApp1.ServiceReference1.IScaviService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPointsOfInterestRSSAsyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetPointsOfInterestRSSAsyncCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScaviServiceClient : System.ServiceModel.ClientBase<PhoneApp1.ServiceReference1.IScaviService>, PhoneApp1.ServiceReference1.IScaviService {
        
        private BeginOperationDelegate onBeginGetPointsOfInterestRSSAsyncDelegate;
        
        private EndOperationDelegate onEndGetPointsOfInterestRSSAsyncDelegate;
        
        private System.Threading.SendOrPostCallback onGetPointsOfInterestRSSAsyncCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ScaviServiceClient() {
        }
        
        public ScaviServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScaviServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScaviServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScaviServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<GetPointsOfInterestRSSAsyncCompletedEventArgs> GetPointsOfInterestRSSAsyncCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneApp1.ServiceReference1.IScaviService.BeginGetPointsOfInterestRSSAsync(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetPointsOfInterestRSSAsync(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string PhoneApp1.ServiceReference1.IScaviService.EndGetPointsOfInterestRSSAsync(System.IAsyncResult result) {
            return base.Channel.EndGetPointsOfInterestRSSAsync(result);
        }
        
        private System.IAsyncResult OnBeginGetPointsOfInterestRSSAsync(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((PhoneApp1.ServiceReference1.IScaviService)(this)).BeginGetPointsOfInterestRSSAsync(callback, asyncState);
        }
        
        private object[] OnEndGetPointsOfInterestRSSAsync(System.IAsyncResult result) {
            string retVal = ((PhoneApp1.ServiceReference1.IScaviService)(this)).EndGetPointsOfInterestRSSAsync(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetPointsOfInterestRSSAsyncCompleted(object state) {
            if ((this.GetPointsOfInterestRSSAsyncCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetPointsOfInterestRSSAsyncCompleted(this, new GetPointsOfInterestRSSAsyncCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetPointsOfInterestRSSAsyncAsync() {
            this.GetPointsOfInterestRSSAsyncAsync(null);
        }
        
        public void GetPointsOfInterestRSSAsyncAsync(object userState) {
            if ((this.onBeginGetPointsOfInterestRSSAsyncDelegate == null)) {
                this.onBeginGetPointsOfInterestRSSAsyncDelegate = new BeginOperationDelegate(this.OnBeginGetPointsOfInterestRSSAsync);
            }
            if ((this.onEndGetPointsOfInterestRSSAsyncDelegate == null)) {
                this.onEndGetPointsOfInterestRSSAsyncDelegate = new EndOperationDelegate(this.OnEndGetPointsOfInterestRSSAsync);
            }
            if ((this.onGetPointsOfInterestRSSAsyncCompletedDelegate == null)) {
                this.onGetPointsOfInterestRSSAsyncCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetPointsOfInterestRSSAsyncCompleted);
            }
            base.InvokeAsync(this.onBeginGetPointsOfInterestRSSAsyncDelegate, null, this.onEndGetPointsOfInterestRSSAsyncDelegate, this.onGetPointsOfInterestRSSAsyncCompletedDelegate, userState);
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
        
        protected override PhoneApp1.ServiceReference1.IScaviService CreateChannel() {
            return new ScaviServiceClientChannel(this);
        }
        
        private class ScaviServiceClientChannel : ChannelBase<PhoneApp1.ServiceReference1.IScaviService>, PhoneApp1.ServiceReference1.IScaviService {
            
            public ScaviServiceClientChannel(System.ServiceModel.ClientBase<PhoneApp1.ServiceReference1.IScaviService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetPointsOfInterestRSSAsync(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetPointsOfInterestRSSAsync", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetPointsOfInterestRSSAsync(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetPointsOfInterestRSSAsync", _args, result)));
                return _result;
            }
        }
    }
}
