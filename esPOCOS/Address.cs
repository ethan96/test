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
    public partial class Address
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int AddressID
        {
            get;
            set;
        }
    
        public virtual string Address1
        {
            get;
            set;
        }
    
        public virtual string Address2
        {
            get;
            set;
        }
    
        public virtual string City
        {
            get;
            set;
        }
    
        public virtual string State
        {
            get;
            set;
        }
    
        public virtual string Country
        {
            get;
            set;
        }
    
        public virtual string ZipCode
        {
            get;
            set;
        }
    
        public virtual string Tel
        {
            get;
            set;
        }
    
        public virtual string ServiceTime
        {
            get;
            set;
        }
    
        public virtual string BankInformation
        {
            get;
            set;
        }
    
        public virtual string EmailGroup
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> Exclusive
        {
            get;
            set;
        }
    
        public virtual string Fax
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (Country == null) {
						 error_message.Add(new ErrorMessage("Country", "Country can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(Address); // Get type pointer
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
    
        public virtual ICollection<Store> Stores1
        {
            get
            {
                if (_stores1 == null)
                {
                    var newCollection = new FixupCollection<Store>();
                    newCollection.CollectionChanged += FixupStores1;
                    _stores1 = newCollection;
                }
                return _stores1;
            }
            set
            {
                if (!ReferenceEquals(_stores1, value))
                {
                    var previousValue = _stores1 as FixupCollection<Store>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupStores1;
                    }
                    _stores1 = value;
                    var newValue = value as FixupCollection<Store>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupStores1;
                    }
                }
            }
        }
        private ICollection<Store> _stores1;
    
        public virtual ICollection<StoreAddress> StoreAddresses
        {
            get
            {
                if (_storeAddresses == null)
                {
                    var newCollection = new FixupCollection<StoreAddress>();
                    newCollection.CollectionChanged += FixupStoreAddresses;
                    _storeAddresses = newCollection;
                }
                return _storeAddresses;
            }
            set
            {
                if (!ReferenceEquals(_storeAddresses, value))
                {
                    var previousValue = _storeAddresses as FixupCollection<StoreAddress>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupStoreAddresses;
                    }
                    _storeAddresses = value;
                    var newValue = value as FixupCollection<StoreAddress>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupStoreAddresses;
                    }
                }
            }
        }
        private ICollection<StoreAddress> _storeAddresses;
    
        public virtual ICollection<CountryAddress> CountryAddresses
        {
            get
            {
                if (_countryAddresses == null)
                {
                    var newCollection = new FixupCollection<CountryAddress>();
                    newCollection.CollectionChanged += FixupCountryAddresses;
                    _countryAddresses = newCollection;
                }
                return _countryAddresses;
            }
            set
            {
                if (!ReferenceEquals(_countryAddresses, value))
                {
                    var previousValue = _countryAddresses as FixupCollection<CountryAddress>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCountryAddresses;
                    }
                    _countryAddresses = value;
                    var newValue = value as FixupCollection<CountryAddress>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCountryAddresses;
                    }
                }
            }
        }
        private ICollection<CountryAddress> _countryAddresses;

        #endregion

        #region Association Fixup
    
        private void FixupStores(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Store item in e.NewItems)
                {
                    item.ShipFromAddress = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Store item in e.OldItems)
                {
                    if (ReferenceEquals(item.ShipFromAddress, this))
                    {
                        item.ShipFromAddress = null;
                    }
                }
            }
        }
    
        private void FixupStores1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Store item in e.NewItems)
                {
                    item.DropShipAddress = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Store item in e.OldItems)
                {
                    if (ReferenceEquals(item.DropShipAddress, this))
                    {
                        item.DropShipAddress = null;
                    }
                }
            }
        }
    
        private void FixupStoreAddresses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (StoreAddress item in e.NewItems)
                {
                    item.Address = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (StoreAddress item in e.OldItems)
                {
                    if (ReferenceEquals(item.Address, this))
                    {
                        item.Address = null;
                    }
                }
            }
        }
    
        private void FixupCountryAddresses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CountryAddress item in e.NewItems)
                {
                    item.Address = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CountryAddress item in e.OldItems)
                {
                    if (ReferenceEquals(item.Address, this))
                    {
                        item.Address = null;
                    }
                }
            }
        }

        #endregion

    }
}
