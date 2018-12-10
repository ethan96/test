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
    public partial class SpecialProductPrice
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string StoreId
        {
            get { return _storeId; }
            set
            {
                if (_storeId != value)
                {
                    if (Store != null && Store.StoreID != value)
                    {
                        Store = null;
                    }
                    _storeId = value;
                }
            }
        }
        private string _storeId;
    
        public virtual string Rule
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> FixRate
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual string RuleType
        {
            get;
            set;
        }
    
        public virtual int Id
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (StoreId == null) {
						 error_message.Add(new ErrorMessage("StoreId", "StoreId can not be Null "));
				}
		 if (Rule == null) {
						 error_message.Add(new ErrorMessage("Rule", "Rule can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(SpecialProductPrice); // Get type pointer
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
    
        public virtual Store Store
        {
            get { return _store; }
            set
            {
                if (!ReferenceEquals(_store, value))
                {
                    var previousValue = _store;
                    _store = value;
                    FixupStore(previousValue);
                }
            }
        }
        private Store _store;

        #endregion

        #region Association Fixup
    
        private void FixupStore(Store previousValue)
        {
            if (previousValue != null && previousValue.SpecialProductPrices.Contains(this))
            {
                previousValue.SpecialProductPrices.Remove(this);
            }
    
            if (Store != null)
            {
                if (!Store.SpecialProductPrices.Contains(this))
                {
                    Store.SpecialProductPrices.Add(this);
                }
                if (StoreId != Store.StoreID)
                {
                    StoreId = Store.StoreID;
                }
            }
        }

        #endregion

    }
}
