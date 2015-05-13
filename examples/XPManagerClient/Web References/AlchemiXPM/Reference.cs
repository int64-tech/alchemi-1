﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
// 
#pragma warning disable 1591

namespace XPManagerClient.AlchemiXPM {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CrossPlatformManagerSoap", Namespace="http://www.alchemi.net")]
    public partial class CrossPlatformManager : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetJobStateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFinishedJobsOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddJobOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubmitTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback PingOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListLiveAppsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetApplicationStateOperationCompleted;
        
        private System.Threading.SendOrPostCallback AbortTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback AbortJobOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CrossPlatformManager() {
            this.Url = "http://localhost/Alchemi.CrossPlatformManager/CrossPlatformManager.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetJobStateCompletedEventHandler GetJobStateCompleted;
        
        /// <remarks/>
        public event GetFinishedJobsCompletedEventHandler GetFinishedJobsCompleted;
        
        /// <remarks/>
        public event AddJobCompletedEventHandler AddJobCompleted;
        
        /// <remarks/>
        public event SubmitTaskCompletedEventHandler SubmitTaskCompleted;
        
        /// <remarks/>
        public event CreateTaskCompletedEventHandler CreateTaskCompleted;
        
        /// <remarks/>
        public event PingCompletedEventHandler PingCompleted;
        
        /// <remarks/>
        public event ListLiveAppsCompletedEventHandler ListLiveAppsCompleted;
        
        /// <remarks/>
        public event GetApplicationStateCompletedEventHandler GetApplicationStateCompleted;
        
        /// <remarks/>
        public event AbortTaskCompletedEventHandler AbortTaskCompleted;
        
        /// <remarks/>
        public event AbortJobCompletedEventHandler AbortJobCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/GetJobState", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetJobState(string username, string password, string taskId, int jobId) {
            object[] results = this.Invoke("GetJobState", new object[] {
                        username,
                        password,
                        taskId,
                        jobId});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetJobState(string username, string password, string taskId, int jobId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetJobState", new object[] {
                        username,
                        password,
                        taskId,
                        jobId}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndGetJobState(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetJobStateAsync(string username, string password, string taskId, int jobId) {
            this.GetJobStateAsync(username, password, taskId, jobId, null);
        }
        
        /// <remarks/>
        public void GetJobStateAsync(string username, string password, string taskId, int jobId, object userState) {
            if ((this.GetJobStateOperationCompleted == null)) {
                this.GetJobStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetJobStateOperationCompleted);
            }
            this.InvokeAsync("GetJobState", new object[] {
                        username,
                        password,
                        taskId,
                        jobId}, this.GetJobStateOperationCompleted, userState);
        }
        
        private void OnGetJobStateOperationCompleted(object arg) {
            if ((this.GetJobStateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetJobStateCompleted(this, new GetJobStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/GetFinishedJobs", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFinishedJobs(string username, string password, string taskId) {
            object[] results = this.Invoke("GetFinishedJobs", new object[] {
                        username,
                        password,
                        taskId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFinishedJobs(string username, string password, string taskId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFinishedJobs", new object[] {
                        username,
                        password,
                        taskId}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetFinishedJobs(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFinishedJobsAsync(string username, string password, string taskId) {
            this.GetFinishedJobsAsync(username, password, taskId, null);
        }
        
        /// <remarks/>
        public void GetFinishedJobsAsync(string username, string password, string taskId, object userState) {
            if ((this.GetFinishedJobsOperationCompleted == null)) {
                this.GetFinishedJobsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFinishedJobsOperationCompleted);
            }
            this.InvokeAsync("GetFinishedJobs", new object[] {
                        username,
                        password,
                        taskId}, this.GetFinishedJobsOperationCompleted, userState);
        }
        
        private void OnGetFinishedJobsOperationCompleted(object arg) {
            if ((this.GetFinishedJobsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFinishedJobsCompleted(this, new GetFinishedJobsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/AddJob", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddJob(string username, string password, string taskId, int jobId, int priority, string jobXml) {
            this.Invoke("AddJob", new object[] {
                        username,
                        password,
                        taskId,
                        jobId,
                        priority,
                        jobXml});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddJob(string username, string password, string taskId, int jobId, int priority, string jobXml, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddJob", new object[] {
                        username,
                        password,
                        taskId,
                        jobId,
                        priority,
                        jobXml}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAddJob(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void AddJobAsync(string username, string password, string taskId, int jobId, int priority, string jobXml) {
            this.AddJobAsync(username, password, taskId, jobId, priority, jobXml, null);
        }
        
        /// <remarks/>
        public void AddJobAsync(string username, string password, string taskId, int jobId, int priority, string jobXml, object userState) {
            if ((this.AddJobOperationCompleted == null)) {
                this.AddJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddJobOperationCompleted);
            }
            this.InvokeAsync("AddJob", new object[] {
                        username,
                        password,
                        taskId,
                        jobId,
                        priority,
                        jobXml}, this.AddJobOperationCompleted, userState);
        }
        
        private void OnAddJobOperationCompleted(object arg) {
            if ((this.AddJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddJobCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/SubmitTask", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SubmitTask(string username, string password, string taskXml) {
            object[] results = this.Invoke("SubmitTask", new object[] {
                        username,
                        password,
                        taskXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSubmitTask(string username, string password, string taskXml, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SubmitTask", new object[] {
                        username,
                        password,
                        taskXml}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndSubmitTask(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SubmitTaskAsync(string username, string password, string taskXml) {
            this.SubmitTaskAsync(username, password, taskXml, null);
        }
        
        /// <remarks/>
        public void SubmitTaskAsync(string username, string password, string taskXml, object userState) {
            if ((this.SubmitTaskOperationCompleted == null)) {
                this.SubmitTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitTaskOperationCompleted);
            }
            this.InvokeAsync("SubmitTask", new object[] {
                        username,
                        password,
                        taskXml}, this.SubmitTaskOperationCompleted, userState);
        }
        
        private void OnSubmitTaskOperationCompleted(object arg) {
            if ((this.SubmitTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitTaskCompleted(this, new SubmitTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/CreateTask", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateTask(string username, string password) {
            object[] results = this.Invoke("CreateTask", new object[] {
                        username,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateTask(string username, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateTask", new object[] {
                        username,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndCreateTask(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateTaskAsync(string username, string password) {
            this.CreateTaskAsync(username, password, null);
        }
        
        /// <remarks/>
        public void CreateTaskAsync(string username, string password, object userState) {
            if ((this.CreateTaskOperationCompleted == null)) {
                this.CreateTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateTaskOperationCompleted);
            }
            this.InvokeAsync("CreateTask", new object[] {
                        username,
                        password}, this.CreateTaskOperationCompleted, userState);
        }
        
        private void OnCreateTaskOperationCompleted(object arg) {
            if ((this.CreateTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateTaskCompleted(this, new CreateTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/Ping", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Ping() {
            this.Invoke("Ping", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginPing(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ping", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndPing(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void PingAsync() {
            this.PingAsync(null);
        }
        
        /// <remarks/>
        public void PingAsync(object userState) {
            if ((this.PingOperationCompleted == null)) {
                this.PingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPingOperationCompleted);
            }
            this.InvokeAsync("Ping", new object[0], this.PingOperationCompleted, userState);
        }
        
        private void OnPingOperationCompleted(object arg) {
            if ((this.PingCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PingCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/ListLiveApps", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ListLiveApps() {
            object[] results = this.Invoke("ListLiveApps", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginListLiveApps(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ListLiveApps", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndListLiveApps(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ListLiveAppsAsync() {
            this.ListLiveAppsAsync(null);
        }
        
        /// <remarks/>
        public void ListLiveAppsAsync(object userState) {
            if ((this.ListLiveAppsOperationCompleted == null)) {
                this.ListLiveAppsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListLiveAppsOperationCompleted);
            }
            this.InvokeAsync("ListLiveApps", new object[0], this.ListLiveAppsOperationCompleted, userState);
        }
        
        private void OnListLiveAppsOperationCompleted(object arg) {
            if ((this.ListLiveAppsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListLiveAppsCompleted(this, new ListLiveAppsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/GetApplicationState", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetApplicationState(string username, string password, string taskId) {
            object[] results = this.Invoke("GetApplicationState", new object[] {
                        username,
                        password,
                        taskId});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetApplicationState(string username, string password, string taskId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetApplicationState", new object[] {
                        username,
                        password,
                        taskId}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndGetApplicationState(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetApplicationStateAsync(string username, string password, string taskId) {
            this.GetApplicationStateAsync(username, password, taskId, null);
        }
        
        /// <remarks/>
        public void GetApplicationStateAsync(string username, string password, string taskId, object userState) {
            if ((this.GetApplicationStateOperationCompleted == null)) {
                this.GetApplicationStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationStateOperationCompleted);
            }
            this.InvokeAsync("GetApplicationState", new object[] {
                        username,
                        password,
                        taskId}, this.GetApplicationStateOperationCompleted, userState);
        }
        
        private void OnGetApplicationStateOperationCompleted(object arg) {
            if ((this.GetApplicationStateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationStateCompleted(this, new GetApplicationStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/AbortTask", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AbortTask(string username, string password, string taskId) {
            this.Invoke("AbortTask", new object[] {
                        username,
                        password,
                        taskId});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAbortTask(string username, string password, string taskId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AbortTask", new object[] {
                        username,
                        password,
                        taskId}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAbortTask(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void AbortTaskAsync(string username, string password, string taskId) {
            this.AbortTaskAsync(username, password, taskId, null);
        }
        
        /// <remarks/>
        public void AbortTaskAsync(string username, string password, string taskId, object userState) {
            if ((this.AbortTaskOperationCompleted == null)) {
                this.AbortTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAbortTaskOperationCompleted);
            }
            this.InvokeAsync("AbortTask", new object[] {
                        username,
                        password,
                        taskId}, this.AbortTaskOperationCompleted, userState);
        }
        
        private void OnAbortTaskOperationCompleted(object arg) {
            if ((this.AbortTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AbortTaskCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alchemi.net/AbortJob", RequestNamespace="http://www.alchemi.net", ResponseNamespace="http://www.alchemi.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AbortJob(string username, string password, string taskId, int jobId) {
            this.Invoke("AbortJob", new object[] {
                        username,
                        password,
                        taskId,
                        jobId});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAbortJob(string username, string password, string taskId, int jobId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AbortJob", new object[] {
                        username,
                        password,
                        taskId,
                        jobId}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAbortJob(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void AbortJobAsync(string username, string password, string taskId, int jobId) {
            this.AbortJobAsync(username, password, taskId, jobId, null);
        }
        
        /// <remarks/>
        public void AbortJobAsync(string username, string password, string taskId, int jobId, object userState) {
            if ((this.AbortJobOperationCompleted == null)) {
                this.AbortJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAbortJobOperationCompleted);
            }
            this.InvokeAsync("AbortJob", new object[] {
                        username,
                        password,
                        taskId,
                        jobId}, this.AbortJobOperationCompleted, userState);
        }
        
        private void OnAbortJobOperationCompleted(object arg) {
            if ((this.AbortJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AbortJobCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void GetJobStateCompletedEventHandler(object sender, GetJobStateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetJobStateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetJobStateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void GetFinishedJobsCompletedEventHandler(object sender, GetFinishedJobsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFinishedJobsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFinishedJobsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void AddJobCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void SubmitTaskCompletedEventHandler(object sender, SubmitTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubmitTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void CreateTaskCompletedEventHandler(object sender, CreateTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void PingCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void ListLiveAppsCompletedEventHandler(object sender, ListLiveAppsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListLiveAppsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListLiveAppsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void GetApplicationStateCompletedEventHandler(object sender, GetApplicationStateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationStateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetApplicationStateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void AbortTaskCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void AbortJobCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591