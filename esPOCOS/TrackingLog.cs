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
    public partial class TrackingLog
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int LogId
        {
            get;
            set;
        }
    
        public virtual string StoreID
        {
            get { return _storeID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_storeID != value)
                    {
                        if (Store != null && Store.StoreID != value)
                        {
                            Store = null;
                        }
                        _storeID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _storeID;
    
        public virtual string TrackingNo
        {
            get;
            set;
        }
    
        public virtual string TrackingType
        {
            get;
            set;
        }
    
        public virtual string UserID
        {
            get;
            set;
        }
    
        public virtual string Activity
        {
            get;
            set;
        }
    
        public virtual string AssignTo
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> AssignToCP
        {
            get;
            set;
        }
    
        public virtual string FollowUpStatus
        {
            get;
            set;
        }
    
        public virtual string FollowUpComments
        {
            get;
            set;
        }
    
        public virtual string LastUpdateBy
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LastUpdated
        {
            get;
            set;
        }
    
        public virtual string RowID
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
            Type type = typeof(TrackingLog); // Get type pointer
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
    
        private bool _settingFK = false;
    
        private void FixupStore(Store previousValue)
        {
            if (Store != null)
            {
                if (StoreID != Store.StoreID)
                {
                    StoreID = Store.StoreID;
                }
            }
            else if (!_settingFK)
            {
                StoreID = null;
            }
        }

        #endregion

    }
}
