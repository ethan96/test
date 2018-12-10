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
    public partial class DMF
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string DMFID
        {
            get;
            set;
        }
    
        public virtual string ContactEmail
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

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (DMFID == null) {
						 error_message.Add(new ErrorMessage("DMFID", "DMFID can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(DMF); // Get type pointer
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
    
        public virtual ICollection<DMFTerrority> DMFTerrorities
        {
            get
            {
                if (_dMFTerrorities == null)
                {
                    var newCollection = new FixupCollection<DMFTerrority>();
                    newCollection.CollectionChanged += FixupDMFTerrorities;
                    _dMFTerrorities = newCollection;
                }
                return _dMFTerrorities;
            }
            set
            {
                if (!ReferenceEquals(_dMFTerrorities, value))
                {
                    var previousValue = _dMFTerrorities as FixupCollection<DMFTerrority>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupDMFTerrorities;
                    }
                    _dMFTerrorities = value;
                    var newValue = value as FixupCollection<DMFTerrority>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupDMFTerrorities;
                    }
                }
            }
        }
        private ICollection<DMFTerrority> _dMFTerrorities;
    
        public virtual ICollection<Store> Stores
        {
            get
            {
                if (_stores == null)
                {
                    var newCollection = new FixupCollection<Store>();
                    newCollection.CollectionChanged += FixupStores;
                    _stores = newCollection;
                }
                return _stores;
            }
            set
            {
                if (!ReferenceEquals(_stores, value))
                {
                    var previousValue = _stores as FixupCollection<Store>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupStores;
                    }
                    _stores = value;
                    var newValue = value as FixupCollection<Store>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupStores;
                    }
                }
            }
        }
        private ICollection<Store> _stores;
    
        public virtual ICollection<AdminRole> AdminRoles
        {
            get
            {
                if (_adminRoles == null)
                {
                    var newCollection = new FixupCollection<AdminRole>();
                    newCollection.CollectionChanged += FixupAdminRoles;
                    _adminRoles = newCollection;
                }
                return _adminRoles;
            }
            set
            {
                if (!ReferenceEquals(_adminRoles, value))
                {
                    var previousValue = _adminRoles as FixupCollection<AdminRole>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAdminRoles;
                    }
                    _adminRoles = value;
                    var newValue = value as FixupCollection<AdminRole>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAdminRoles;
                    }
                }
            }
        }
        private ICollection<AdminRole> _adminRoles;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupStore(Store previousValue)
        {
            if (previousValue != null && previousValue.DMFs.Contains(this))
            {
                previousValue.DMFs.Remove(this);
            }
    
            if (Store != null)
            {
                if (!Store.DMFs.Contains(this))
                {
                    Store.DMFs.Add(this);
                }
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
    
        private void FixupDMFTerrorities(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (DMFTerrority item in e.NewItems)
                {
                    item.DMF = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (DMFTerrority item in e.OldItems)
                {
                    if (ReferenceEquals(item.DMF, this))
                    {
                        item.DMF = null;
                    }
                }
            }
        }
    
        private void FixupStores(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Store item in e.NewItems)
                {
                    item.DMF = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Store item in e.OldItems)
                {
                    if (ReferenceEquals(item.DMF, this))
                    {
                        item.DMF = null;
                    }
                }
            }
        }
    
        private void FixupAdminRoles(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (AdminRole item in e.NewItems)
                {
                    item.DMF = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (AdminRole item in e.OldItems)
                {
                    if (ReferenceEquals(item.DMF, this))
                    {
                        item.DMF = null;
                    }
                }
            }
        }

        #endregion

    }
}
