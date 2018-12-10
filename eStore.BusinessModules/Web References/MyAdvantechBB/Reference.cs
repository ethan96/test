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

namespace eStore.BusinessModules.MyAdvantechBB {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BBorderAPISoap", Namespace="http://tempuri.org/")]
    public partial class BBorderAPI : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetBBorderOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateSAPOrderFromBBeStoreOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProcessOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetERPIDbyEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetIncotermTextByERPIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback AutoMaticallyTransfereStoreOrderToSAPOperationCompleted;
        
        private System.Threading.SendOrPostCallback SynceStoreOrderToSAPOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetContactPersonOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetBBCreditCardOrderOperationCompleted;
        
        private System.Threading.SendOrPostCallback CaptureBBCreditCardAuthorizedOrderOperationCompleted;
        
        private System.Threading.SendOrPostCallback AssociateSiebelSAPAccountContactOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BBorderAPI() {
            this.Url = global::eStore.BusinessModules.Properties.Settings.Default.eStore_BusinessModules_MyAdvantechBB_BBorderAPI;
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
        public event GetBBorderCompletedEventHandler GetBBorderCompleted;
        
        /// <remarks/>
        public event CreateSAPOrderFromBBeStoreCompletedEventHandler CreateSAPOrderFromBBeStoreCompleted;
        
        /// <remarks/>
        public event ProcessCompletedEventHandler ProcessCompleted;
        
        /// <remarks/>
        public event GetERPIDbyEmailCompletedEventHandler GetERPIDbyEmailCompleted;
        
        /// <remarks/>
        public event GetIncotermTextByERPIDCompletedEventHandler GetIncotermTextByERPIDCompleted;
        
        /// <remarks/>
        public event AutoMaticallyTransfereStoreOrderToSAPCompletedEventHandler AutoMaticallyTransfereStoreOrderToSAPCompleted;
        
        /// <remarks/>
        public event SynceStoreOrderToSAPCompletedEventHandler SynceStoreOrderToSAPCompleted;
        
        /// <remarks/>
        public event GetContactPersonCompletedEventHandler GetContactPersonCompleted;
        
        /// <remarks/>
        public event GetBBCreditCardOrderCompletedEventHandler GetBBCreditCardOrderCompleted;
        
        /// <remarks/>
        public event CaptureBBCreditCardAuthorizedOrderCompletedEventHandler CaptureBBCreditCardAuthorizedOrderCompleted;
        
        /// <remarks/>
        public event AssociateSiebelSAPAccountContactCompletedEventHandler AssociateSiebelSAPAccountContactCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetBBorder", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetBBorder(string Email, string OrderNo, string OrderStatus) {
            this.Invoke("GetBBorder", new object[] {
                        Email,
                        OrderNo,
                        OrderStatus});
        }
        
        /// <remarks/>
        public void GetBBorderAsync(string Email, string OrderNo, string OrderStatus) {
            this.GetBBorderAsync(Email, OrderNo, OrderStatus, null);
        }
        
