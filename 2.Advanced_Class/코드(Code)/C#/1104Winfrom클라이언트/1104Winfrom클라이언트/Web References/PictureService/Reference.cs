﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 이 소스 코드가 Microsoft.VSDesigner, 버전 4.0.30319.42000에서 자동으로 생성되었습니다.
// 
#pragma warning disable 1591

namespace _1104Winfrom클라이언트.PictureService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IPictureService", Namespace="http://tempuri.org/")]
    public partial class PictureService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPictureOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPictureListOperationCompleted;
        
        private System.Threading.SendOrPostCallback UploadPictureOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PictureService() {
            this.Url = global::_1104Winfrom클라이언트.Properties.Settings.Default._1104Winfrom클라이언트_PictureService_PictureService;
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
        public event GetPictureCompletedEventHandler GetPictureCompleted;
        
        /// <remarks/>
        public event GetPictureListCompletedEventHandler GetPictureListCompleted;
        
        /// <remarks/>
        public event UploadPictureCompletedEventHandler UploadPictureCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPictureService/GetPicture", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] GetPicture([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strFileName) {
            object[] results = this.Invoke("GetPicture", new object[] {
                        strFileName});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void GetPictureAsync(string strFileName) {
            this.GetPictureAsync(strFileName, null);
        }
        
        /// <remarks/>
        public void GetPictureAsync(string strFileName, object userState) {
            if ((this.GetPictureOperationCompleted == null)) {
                this.GetPictureOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPictureOperationCompleted);
            }
            this.InvokeAsync("GetPicture", new object[] {
                        strFileName}, this.GetPictureOperationCompleted, userState);
        }
        
        private void OnGetPictureOperationCompleted(object arg) {
            if ((this.GetPictureCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPictureCompleted(this, new GetPictureCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPictureService/GetPictureList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] GetPictureList() {
            object[] results = this.Invoke("GetPictureList", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetPictureListAsync() {
            this.GetPictureListAsync(null);
        }
        
        /// <remarks/>
        public void GetPictureListAsync(object userState) {
            if ((this.GetPictureListOperationCompleted == null)) {
                this.GetPictureListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPictureListOperationCompleted);
            }
            this.InvokeAsync("GetPictureList", new object[0], this.GetPictureListOperationCompleted, userState);
        }
        
        private void OnGetPictureListOperationCompleted(object arg) {
            if ((this.GetPictureListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPictureListCompleted(this, new GetPictureListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPictureService/UploadPicture", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UploadPicture([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strFileName, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)] byte[] bytePic, out bool UploadPictureResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool UploadPictureResultSpecified) {
            object[] results = this.Invoke("UploadPicture", new object[] {
                        strFileName,
                        bytePic});
            UploadPictureResult = ((bool)(results[0]));
            UploadPictureResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void UploadPictureAsync(string strFileName, byte[] bytePic) {
            this.UploadPictureAsync(strFileName, bytePic, null);
        }
        
        /// <remarks/>
        public void UploadPictureAsync(string strFileName, byte[] bytePic, object userState) {
            if ((this.UploadPictureOperationCompleted == null)) {
                this.UploadPictureOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadPictureOperationCompleted);
            }
            this.InvokeAsync("UploadPicture", new object[] {
                        strFileName,
                        bytePic}, this.UploadPictureOperationCompleted, userState);
        }
        
        private void OnUploadPictureOperationCompleted(object arg) {
            if ((this.UploadPictureCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadPictureCompleted(this, new UploadPictureCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetPictureCompletedEventHandler(object sender, GetPictureCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPictureCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPictureCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetPictureListCompletedEventHandler(object sender, GetPictureListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPictureListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPictureListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void UploadPictureCompletedEventHandler(object sender, UploadPictureCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadPictureCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UploadPictureCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool UploadPictureResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool UploadPictureResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591