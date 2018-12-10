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
    public partial class OrderSyncParameter
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string StoreID
        {
            get { return _storeID; }
            set
            {
                if (_storeID != value)
                {
                    if (Store != null && Store.StoreID != value)
                    {
                        Store = null;
                    }
                    _storeID = value;
                }
            }
        }
        private string _storeID;
    
        public virtual string Parameter
        {
            get;
            set;
        }
    
        public virtual string ShowText
        {
            get;
            set;
        }
    
        public virtual string Value
        {
            get;
            set;
        }
    
        public virtual int id
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ParameterSeq
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (StoreID == null) {
						 error_message.Add(new ErrorMessage("StoreID", "StoreID can not be Null "));
				}
		 if (Parameter == null) {
						 error_message.Add(new ErrorMessage("Parameter", "Parameter can not be Null "));
				}
		 if (Value == null) {
						 error_message.Add(new ErrorMessage("Value", "Value can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(OrderSyncParameter); // Get type pointer
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
            if (previousValue != null && previousValue.OrderSyncParameters.Contains(this))
            {
                previousValue.OrderSyncParameters.Remove(this);
            }
    
            if (Store != null)
            {
                if (!Store.OrderSyncParameters.Contains(this))
                {
                    Store.OrderSyncParameters.Add(this);
                }
                if (StoreID != Store.StoreID)
                {
                    StoreID = Store.StoreID;
                }
            }
        }

        #endregion

    }
}