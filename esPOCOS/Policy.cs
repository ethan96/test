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
    public partial class Policy
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
    
        public virtual System.DateTime CreatedDate
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get;
            set;
        }
    
        public virtual string LastUpdateBy
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LastUpdateDate
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string HtmlContext
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
		 if (CreatedBy == null) {
						 error_message.Add(new ErrorMessage("CreatedBy", "CreatedBy can not be Null "));
				}
		 if (Name == null) {
						 error_message.Add(new ErrorMessage("Name", "Name can not be Null "));
				}
		 if (HtmlContext == null) {
						 error_message.Add(new ErrorMessage("HtmlContext", "HtmlContext can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(Policy); // Get type pointer
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
    
        public virtual ICollection<PolicyCategory> PolicyCategories
        {
            get
            {
                if (_policyCategories == null)
                {
                    var newCollection = new FixupCollection<PolicyCategory>();
                    newCollection.CollectionChanged += FixupPolicyCategories;
                    _policyCategories = newCollection;
                }
                return _policyCategories;
            }
            set
            {
                if (!ReferenceEquals(_policyCategories, value))
                {
                    var previousValue = _policyCategories as FixupCollection<PolicyCategory>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPolicyCategories;
                    }
                    _policyCategories = value;
                    var newValue = value as FixupCollection<PolicyCategory>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPolicyCategories;
                    }
                }
            }
        }
        private ICollection<PolicyCategory> _policyCategories;
    
        public virtual ICollection<PolicyGlobalResource> PolicyGlobalResources
        {
            get
            {
                if (_policyGlobalResources == null)
                {
                    var newCollection = new FixupCollection<PolicyGlobalResource>();
                    newCollection.CollectionChanged += FixupPolicyGlobalResources;
                    _policyGlobalResources = newCollection;
                }
                return _policyGlobalResources;
            }
            set
            {
                if (!ReferenceEquals(_policyGlobalResources, value))
                {
                    var previousValue = _policyGlobalResources as FixupCollection<PolicyGlobalResource>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPolicyGlobalResources;
                    }
                    _policyGlobalResources = value;
                    var newValue = value as FixupCollection<PolicyGlobalResource>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPolicyGlobalResources;
                    }
                }
            }
        }
        private ICollection<PolicyGlobalResource> _policyGlobalResources;

        #endregion

        #region Association Fixup
    
        private void FixupStore(Store previousValue)
        {
            if (previousValue != null && previousValue.Policies.Contains(this))
            {
                previousValue.Policies.Remove(this);
            }
    
            if (Store != null)
            {
                if (!Store.Policies.Contains(this))
                {
                    Store.Policies.Add(this);
                }
                if (StoreID != Store.StoreID)
                {
                    StoreID = Store.StoreID;
                }
            }
        }
    
        private void FixupPolicyCategories(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PolicyCategory item in e.NewItems)
                {
                    item.Policy = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PolicyCategory item in e.OldItems)
                {
                    if (ReferenceEquals(item.Policy, this))
                    {
                        item.Policy = null;
                    }
                }
            }
        }
    
        private void FixupPolicyGlobalResources(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PolicyGlobalResource item in e.NewItems)
                {
                    item.Policy = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PolicyGlobalResource item in e.OldItems)
                {
                    if (ReferenceEquals(item.Policy, this))
                    {
                        item.Policy = null;
                    }
                }
            }
        }

        #endregion

    }
}