        /// <remarks/>
        public void GetBBorderAsync(string Email, string OrderNo, string OrderStatus, object userState) {
            if ((this.GetBBorderOperationCompleted == null)) {
                this.GetBBorderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBBorderOperationCompleted);
            }
            this.InvokeAsync("GetBBorder", new object[] {
                        Email,
                        OrderNo,
                        OrderStatus}, this.GetBBorderOperationCompleted, userState);
        }
        
        private void OnGetBBorderOperationCompleted(object arg) {
            if ((this.GetBBorderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBBorderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateSAPOrderFromBBeStore", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateSAPOrderFromBBeStore(string OrderNo) {
            this.Invoke("CreateSAPOrderFromBBeStore", new object[] {
                        OrderNo});
        }
        
        /// <remarks/>
        public void CreateSAPOrderFromBBeStoreAsync(string OrderNo) {
            this.CreateSAPOrderFromBBeStoreAsync(OrderNo, null);
        }
        
        /// <remarks/>
        public void CreateSAPOrderFromBBeStoreAsync(string OrderNo, object userState) {
            if ((this.CreateSAPOrderFromBBeStoreOperationCompleted == null)) {
                this.CreateSAPOrderFromBBeStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateSAPOrderFromBBeStoreOperationCompleted);
            }
            this.InvokeAsync("CreateSAPOrderFromBBeStore", new object[] {
                        OrderNo}, this.CreateSAPOrderFromBBeStoreOperationCompleted, userState);
        }
        
        private void OnCreateSAPOrderFromBBeStoreOperationCompleted(object arg) {
            if ((this.CreateSAPOrderFromBBeStoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateSAPOrderFromBBeStoreCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Process", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public WebServiceResult Process(string OrderNo) {
            object[] results = this.Invoke("Process", new object[] {
                        OrderNo});
            return ((WebServiceResult)(results[0]));
        }
        
        /// <remarks/>
        public void ProcessAsync(string OrderNo) {
            this.ProcessAsync(OrderNo, null);
        }
        
        /// <remarks/>
        public void ProcessAsync(string OrderNo, object userState) {
            if ((this.ProcessOperationCompleted == null)) {
                this.ProcessOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessOperationCompleted);
            }
            this.InvokeAsync("Process", new object[] {
                        OrderNo}, this.ProcessOperationCompleted, userState);
        }
        
        private void OnProcessOperationCompleted(object arg) {
            if ((this.ProcessCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessCompleted(this, new ProcessCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetERPIDbyEmail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BBCustomer GetERPIDbyEmail(string userID) {
            object[] results = this.Invoke("GetERPIDbyEmail", new object[] {
                        userID});
            return ((BBCustomer)(results[0]));
        }
        
        /// <remarks/>
        public void GetERPIDbyEmailAsync(string userID) {
            this.GetERPIDbyEmailAsync(userID, null);
        }
        
        /// <remarks/>
        public void GetERPIDbyEmailAsync(string userID, object userState) {
            if ((this.GetERPIDbyEmailOperationCompleted == null)) {
                this.GetERPIDbyEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetERPIDbyEmailOperationCompleted);
            }
            this.InvokeAsync("GetERPIDbyEmail", new object[] {
                        userID}, this.GetERPIDbyEmailOperationCompleted, userState);
        }
        
        private void OnGetERPIDbyEmailOperationCompleted(object arg) {
            if ((this.GetERPIDbyEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetERPIDbyEmailCompleted(this, new GetERPIDbyEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetIncotermTextByERPID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIncotermTextByERPID(string ERPID, string ORGID) {
            object[] results = this.Invoke("GetIncotermTextByERPID", new object[] {
                        ERPID,
                        ORGID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetIncotermTextByERPIDAsync(string ERPID, string ORGID) {
            this.GetIncotermTextByERPIDAsync(ERPID, ORGID, null);
        }
        
        /// <remarks/>
        public void GetIncotermTextByERPIDAsync(string ERPID, string ORGID, object userState) {
            if ((this.GetIncotermTextByERPIDOperationCompleted == null)) {
                this.GetIncotermTextByERPIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIncotermTextByERPIDOperationCompleted);
            }
            this.InvokeAsync("GetIncotermTextByERPID", new object[] {
                        ERPID,
                        ORGID}, this.GetIncotermTextByERPIDOperationCompleted, userState);
        }
        
        private void OnGetIncotermTextByERPIDOperationCompleted(object arg) {
            if ((this.GetIncotermTextByERPIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIncotermTextByERPIDCompleted(this, new GetIncotermTextByERPIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AutoMaticallyTransfereStoreOrderToSAP", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AutoMaticallyTransfereStoreOrderToSAP() {
            this.Invoke("AutoMaticallyTransfereStoreOrderToSAP", new object[0]);
        }
        
        /// <remarks/>
        public void AutoMaticallyTransfereStoreOrderToSAPAsync() {
            this.AutoMaticallyTransfereStoreOrderToSAPAsync(null);
        }
        
        /// <remarks/>
        public void AutoMaticallyTransfereStoreOrderToSAPAsync(object userState) {
            if ((this.AutoMaticallyTransfereStoreOrderToSAPOperationCompleted == null)) {
                this.AutoMaticallyTransfereStoreOrderToSAPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAutoMaticallyTransfereStoreOrderToSAPOperationCompleted);
            }
            this.InvokeAsync("AutoMaticallyTransfereStoreOrderToSAP", new object[0], this.AutoMaticallyTransfereStoreOrderToSAPOperationCompleted, userState);
        }
        
        private void OnAutoMaticallyTransfereStoreOrderToSAPOperationCompleted(object arg) {
            if ((this.AutoMaticallyTransfereStoreOrderToSAPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AutoMaticallyTransfereStoreOrderToSAPCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SynceStoreOrderToSAP", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SynceStoreOrderToSAP(string OrderNo) {
            this.Invoke("SynceStoreOrderToSAP", new object[] {
                        OrderNo});
        }
        
        /// <remarks/>
        public void SynceStoreOrderToSAPAsync(string OrderNo) {
            this.SynceStoreOrderToSAPAsync(OrderNo, null);
        }
        
        /// <remarks/>
        public void SynceStoreOrderToSAPAsync(string OrderNo, object userState) {
            if ((this.SynceStoreOrderToSAPOperationCompleted == null)) {
                this.SynceStoreOrderToSAPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSynceStoreOrderToSAPOperationCompleted);
            }
            this.InvokeAsync("SynceStoreOrderToSAP", new object[] {
                        OrderNo}, this.SynceStoreOrderToSAPOperationCompleted, userState);
        }
        
        private void OnSynceStoreOrderToSAPOperationCompleted(object arg) {
            if ((this.SynceStoreOrderToSAPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SynceStoreOrderToSAPCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetContactPerson", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetContactPerson(string Email, string ERPID, string Name) {
            this.Invoke("GetContactPerson", new object[] {
                        Email,
                        ERPID,
                        Name});
        }
        
        /// <remarks/>
        public void GetContactPersonAsync(string Email, string ERPID, string Name) {
            this.GetContactPersonAsync(Email, ERPID, Name, null);
        }
        
        /// <remarks/>
        public void GetContactPersonAsync(string Email, string ERPID, string Name, object userState) {
            if ((this.GetContactPersonOperationCompleted == null)) {
                this.GetContactPersonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetContactPersonOperationCompleted);
            }
            this.InvokeAsync("GetContactPerson", new object[] {
                        Email,
                        ERPID,
                        Name}, this.GetContactPersonOperationCompleted, userState);
        }
        
        private void OnGetContactPersonOperationCompleted(object arg) {
            if ((this.GetContactPersonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetContactPersonCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetBBCreditCardOrder", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetBBCreditCardOrder(string invNo, string soNo, string dnNo, string poNo, string org, string dateFrom, string dateTo, bool onlyInvoicedOrders, bool isCaptured, int rowCount) {
            this.Invoke("GetBBCreditCardOrder", new object[] {
                        invNo,
                        soNo,
                        dnNo,
                        poNo,
                        org,
                        dateFrom,
                        dateTo,
                        onlyInvoicedOrders,
                        isCaptured,
                        rowCount});
        }
        
        /// <remarks/>
        public void GetBBCreditCardOrderAsync(string invNo, string soNo, string dnNo, string poNo, string org, string dateFrom, string dateTo, bool onlyInvoicedOrders, bool isCaptured, int rowCount) {
            this.GetBBCreditCardOrderAsync(invNo, soNo, dnNo, poNo, org, dateFrom, dateTo, onlyInvoicedOrders, isCaptured, rowCount, null);
        }
        
        /// <remarks/>
        public void GetBBCreditCardOrderAsync(string invNo, string soNo, string dnNo, string poNo, string org, string dateFrom, string dateTo, bool onlyInvoicedOrders, bool isCaptured, int rowCount, object userState) {
            if ((this.GetBBCreditCardOrderOperationCompleted == null)) {
                this.GetBBCreditCardOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBBCreditCardOrderOperationCompleted);
            }
            this.InvokeAsync("GetBBCreditCardOrder", new object[] {
                        invNo,
                        soNo,
                        dnNo,
                        poNo,
                        org,
                        dateFrom,
                        dateTo,
                        onlyInvoicedOrders,
                        isCaptured,
                        rowCount}, this.GetBBCreditCardOrderOperationCompleted, userState);
        }
        
        private void OnGetBBCreditCardOrderOperationCompleted(object arg) {
            if ((this.GetBBCreditCardOrderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBBCreditCardOrderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CaptureBBCreditCardAuthorizedOrder", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CaptureBBCreditCardAuthorizedOrder(string selectedCapturedItems) {
            this.Invoke("CaptureBBCreditCardAuthorizedOrder", new object[] {
                        selectedCapturedItems});
        }
        
        /// <remarks/>
        public void CaptureBBCreditCardAuthorizedOrderAsync(string selectedCapturedItems) {
            this.CaptureBBCreditCardAuthorizedOrderAsync(selectedCapturedItems, null);
        }
        
        /// <remarks/>
        public void CaptureBBCreditCardAuthorizedOrderAsync(string selectedCapturedItems, object userState) {
            if ((this.CaptureBBCreditCardAuthorizedOrderOperationCompleted == null)) {
                this.CaptureBBCreditCardAuthorizedOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCaptureBBCreditCardAuthorizedOrderOperationCompleted);
            }
            this.InvokeAsync("CaptureBBCreditCardAuthorizedOrder", new object[] {
                        selectedCapturedItems}, this.CaptureBBCreditCardAuthorizedOrderOperationCompleted, userState);
        }
        
        private void OnCaptureBBCreditCardAuthorizedOrderOperationCompleted(object arg) {
            if ((this.CaptureBBCreditCardAuthorizedOrderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CaptureBBCreditCardAuthorizedOrderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AssociateSiebelSAPAccountContact", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AssociateSiebelSAPAccountContact(string OrderNo, string ERPID) {
            this.Invoke("AssociateSiebelSAPAccountContact", new object[] {
                        OrderNo,
                        ERPID});
        }
        
        /// <remarks/>
        public void AssociateSiebelSAPAccountContactAsync(string OrderNo, string ERPID) {
            this.AssociateSiebelSAPAccountContactAsync(OrderNo, ERPID, null);
        }
        
        /// <remarks/>
        public void AssociateSiebelSAPAccountContactAsync(string OrderNo, string ERPID, object userState) {
            if ((this.AssociateSiebelSAPAccountContactOperationCompleted == null)) {
                this.AssociateSiebelSAPAccountContactOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAssociateSiebelSAPAccountContactOperationCompleted);
            }
            this.InvokeAsync("AssociateSiebelSAPAccountContact", new object[] {
                        OrderNo,
                        ERPID}, this.AssociateSiebelSAPAccountContactOperationCompleted, userState);
        }
        
        private void OnAssociateSiebelSAPAccountContactOperationCompleted(object arg) {
            if ((this.AssociateSiebelSAPAccountContactCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AssociateSiebelSAPAccountContactCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2117.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class WebServiceResult {
        
        private string orderNoField;
        
        private bool resultField;
        
        private string messageField;
        
        /// <remarks/>
        public string OrderNo {
            get {
                return this.orderNoField;
            }
            set {
                this.orderNoField = value;
            }
        }
        
        /// <remarks/>
        public bool Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2117.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BBCustomer {
        
        private string customerIDField;
        
        private string orgIDField;
        
        private string userIDField;
        
        private string netTermField;
        
        private string incotermTextField;
        
        /// <remarks/>
        public string CustomerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
            }
        }
        
        /// <remarks/>
        public string OrgID {
            get {
                return this.orgIDField;
            }
            set {
                this.orgIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        public string NetTerm {
            get {
                return this.netTermField;
            }
            set {
                this.netTermField = value;
            }
        }
        
        /// <remarks/>
        public string IncotermText {
            get {
                return this.incotermTextField;
            }
            set {
                this.incotermTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void GetBBorderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void CreateSAPOrderFromBBeStoreCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void ProcessCompletedEventHandler(object sender, ProcessCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProcessCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProcessCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WebServiceResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WebServiceResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void GetERPIDbyEmailCompletedEventHandler(object sender, GetERPIDbyEmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetERPIDbyEmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetERPIDbyEmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public BBCustomer Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((BBCustomer)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void GetIncotermTextByERPIDCompletedEventHandler(object sender, GetIncotermTextByERPIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIncotermTextByERPIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetIncotermTextByERPIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void AutoMaticallyTransfereStoreOrderToSAPCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void SynceStoreOrderToSAPCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void GetContactPersonCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void GetBBCreditCardOrderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void CaptureBBCreditCardAuthorizedOrderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void AssociateSiebelSAPAccountContactCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591