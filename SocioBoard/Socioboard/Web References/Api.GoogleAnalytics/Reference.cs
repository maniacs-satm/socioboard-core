﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Socioboard.Api.GoogleAnalytics {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GoogleAnalyticsSoap", Namespace="http://tempuri.org/")]
    public partial class GoogleAnalytics : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAnalyticsProfileOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddAnalyticsProfilesOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateGoogleAnalyticsAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGoogleAnalyticsDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTwitterWebMentionsOperationCompleted;
        
        private System.Threading.SendOrPostCallback DailyMotionPostOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetYoutubeSearchDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GoogleAnalytics() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_GoogleAnalytics_GoogleAnalytics;
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
        public event GetAnalyticsProfileCompletedEventHandler GetAnalyticsProfileCompleted;
        
        /// <remarks/>
        public event AddAnalyticsProfilesCompletedEventHandler AddAnalyticsProfilesCompleted;
        
        /// <remarks/>
        public event UpdateGoogleAnalyticsAccountCompletedEventHandler UpdateGoogleAnalyticsAccountCompleted;
        
        /// <remarks/>
        public event GetGoogleAnalyticsDataCompletedEventHandler GetGoogleAnalyticsDataCompleted;
        
        /// <remarks/>
        public event GetTwitterWebMentionsCompletedEventHandler GetTwitterWebMentionsCompleted;
        
        /// <remarks/>
        public event DailyMotionPostCompletedEventHandler DailyMotionPostCompleted;
        
        /// <remarks/>
        public event GetYoutubeSearchDataCompletedEventHandler GetYoutubeSearchDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAnalyticsProfile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAnalyticsProfile(string code) {
            object[] results = this.Invoke("GetAnalyticsProfile", new object[] {
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAnalyticsProfileAsync(string code) {
            this.GetAnalyticsProfileAsync(code, null);
        }
        
        /// <remarks/>
        public void GetAnalyticsProfileAsync(string code, object userState) {
            if ((this.GetAnalyticsProfileOperationCompleted == null)) {
                this.GetAnalyticsProfileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAnalyticsProfileOperationCompleted);
            }
            this.InvokeAsync("GetAnalyticsProfile", new object[] {
                        code}, this.GetAnalyticsProfileOperationCompleted, userState);
        }
        
        private void OnGetAnalyticsProfileOperationCompleted(object arg) {
            if ((this.GetAnalyticsProfileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAnalyticsProfileCompleted(this, new GetAnalyticsProfileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddAnalyticsProfiles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddAnalyticsProfiles(string GAProfiles, string UserId, string GroupId) {
            object[] results = this.Invoke("AddAnalyticsProfiles", new object[] {
                        GAProfiles,
                        UserId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddAnalyticsProfilesAsync(string GAProfiles, string UserId, string GroupId) {
            this.AddAnalyticsProfilesAsync(GAProfiles, UserId, GroupId, null);
        }
        
        /// <remarks/>
        public void AddAnalyticsProfilesAsync(string GAProfiles, string UserId, string GroupId, object userState) {
            if ((this.AddAnalyticsProfilesOperationCompleted == null)) {
                this.AddAnalyticsProfilesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddAnalyticsProfilesOperationCompleted);
            }
            this.InvokeAsync("AddAnalyticsProfiles", new object[] {
                        GAProfiles,
                        UserId,
                        GroupId}, this.AddAnalyticsProfilesOperationCompleted, userState);
        }
        
        private void OnAddAnalyticsProfilesOperationCompleted(object arg) {
            if ((this.AddAnalyticsProfilesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddAnalyticsProfilesCompleted(this, new AddAnalyticsProfilesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateGoogleAnalyticsAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateGoogleAnalyticsAccount(string ProfileId, string AccessToken, string HostName) {
            object[] results = this.Invoke("UpdateGoogleAnalyticsAccount", new object[] {
                        ProfileId,
                        AccessToken,
                        HostName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateGoogleAnalyticsAccountAsync(string ProfileId, string AccessToken, string HostName) {
            this.UpdateGoogleAnalyticsAccountAsync(ProfileId, AccessToken, HostName, null);
        }
        
        /// <remarks/>
        public void UpdateGoogleAnalyticsAccountAsync(string ProfileId, string AccessToken, string HostName, object userState) {
            if ((this.UpdateGoogleAnalyticsAccountOperationCompleted == null)) {
                this.UpdateGoogleAnalyticsAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateGoogleAnalyticsAccountOperationCompleted);
            }
            this.InvokeAsync("UpdateGoogleAnalyticsAccount", new object[] {
                        ProfileId,
                        AccessToken,
                        HostName}, this.UpdateGoogleAnalyticsAccountOperationCompleted, userState);
        }
        
        private void OnUpdateGoogleAnalyticsAccountOperationCompleted(object arg) {
            if ((this.UpdateGoogleAnalyticsAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateGoogleAnalyticsAccountCompleted(this, new UpdateGoogleAnalyticsAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGoogleAnalyticsData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetGoogleAnalyticsData(string ProfileId, string AccessToken, string HostName) {
            object[] results = this.Invoke("GetGoogleAnalyticsData", new object[] {
                        ProfileId,
                        AccessToken,
                        HostName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetGoogleAnalyticsDataAsync(string ProfileId, string AccessToken, string HostName) {
            this.GetGoogleAnalyticsDataAsync(ProfileId, AccessToken, HostName, null);
        }
        
        /// <remarks/>
        public void GetGoogleAnalyticsDataAsync(string ProfileId, string AccessToken, string HostName, object userState) {
            if ((this.GetGoogleAnalyticsDataOperationCompleted == null)) {
                this.GetGoogleAnalyticsDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGoogleAnalyticsDataOperationCompleted);
            }
            this.InvokeAsync("GetGoogleAnalyticsData", new object[] {
                        ProfileId,
                        AccessToken,
                        HostName}, this.GetGoogleAnalyticsDataOperationCompleted, userState);
        }
        
        private void OnGetGoogleAnalyticsDataOperationCompleted(object arg) {
            if ((this.GetGoogleAnalyticsDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGoogleAnalyticsDataCompleted(this, new GetGoogleAnalyticsDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterWebMentions", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetTwitterWebMentions(string HostName) {
            this.Invoke("GetTwitterWebMentions", new object[] {
                        HostName});
        }
        
        /// <remarks/>
        public void GetTwitterWebMentionsAsync(string HostName) {
            this.GetTwitterWebMentionsAsync(HostName, null);
        }
        
        /// <remarks/>
        public void GetTwitterWebMentionsAsync(string HostName, object userState) {
            if ((this.GetTwitterWebMentionsOperationCompleted == null)) {
                this.GetTwitterWebMentionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterWebMentionsOperationCompleted);
            }
            this.InvokeAsync("GetTwitterWebMentions", new object[] {
                        HostName}, this.GetTwitterWebMentionsOperationCompleted, userState);
        }
        
        private void OnGetTwitterWebMentionsOperationCompleted(object arg) {
            if ((this.GetTwitterWebMentionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterWebMentionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DailyMotionPost", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DailyMotionPost(string Url) {
            object[] results = this.Invoke("DailyMotionPost", new object[] {
                        Url});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DailyMotionPostAsync(string Url) {
            this.DailyMotionPostAsync(Url, null);
        }
        
        /// <remarks/>
        public void DailyMotionPostAsync(string Url, object userState) {
            if ((this.DailyMotionPostOperationCompleted == null)) {
                this.DailyMotionPostOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDailyMotionPostOperationCompleted);
            }
            this.InvokeAsync("DailyMotionPost", new object[] {
                        Url}, this.DailyMotionPostOperationCompleted, userState);
        }
        
        private void OnDailyMotionPostOperationCompleted(object arg) {
            if ((this.DailyMotionPostCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DailyMotionPostCompleted(this, new DailyMotionPostCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetYoutubeSearchData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetYoutubeSearchData(string Url) {
            object[] results = this.Invoke("GetYoutubeSearchData", new object[] {
                        Url});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetYoutubeSearchDataAsync(string Url) {
            this.GetYoutubeSearchDataAsync(Url, null);
        }
        
        /// <remarks/>
        public void GetYoutubeSearchDataAsync(string Url, object userState) {
            if ((this.GetYoutubeSearchDataOperationCompleted == null)) {
                this.GetYoutubeSearchDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetYoutubeSearchDataOperationCompleted);
            }
            this.InvokeAsync("GetYoutubeSearchData", new object[] {
                        Url}, this.GetYoutubeSearchDataOperationCompleted, userState);
        }
        
        private void OnGetYoutubeSearchDataOperationCompleted(object arg) {
            if ((this.GetYoutubeSearchDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetYoutubeSearchDataCompleted(this, new GetYoutubeSearchDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetAnalyticsProfileCompletedEventHandler(object sender, GetAnalyticsProfileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAnalyticsProfileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAnalyticsProfileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void AddAnalyticsProfilesCompletedEventHandler(object sender, AddAnalyticsProfilesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddAnalyticsProfilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddAnalyticsProfilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void UpdateGoogleAnalyticsAccountCompletedEventHandler(object sender, UpdateGoogleAnalyticsAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateGoogleAnalyticsAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateGoogleAnalyticsAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetGoogleAnalyticsDataCompletedEventHandler(object sender, GetGoogleAnalyticsDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGoogleAnalyticsDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGoogleAnalyticsDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetTwitterWebMentionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void DailyMotionPostCompletedEventHandler(object sender, DailyMotionPostCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DailyMotionPostCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DailyMotionPostCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetYoutubeSearchDataCompletedEventHandler(object sender, GetYoutubeSearchDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetYoutubeSearchDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetYoutubeSearchDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591