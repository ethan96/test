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
    public partial class ECOPartnerIndustry
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual Nullable<int> PartnerId
        {
            get { return _partnerId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_partnerId != value)
                    {
                        if (ECOPartner != null && ECOPartner.PartnerId != value)
                        {
                            ECOPartner = null;
                        }
                        _partnerId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _partnerId;
    
        public virtual Nullable<int> IndustryId
        {
            get { return _industryId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_industryId != value)
                    {
                        if (ECOIndustry != null && ECOIndustry.IndustryId != value)
                        {
                            ECOIndustry = null;
                        }
                        _industryId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _industryId;
    
        public virtual Nullable<System.DateTime> CreatedDate
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   
    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(ECOPartnerIndustry); // Get type pointer
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
    
        public virtual ECOIndustry ECOIndustry
        {
            get { return _eCOIndustry; }
            set
            {
                if (!ReferenceEquals(_eCOIndustry, value))
                {
                    var previousValue = _eCOIndustry;
                    _eCOIndustry = value;
                    FixupECOIndustry(previousValue);
                }
            }
        }
        private ECOIndustry _eCOIndustry;
    
        public virtual ECOPartner ECOPartner
        {
            get { return _eCOPartner; }
            set
            {
                if (!ReferenceEquals(_eCOPartner, value))
                {
                    var previousValue = _eCOPartner;
                    _eCOPartner = value;
                    FixupECOPartner(previousValue);
                }
            }
        }
        private ECOPartner _eCOPartner;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupECOIndustry(ECOIndustry previousValue)
        {
            if (previousValue != null && previousValue.ECOPartnerIndustries.Contains(this))
            {
                previousValue.ECOPartnerIndustries.Remove(this);
            }
    
            if (ECOIndustry != null)
            {
                if (!ECOIndustry.ECOPartnerIndustries.Contains(this))
                {
                    ECOIndustry.ECOPartnerIndustries.Add(this);
                }
                if (IndustryId != ECOIndustry.IndustryId)
                {
                    IndustryId = ECOIndustry.IndustryId;
                }
            }
            else if (!_settingFK)
            {
                IndustryId = null;
            }
        }
    
        private void FixupECOPartner(ECOPartner previousValue)
        {
            if (previousValue != null && previousValue.ECOPartnerIndustries.Contains(this))
            {
                previousValue.ECOPartnerIndustries.Remove(this);
            }
    
            if (ECOPartner != null)
            {
                if (!ECOPartner.ECOPartnerIndustries.Contains(this))
                {
                    ECOPartner.ECOPartnerIndustries.Add(this);
                }
                if (PartnerId != ECOPartner.PartnerId)
                {
                    PartnerId = ECOPartner.PartnerId;
                }
            }
            else if (!_settingFK)
            {
                PartnerId = null;
            }
        }

        #endregion

    }
}
