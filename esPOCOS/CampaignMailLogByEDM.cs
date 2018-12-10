//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using eStore.POCOS.PocoX;
 

namespace eStore.POCOS
{
    public partial class CampaignMailLogByEDM
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int CampaignID
        {
            get;
            set;
        }
    
        public virtual string UserId
        {
            get;
            set;
        }
    
        public virtual string EdmCode
        {
            get { return _edmCode; }
            set
            {
                if (_edmCode != value)
                {
                    if (EDMCodeMapping != null && EDMCodeMapping.EdmCode != value)
                    {
                        EDMCodeMapping = null;
                    }
                    _edmCode = value;
                }
            }
        }
        private string _edmCode;
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual System.DateTime CreateDate
        {
            get;
            set;
        }
    
        public virtual string Storeid
        {
            get;
            set;
        }
    
        public virtual string PromotionCode
        {
            get;
            set;
        }
    
        public virtual Nullable<int> IsCheck
        {
            get;
            set;
        }
    
        public virtual string MailLogId
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (UserId == null) {
						 error_message.Add(new ErrorMessage("UserId", "UserId can not be Null "));
				}
		 if (EdmCode == null) {
						 error_message.Add(new ErrorMessage("EdmCode", "EdmCode can not be Null "));
				}
		 if (Storeid == null) {
						 error_message.Add(new ErrorMessage("Storeid", "Storeid can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(CampaignMailLogByEDM); // Get type pointer
             PropertyInfo[] fields = type.GetProperties(); // Obtain all fields
                foreach (var pinfo in fields) // Loop through fields
                {
                    string name = pinfo.Name; // Get string name
                    object temp = pinfo.GetValue(pinfo.Name,null); // Get value
                if (temp is int) // See if it is an integer.
                {
                    int value = (int)temp;
                    Console.Write(name);
                    Console.Write(" (int) = ");
                    Console.WriteLine(value);
                }
                else if (temp is string) // See if it is a string.
                {
                    string value = temp as string;
                    Console.Write(name);
                    Console.Write(" (string) = ");
                    Console.WriteLine(value);
                }
            }
        }*/
     
    	
    	
        #endregion

        #region Navigation Properties
    
        public virtual EDMCodeMapping EDMCodeMapping
        {
            get { return _eDMCodeMapping; }
            set
            {
                if (!ReferenceEquals(_eDMCodeMapping, value))
                {
                    var previousValue = _eDMCodeMapping;
                    _eDMCodeMapping = value;
                    FixupEDMCodeMapping(previousValue);
                }
            }
        }
        private EDMCodeMapping _eDMCodeMapping;

        #endregion

        #region Association Fixup
    
        private void FixupEDMCodeMapping(EDMCodeMapping previousValue)
        {
            if (previousValue != null && previousValue.CampaignMailLogByEDMs.Contains(this))
            {
                previousValue.CampaignMailLogByEDMs.Remove(this);
            }
    
            if (EDMCodeMapping != null)
            {
                if (!EDMCodeMapping.CampaignMailLogByEDMs.Contains(this))
                {
                    EDMCodeMapping.CampaignMailLogByEDMs.Add(this);
                }
                if (EdmCode != EDMCodeMapping.EdmCode)
                {
                    EdmCode = EDMCodeMapping.EdmCode;
                }
            }
        }

        #endregion

    }
}