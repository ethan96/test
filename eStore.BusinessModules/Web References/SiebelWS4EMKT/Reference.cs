﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace eStore.BusinessModules.SiebelWS4EMKT {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS4EMKTSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ROOT))]
    public partial class WS4EMKT : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddActionOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddSROperationCompleted;
        
        private System.Threading.SendOrPostCallback AddContactOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddOpptyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS4EMKT() {
            this.Url = global::eStore.BusinessModules.Properties.Settings.Default.eStore_BusinessModules_SiebelWS4EMKT_WS4EMKT;
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
        public event AddActionCompletedEventHandler AddActionCompleted;
        
        /// <remarks/>
        public event AddSRCompletedEventHandler AddSRCompleted;
        
        /// <remarks/>
        public event AddContactCompletedEventHandler AddContactCompleted;
        
        /// <remarks/>
        public event AddOpptyCompletedEventHandler AddOpptyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddAction", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT AddAction(EMPLOYEE EMP, ACTION ACT) {
            object[] results = this.Invoke("AddAction", new object[] {
                        EMP,
                        ACT});
            return ((RESULT)(results[0]));
        }
        
        /// <remarks/>
        public void AddActionAsync(EMPLOYEE EMP, ACTION ACT) {
            this.AddActionAsync(EMP, ACT, null);
        }
        
        /// <remarks/>
        public void AddActionAsync(EMPLOYEE EMP, ACTION ACT, object userState) {
            if ((this.AddActionOperationCompleted == null)) {
                this.AddActionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddActionOperationCompleted);
            }
            this.InvokeAsync("AddAction", new object[] {
                        EMP,
                        ACT}, this.AddActionOperationCompleted, userState);
        }
        
        private void OnAddActionOperationCompleted(object arg) {
            if ((this.AddActionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddActionCompleted(this, new AddActionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddSR", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT AddSR(EMPLOYEE EMP, SVC_REQ SR) {
            object[] results = this.Invoke("AddSR", new object[] {
                        EMP,
                        SR});
            return ((RESULT)(results[0]));
        }
        
        /// <remarks/>
        public void AddSRAsync(EMPLOYEE EMP, SVC_REQ SR) {
            this.AddSRAsync(EMP, SR, null);
        }
        
        /// <remarks/>
        public void AddSRAsync(EMPLOYEE EMP, SVC_REQ SR, object userState) {
            if ((this.AddSROperationCompleted == null)) {
                this.AddSROperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddSROperationCompleted);
            }
            this.InvokeAsync("AddSR", new object[] {
                        EMP,
                        SR}, this.AddSROperationCompleted, userState);
        }
        
        private void OnAddSROperationCompleted(object arg) {
            if ((this.AddSRCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddSRCompleted(this, new AddSRCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddContact", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT AddContact(EMPLOYEE EMP, CONTACT CON) {
            object[] results = this.Invoke("AddContact", new object[] {
                        EMP,
                        CON});
            return ((RESULT)(results[0]));
        }
        
        /// <remarks/>
        public void AddContactAsync(EMPLOYEE EMP, CONTACT CON) {
            this.AddContactAsync(EMP, CON, null);
        }
        
        /// <remarks/>
        public void AddContactAsync(EMPLOYEE EMP, CONTACT CON, object userState) {
            if ((this.AddContactOperationCompleted == null)) {
                this.AddContactOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddContactOperationCompleted);
            }
            this.InvokeAsync("AddContact", new object[] {
                        EMP,
                        CON}, this.AddContactOperationCompleted, userState);
        }
        
        private void OnAddContactOperationCompleted(object arg) {
            if ((this.AddContactCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddContactCompleted(this, new AddContactCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddOppty", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT AddOppty(EMPLOYEE EMP, OPPTY OPPTY) {
            object[] results = this.Invoke("AddOppty", new object[] {
                        EMP,
                        OPPTY});
            return ((RESULT)(results[0]));
        }
        
        /// <remarks/>
        public void AddOpptyAsync(EMPLOYEE EMP, OPPTY OPPTY) {
            this.AddOpptyAsync(EMP, OPPTY, null);
        }
        
        /// <remarks/>
        public void AddOpptyAsync(EMPLOYEE EMP, OPPTY OPPTY, object userState) {
            if ((this.AddOpptyOperationCompleted == null)) {
                this.AddOpptyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOpptyOperationCompleted);
            }
            this.InvokeAsync("AddOppty", new object[] {
                        EMP,
                        OPPTY}, this.AddOpptyOperationCompleted, userState);
        }
        
        private void OnAddOpptyOperationCompleted(object arg) {
            if ((this.AddOpptyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddOpptyCompleted(this, new AddOpptyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EMPLOYEE {
        
        private string rOW_IDField;
        
        private string uSER_IDField;
        
        private string pASSWORDField;
        
        private string oRGField;
        
        private string pOS_IDField;
        
        private string jOB_TITLEField;
        
        private string aLIASField;
        
        private string fST_NAMEField;
        
        private string lST_NAMEField;
        
        private string eMAILField;
        
        /// <remarks/>
        public string ROW_ID {
            get {
                return this.rOW_IDField;
            }
            set {
                this.rOW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string USER_ID {
            get {
                return this.uSER_IDField;
            }
            set {
                this.uSER_IDField = value;
            }
        }
        
        /// <remarks/>
        public string PASSWORD {
            get {
                return this.pASSWORDField;
            }
            set {
                this.pASSWORDField = value;
            }
        }
        
        /// <remarks/>
        public string ORG {
            get {
                return this.oRGField;
            }
            set {
                this.oRGField = value;
            }
        }
        
        /// <remarks/>
        public string POS_ID {
            get {
                return this.pOS_IDField;
            }
            set {
                this.pOS_IDField = value;
            }
        }
        
        /// <remarks/>
        public string JOB_TITLE {
            get {
                return this.jOB_TITLEField;
            }
            set {
                this.jOB_TITLEField = value;
            }
        }
        
        /// <remarks/>
        public string ALIAS {
            get {
                return this.aLIASField;
            }
            set {
                this.aLIASField = value;
            }
        }
        
        /// <remarks/>
        public string FST_NAME {
            get {
                return this.fST_NAMEField;
            }
            set {
                this.fST_NAMEField = value;
            }
        }
        
        /// <remarks/>
        public string LST_NAME {
            get {
                return this.lST_NAMEField;
            }
            set {
                this.lST_NAMEField = value;
            }
        }
        
        /// <remarks/>
        public string EMAIL {
            get {
                return this.eMAILField;
            }
            set {
                this.eMAILField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class OPPTY {
        
        private string oRGField;
        
        private string pRI_POS_IDField;
        
        private string aCC_ROW_IDField;
        
        private string cON_ROW_IDField;
        
        private string pROJ_NAMEField;
        
        private string dESPField;
        
        private string cHANNELField;
        
        private string bIZ_GROUPField;
        
        private string sALES_METHODField;
        
        private string sALES_STAGEField;
        
        private string sRC_IDField;
        
        private System.DateTime cLOSE_DATEField;
        
        private int rEVENUEField;
        
        private string sTATUSField;
        
        private string pROGRAMField;
        
        private string sUPPORT_REQUESTField;
        
        private string sUCCESS_FACTORField;
        
        private string rEASON_WON_LOSTField;
        
        private string lEAD_QUALITYField;
        
        private bool iS_ASSIGN_TO_PARTNERField;
        
        private string pARTNER_ROW_IDField;
        
        private string cURRENCY_CODEField;
        
        private string oWNER_EMAILField;
        
        /// <remarks/>
        public string ORG {
            get {
                return this.oRGField;
            }
            set {
                this.oRGField = value;
            }
        }
        
        /// <remarks/>
        public string PRI_POS_ID {
            get {
                return this.pRI_POS_IDField;
            }
            set {
                this.pRI_POS_IDField = value;
            }
        }
        
        /// <remarks/>
        public string ACC_ROW_ID {
            get {
                return this.aCC_ROW_IDField;
            }
            set {
                this.aCC_ROW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string CON_ROW_ID {
            get {
                return this.cON_ROW_IDField;
            }
            set {
                this.cON_ROW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string PROJ_NAME {
            get {
                return this.pROJ_NAMEField;
            }
            set {
                this.pROJ_NAMEField = value;
            }
        }
        
        /// <remarks/>
        public string DESP {
            get {
                return this.dESPField;
            }
            set {
                this.dESPField = value;
            }
        }
        
        /// <remarks/>
        public string CHANNEL {
            get {
                return this.cHANNELField;
            }
            set {
                this.cHANNELField = value;
            }
        }
        
        /// <remarks/>
        public string BIZ_GROUP {
            get {
                return this.bIZ_GROUPField;
            }
            set {
                this.bIZ_GROUPField = value;
            }
        }
        
        /// <remarks/>
        public string SALES_METHOD {
            get {
                return this.sALES_METHODField;
            }
            set {
                this.sALES_METHODField = value;
            }
        }
        
        /// <remarks/>
        public string SALES_STAGE {
            get {
                return this.sALES_STAGEField;
            }
            set {
                this.sALES_STAGEField = value;
            }
        }
        
        /// <remarks/>
        public string SRC_ID {
            get {
                return this.sRC_IDField;
            }
            set {
                this.sRC_IDField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CLOSE_DATE {
            get {
                return this.cLOSE_DATEField;
            }
            set {
                this.cLOSE_DATEField = value;
            }
        }
        
        /// <remarks/>
        public int REVENUE {
            get {
                return this.rEVENUEField;
            }
            set {
                this.rEVENUEField = value;
            }
        }
        
        /// <remarks/>
        public string STATUS {
            get {
                return this.sTATUSField;
            }
            set {
                this.sTATUSField = value;
            }
        }
        
        /// <remarks/>
        public string PROGRAM {
            get {
                return this.pROGRAMField;
            }
            set {
                this.pROGRAMField = value;
            }
        }
        
        /// <remarks/>
        public string SUPPORT_REQUEST {
            get {
                return this.sUPPORT_REQUESTField;
            }
            set {
                this.sUPPORT_REQUESTField = value;
            }
        }
        
        /// <remarks/>
        public string SUCCESS_FACTOR {
            get {
                return this.sUCCESS_FACTORField;
            }
            set {
                this.sUCCESS_FACTORField = value;
            }
        }
        
        /// <remarks/>
        public string REASON_WON_LOST {
            get {
                return this.rEASON_WON_LOSTField;
            }
            set {
                this.rEASON_WON_LOSTField = value;
            }
        }
        
        /// <remarks/>
        public string LEAD_QUALITY {
            get {
                return this.lEAD_QUALITYField;
            }
            set {
                this.lEAD_QUALITYField = value;
            }
        }
        
        /// <remarks/>
        public bool IS_ASSIGN_TO_PARTNER {
            get {
                return this.iS_ASSIGN_TO_PARTNERField;
            }
            set {
                this.iS_ASSIGN_TO_PARTNERField = value;
            }
        }
        
        /// <remarks/>
        public string PARTNER_ROW_ID {
            get {
                return this.pARTNER_ROW_IDField;
            }
            set {
                this.pARTNER_ROW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string CURRENCY_CODE {
            get {
                return this.cURRENCY_CODEField;
            }
            set {
                this.cURRENCY_CODEField = value;
            }
        }
        
        /// <remarks/>
        public string OWNER_EMAIL {
            get {
                return this.oWNER_EMAILField;
            }
            set {
                this.oWNER_EMAILField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CONTACT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SVC_REQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ROOT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CONTACT : ROOT {
        
        private string rOW_IDField;
        
        private string aCC_ROW_IDField;
        
        private string fST_NAMEField;
        
        private string lST_NAMEField;
        
        private string eMAILField;
        
        private string wORK_PHONEField;
        
        private string fAX_PHONEField;
        
        private string uSER_TYPEField;
        
        private string jOB_TITLEField;
        
        private string cMTField;
        
        private string dATA_SRCField;
        
        private bool iS_NEVER_EMAILField;
        
        private bool iS_EMPLOYEEField;
        
        private string oWNER_EMAILField;
        
        private string[] lIST_IPField;
        
        private string oRGField;
        
        /// <remarks/>
        public string ROW_ID {
            get {
                return this.rOW_IDField;
            }
            set {
                this.rOW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string ACC_ROW_ID {
            get {
                return this.aCC_ROW_IDField;
            }
            set {
                this.aCC_ROW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string FST_NAME {
            get {
                return this.fST_NAMEField;
            }
            set {
                this.fST_NAMEField = value;
            }
        }
        
        /// <remarks/>
        public string LST_NAME {
            get {
                return this.lST_NAMEField;
            }
            set {
                this.lST_NAMEField = value;
            }
        }
        
        /// <remarks/>
        public string EMAIL {
            get {
                return this.eMAILField;
            }
            set {
                this.eMAILField = value;
            }
        }
        
        /// <remarks/>
        public string WORK_PHONE {
            get {
                return this.wORK_PHONEField;
            }
            set {
                this.wORK_PHONEField = value;
            }
        }
        
        /// <remarks/>
        public string FAX_PHONE {
            get {
                return this.fAX_PHONEField;
            }
            set {
                this.fAX_PHONEField = value;
            }
        }
        
        /// <remarks/>
        public string USER_TYPE {
            get {
                return this.uSER_TYPEField;
            }
            set {
                this.uSER_TYPEField = value;
            }
        }
        
        /// <remarks/>
        public string JOB_TITLE {
            get {
                return this.jOB_TITLEField;
            }
            set {
                this.jOB_TITLEField = value;
            }
        }
        
        /// <remarks/>
        public string CMT {
            get {
                return this.cMTField;
            }
            set {
                this.cMTField = value;
            }
        }
        
        /// <remarks/>
        public string DATA_SRC {
            get {
                return this.dATA_SRCField;
            }
            set {
                this.dATA_SRCField = value;
            }
        }
        
        /// <remarks/>
        public bool IS_NEVER_EMAIL {
            get {
                return this.iS_NEVER_EMAILField;
            }
            set {
                this.iS_NEVER_EMAILField = value;
            }
        }
        
        /// <remarks/>
        public bool IS_EMPLOYEE {
            get {
                return this.iS_EMPLOYEEField;
            }
            set {
                this.iS_EMPLOYEEField = value;
            }
        }
        
        /// <remarks/>
        public string OWNER_EMAIL {
            get {
                return this.oWNER_EMAILField;
            }
            set {
                this.oWNER_EMAILField = value;
            }
        }
        
        /// <remarks/>
        public string[] LIST_IP {
            get {
                return this.lIST_IPField;
            }
            set {
                this.lIST_IPField = value;
            }
        }
        
        /// <remarks/>
        public string ORG {
            get {
                return this.oRGField;
            }
            set {
                this.oRGField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SVC_REQ : ROOT {
        
        private string fUNCTIONField;
        
        private string aBSTRACTField;
        
        private string dESPField;
        
        private string cONTACT_EMAILField;
        
        private string mODELField;
        
        private string oWNER_EMAILField;
        
        private string oRGField;
        
        /// <remarks/>
        public string FUNCTION {
            get {
                return this.fUNCTIONField;
            }
            set {
                this.fUNCTIONField = value;
            }
        }
        
        /// <remarks/>
        public string ABSTRACT {
            get {
                return this.aBSTRACTField;
            }
            set {
                this.aBSTRACTField = value;
            }
        }
        
        /// <remarks/>
        public string DESP {
            get {
                return this.dESPField;
            }
            set {
                this.dESPField = value;
            }
        }
        
        /// <remarks/>
        public string CONTACT_EMAIL {
            get {
                return this.cONTACT_EMAILField;
            }
            set {
                this.cONTACT_EMAILField = value;
            }
        }
        
        /// <remarks/>
        public string MODEL {
            get {
                return this.mODELField;
            }
            set {
                this.mODELField = value;
            }
        }
        
        /// <remarks/>
        public string OWNER_EMAIL {
            get {
                return this.oWNER_EMAILField;
            }
            set {
                this.oWNER_EMAILField = value;
            }
        }
        
        /// <remarks/>
        public string ORG {
            get {
                return this.oRGField;
            }
            set {
                this.oRGField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RESULT {
        
        private string rOW_IDField;
        
        private string eRR_MSGField;
        
        private bool iS_COMMITTEDField;
        
        private bool iS_DUPEField;
        
        private bool iS_EMPLOYEEField;
        
        /// <remarks/>
        public string ROW_ID {
            get {
                return this.rOW_IDField;
            }
            set {
                this.rOW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string ERR_MSG {
            get {
                return this.eRR_MSGField;
            }
            set {
                this.eRR_MSGField = value;
            }
        }
        
        /// <remarks/>
        public bool IS_COMMITTED {
            get {
                return this.iS_COMMITTEDField;
            }
            set {
                this.iS_COMMITTEDField = value;
            }
        }
        
        /// <remarks/>
        public bool IS_DUPE {
            get {
                return this.iS_DUPEField;
            }
            set {
                this.iS_DUPEField = value;
            }
        }
        
        /// <remarks/>
        public bool IS_EMPLOYEE {
            get {
                return this.iS_EMPLOYEEField;
            }
            set {
                this.iS_EMPLOYEEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ACTION {
        
        private string cON_ROW_IDField;
        
        private string sRC_ROW_IDField;
        
        private string aCT_TYPEField;
        
        private string dESPField;
        
        private string sTATUSField;
        
        private string cMTField;
        
        private string cON_EMAILField;
        
        private string oWNER_EMAILField;
        
        private string oRGField;
        
        /// <remarks/>
        public string CON_ROW_ID {
            get {
                return this.cON_ROW_IDField;
            }
            set {
                this.cON_ROW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string SRC_ROW_ID {
            get {
                return this.sRC_ROW_IDField;
            }
            set {
                this.sRC_ROW_IDField = value;
            }
        }
        
        /// <remarks/>
        public string ACT_TYPE {
            get {
                return this.aCT_TYPEField;
            }
            set {
                this.aCT_TYPEField = value;
            }
        }
        
        /// <remarks/>
        public string DESP {
            get {
                return this.dESPField;
            }
            set {
                this.dESPField = value;
            }
        }
        
        /// <remarks/>
        public string STATUS {
            get {
                return this.sTATUSField;
            }
            set {
                this.sTATUSField = value;
            }
        }
        
        /// <remarks/>
        public string CMT {
            get {
                return this.cMTField;
            }
            set {
                this.cMTField = value;
            }
        }
        
        /// <remarks/>
        public string CON_EMAIL {
            get {
                return this.cON_EMAILField;
            }
            set {
                this.cON_EMAILField = value;
            }
        }
        
        /// <remarks/>
        public string OWNER_EMAIL {
            get {
                return this.oWNER_EMAILField;
            }
            set {
                this.oWNER_EMAILField = value;
            }
        }
        
        /// <remarks/>
        public string ORG {
            get {
                return this.oRGField;
            }
            set {
                this.oRGField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddActionCompletedEventHandler(object sender, AddActionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddActionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddActionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddSRCompletedEventHandler(object sender, AddSRCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddSRCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddSRCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddContactCompletedEventHandler(object sender, AddContactCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddContactCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddContactCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddOpptyCompletedEventHandler(object sender, AddOpptyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddOpptyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddOpptyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591