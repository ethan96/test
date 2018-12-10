﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1008.
// 
#pragma warning disable 1591

namespace eStore.BusinessModules.MyAdvantechSAPCustomerNew {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MAMigrationSoap", Namespace="MyAdvantechGlobal")]
    public partial class MAMigration : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CATALOG_EditOperationCompleted;
        
        private System.Threading.SendOrPostCallback SyncSingleSAPCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback CBOM_EditOperationCompleted;
        
        private System.Threading.SendOrPostCallback SyncPartNoFromSAPOperationCompleted;
        
        private System.Threading.SendOrPostCallback SyncCompanyIdFromSAPOperationCompleted;
        
        private System.Threading.SendOrPostCallback HelloKiityOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MAMigration() {
            this.Url = global::eStore.BusinessModules.Properties.Settings.Default.eStore_BusinessModules_MyAdvantechSAPCustomerNew_MAMigration;
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
        public event CATALOG_EditCompletedEventHandler CATALOG_EditCompleted;
        
        /// <remarks/>
        public event SyncSingleSAPCustomerCompletedEventHandler SyncSingleSAPCustomerCompleted;
        
        /// <remarks/>
        public event CBOM_EditCompletedEventHandler CBOM_EditCompleted;
        
        /// <remarks/>
        public event SyncPartNoFromSAPCompletedEventHandler SyncPartNoFromSAPCompleted;
        
        /// <remarks/>
        public event SyncCompanyIdFromSAPCompletedEventHandler SyncCompanyIdFromSAPCompleted;
        
        /// <remarks/>
        public event HelloKiityCompletedEventHandler HelloKiityCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechGlobal/CATALOG_Edit", RequestNamespace="MyAdvantechGlobal", ResponseNamespace="MyAdvantechGlobal", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CATALOG_Edit(CBOMActions act, string CataID, string CataName, string GroupName, string CataDesc, string CreatedBy, string ImgName) {
            object[] results = this.Invoke("CATALOG_Edit", new object[] {
                        act,
                        CataID,
                        CataName,
                        GroupName,
                        CataDesc,
                        CreatedBy,
                        ImgName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CATALOG_EditAsync(CBOMActions act, string CataID, string CataName, string GroupName, string CataDesc, string CreatedBy, string ImgName) {
            this.CATALOG_EditAsync(act, CataID, CataName, GroupName, CataDesc, CreatedBy, ImgName, null);
        }
        
        /// <remarks/>
        public void CATALOG_EditAsync(CBOMActions act, string CataID, string CataName, string GroupName, string CataDesc, string CreatedBy, string ImgName, object userState) {
            if ((this.CATALOG_EditOperationCompleted == null)) {
                this.CATALOG_EditOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCATALOG_EditOperationCompleted);
            }
            this.InvokeAsync("CATALOG_Edit", new object[] {
                        act,
                        CataID,
                        CataName,
                        GroupName,
                        CataDesc,
                        CreatedBy,
                        ImgName}, this.CATALOG_EditOperationCompleted, userState);
        }
        
        private void OnCATALOG_EditOperationCompleted(object arg) {
            if ((this.CATALOG_EditCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CATALOG_EditCompleted(this, new CATALOG_EditCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechGlobal/SyncSingleSAPCustomer", RequestNamespace="MyAdvantechGlobal", ResponseNamespace="MyAdvantechGlobal", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SyncSingleSAPCustomer(string CompanyId, bool isTest, ref string ErrMsg) {
            object[] results = this.Invoke("SyncSingleSAPCustomer", new object[] {
                        CompanyId,
                        isTest,
                        ErrMsg});
            ErrMsg = ((string)(results[1]));
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SyncSingleSAPCustomerAsync(string CompanyId, bool isTest, string ErrMsg) {
            this.SyncSingleSAPCustomerAsync(CompanyId, isTest, ErrMsg, null);
        }
        
        /// <remarks/>
        public void SyncSingleSAPCustomerAsync(string CompanyId, bool isTest, string ErrMsg, object userState) {
            if ((this.SyncSingleSAPCustomerOperationCompleted == null)) {
                this.SyncSingleSAPCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSyncSingleSAPCustomerOperationCompleted);
            }
            this.InvokeAsync("SyncSingleSAPCustomer", new object[] {
                        CompanyId,
                        isTest,
                        ErrMsg}, this.SyncSingleSAPCustomerOperationCompleted, userState);
        }
        
        private void OnSyncSingleSAPCustomerOperationCompleted(object arg) {
            if ((this.SyncSingleSAPCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SyncSingleSAPCustomerCompleted(this, new SyncSingleSAPCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechGlobal/CBOM_Edit", RequestNamespace="MyAdvantechGlobal", ResponseNamespace="MyAdvantechGlobal", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CBOM_Edit(CBOMActions act, string CatId, string CatType, string ParentCatId, string CatDesc, string ExtDesc, string UpdBy, int SeqNo, string ConfigRule, string NotExpandCat, string ShowHide) {
            object[] results = this.Invoke("CBOM_Edit", new object[] {
                        act,
                        CatId,
                        CatType,
                        ParentCatId,
                        CatDesc,
                        ExtDesc,
                        UpdBy,
                        SeqNo,
                        ConfigRule,
                        NotExpandCat,
                        ShowHide});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CBOM_EditAsync(CBOMActions act, string CatId, string CatType, string ParentCatId, string CatDesc, string ExtDesc, string UpdBy, int SeqNo, string ConfigRule, string NotExpandCat, string ShowHide) {
            this.CBOM_EditAsync(act, CatId, CatType, ParentCatId, CatDesc, ExtDesc, UpdBy, SeqNo, ConfigRule, NotExpandCat, ShowHide, null);
        }
        
        /// <remarks/>
        public void CBOM_EditAsync(CBOMActions act, string CatId, string CatType, string ParentCatId, string CatDesc, string ExtDesc, string UpdBy, int SeqNo, string ConfigRule, string NotExpandCat, string ShowHide, object userState) {
            if ((this.CBOM_EditOperationCompleted == null)) {
                this.CBOM_EditOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCBOM_EditOperationCompleted);
            }
            this.InvokeAsync("CBOM_Edit", new object[] {
                        act,
                        CatId,
                        CatType,
                        ParentCatId,
                        CatDesc,
                        ExtDesc,
                        UpdBy,
                        SeqNo,
                        ConfigRule,
                        NotExpandCat,
                        ShowHide}, this.CBOM_EditOperationCompleted, userState);
        }
        
        private void OnCBOM_EditOperationCompleted(object arg) {
            if ((this.CBOM_EditCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CBOM_EditCompleted(this, new CBOM_EditCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechGlobal/SyncPartNoFromSAP", RequestNamespace="MyAdvantechGlobal", ResponseNamespace="MyAdvantechGlobal", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SyncPartNoFromSAP(string pn) {
            object[] results = this.Invoke("SyncPartNoFromSAP", new object[] {
                        pn});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SyncPartNoFromSAPAsync(string pn) {
            this.SyncPartNoFromSAPAsync(pn, null);
        }
        
        /// <remarks/>
        public void SyncPartNoFromSAPAsync(string pn, object userState) {
            if ((this.SyncPartNoFromSAPOperationCompleted == null)) {
                this.SyncPartNoFromSAPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSyncPartNoFromSAPOperationCompleted);
            }
            this.InvokeAsync("SyncPartNoFromSAP", new object[] {
                        pn}, this.SyncPartNoFromSAPOperationCompleted, userState);
        }
        
        private void OnSyncPartNoFromSAPOperationCompleted(object arg) {
            if ((this.SyncPartNoFromSAPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SyncPartNoFromSAPCompleted(this, new SyncPartNoFromSAPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechGlobal/SyncCompanyIdFromSAP", RequestNamespace="MyAdvantechGlobal", ResponseNamespace="MyAdvantechGlobal", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SyncCompanyIdFromSAP(string companyid) {
            object[] results = this.Invoke("SyncCompanyIdFromSAP", new object[] {
                        companyid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SyncCompanyIdFromSAPAsync(string companyid) {
            this.SyncCompanyIdFromSAPAsync(companyid, null);
        }
        
        /// <remarks/>
        public void SyncCompanyIdFromSAPAsync(string companyid, object userState) {
            if ((this.SyncCompanyIdFromSAPOperationCompleted == null)) {
                this.SyncCompanyIdFromSAPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSyncCompanyIdFromSAPOperationCompleted);
            }
            this.InvokeAsync("SyncCompanyIdFromSAP", new object[] {
                        companyid}, this.SyncCompanyIdFromSAPOperationCompleted, userState);
        }
        
        private void OnSyncCompanyIdFromSAPOperationCompleted(object arg) {
            if ((this.SyncCompanyIdFromSAPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SyncCompanyIdFromSAPCompleted(this, new SyncCompanyIdFromSAPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechGlobal/HelloKiity", RequestNamespace="MyAdvantechGlobal", ResponseNamespace="MyAdvantechGlobal", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloKiity() {
            object[] results = this.Invoke("HelloKiity", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloKiityAsync() {
            this.HelloKiityAsync(null);
        }
        
        /// <remarks/>
        public void HelloKiityAsync(object userState) {
            if ((this.HelloKiityOperationCompleted == null)) {
                this.HelloKiityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloKiityOperationCompleted);
            }
            this.InvokeAsync("HelloKiity", new object[0], this.HelloKiityOperationCompleted, userState);
        }
        
        private void OnHelloKiityOperationCompleted(object arg) {
            if ((this.HelloKiityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloKiityCompleted(this, new HelloKiityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="MyAdvantechGlobal")]
    public enum CBOMActions {
        
        /// <remarks/>
        ADD,
        
        /// <remarks/>
        UPDATE,
        
        /// <remarks/>
        DELETE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CATALOG_EditCompletedEventHandler(object sender, CATALOG_EditCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CATALOG_EditCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CATALOG_EditCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SyncSingleSAPCustomerCompletedEventHandler(object sender, SyncSingleSAPCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SyncSingleSAPCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SyncSingleSAPCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string ErrMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CBOM_EditCompletedEventHandler(object sender, CBOM_EditCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CBOM_EditCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CBOM_EditCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SyncPartNoFromSAPCompletedEventHandler(object sender, SyncPartNoFromSAPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SyncPartNoFromSAPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SyncPartNoFromSAPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SyncCompanyIdFromSAPCompletedEventHandler(object sender, SyncCompanyIdFromSAPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SyncCompanyIdFromSAPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SyncCompanyIdFromSAPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void HelloKiityCompletedEventHandler(object sender, HelloKiityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloKiityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloKiityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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