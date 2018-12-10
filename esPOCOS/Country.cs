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
    public partial class Country
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int CountryID
        {
            get;
            set;
        }
    
        public virtual string CountryName
        {
            get;
            set;
        }
    
        public virtual Nullable<int> PhoneCode
        {
            get;
            set;
        }
    
        public virtual string Shorts
        {
            get;
            set;
        }
    
        public virtual string Region
        {
            get;
            set;
        }
    
        public virtual string RBU
        {
            get;
            set;
        }
    
        public virtual string RepairCenter
        {
            get;
            set;
        }
    
        public virtual string DMF
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
    
        public virtual string RbuOM
        {
            get;
            set;
        }
    
        public virtual string ZoneCode
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> IsEC
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (CountryName == null) {
						 error_message.Add(new ErrorMessage("CountryName", "CountryName can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(Country); // Get type pointer
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
    
        public virtual ICollection<CountryState> CountryStates
        {
            get
            {
                if (_countryStates == null)
                {
                    var newCollection = new FixupCollection<CountryState>();
                    newCollection.CollectionChanged += FixupCountryStates;
                    _countryStates = newCollection;
                }
                return _countryStates;
            }
            set
            {
                if (!ReferenceEquals(_countryStates, value))
                {
                    var previousValue = _countryStates as FixupCollection<CountryState>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCountryStates;
                    }
                    _countryStates = value;
                    var newValue = value as FixupCollection<CountryState>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCountryStates;
                    }
                }
            }
        }
        private ICollection<CountryState> _countryStates;
    
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
    
        public virtual ICollection<CountryParameter> CountryParameters
        {
            get
            {
                if (_countryParameters == null)
                {
                    var newCollection = new FixupCollection<CountryParameter>();
                    newCollection.CollectionChanged += FixupCountryParameters;
                    _countryParameters = newCollection;
                }
                return _countryParameters;
            }
            set
            {
                if (!ReferenceEquals(_countryParameters, value))
                {
                    var previousValue = _countryParameters as FixupCollection<CountryParameter>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCountryParameters;
                    }
                    _countryParameters = value;
                    var newValue = value as FixupCollection<CountryParameter>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCountryParameters;
                    }
                }
            }
        }
        private ICollection<CountryParameter> _countryParameters;
    
        public virtual ICollection<EUUPSZone> EUUPSZones
        {
            get
            {
                if (_eUUPSZones == null)
                {
                    var newCollection = new FixupCollection<EUUPSZone>();
                    newCollection.CollectionChanged += FixupEUUPSZones;
                    _eUUPSZones = newCollection;
                }
                return _eUUPSZones;
            }
            set
            {
                if (!ReferenceEquals(_eUUPSZones, value))
                {
                    var previousValue = _eUUPSZones as FixupCollection<EUUPSZone>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupEUUPSZones;
                    }
                    _eUUPSZones = value;
                    var newValue = value as FixupCollection<EUUPSZone>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupEUUPSZones;
                    }
                }
            }
        }
        private ICollection<EUUPSZone> _eUUPSZones;
    
        public virtual ICollection<ECOPartnerServiceCoverage> ECOPartnerServiceCoverages
        {
            get
            {
                if (_eCOPartnerServiceCoverages == null)
                {
                    var newCollection = new FixupCollection<ECOPartnerServiceCoverage>();
                    newCollection.CollectionChanged += FixupECOPartnerServiceCoverages;
                    _eCOPartnerServiceCoverages = newCollection;
                }
                return _eCOPartnerServiceCoverages;
            }
            set
            {
                if (!ReferenceEquals(_eCOPartnerServiceCoverages, value))
                {
                    var previousValue = _eCOPartnerServiceCoverages as FixupCollection<ECOPartnerServiceCoverage>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupECOPartnerServiceCoverages;
                    }
                    _eCOPartnerServiceCoverages = value;
                    var newValue = value as FixupCollection<ECOPartnerServiceCoverage>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupECOPartnerServiceCoverages;
                    }
                }
            }
        }
        private ICollection<ECOPartnerServiceCoverage> _eCOPartnerServiceCoverages;
    
        public virtual ICollection<CountryLanguage> CountryLanguages
        {
            get
            {
                if (_countryLanguages == null)
                {
                    var newCollection = new FixupCollection<CountryLanguage>();
                    newCollection.CollectionChanged += FixupCountryLanguages;
                    _countryLanguages = newCollection;
                }
                return _countryLanguages;
            }
            set
            {
                if (!ReferenceEquals(_countryLanguages, value))
                {
                    var previousValue = _countryLanguages as FixupCollection<CountryLanguage>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCountryLanguages;
                    }
                    _countryLanguages = value;
                    var newValue = value as FixupCollection<CountryLanguage>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCountryLanguages;
                    }
                }
            }
        }
        private ICollection<CountryLanguage> _countryLanguages;
    
        public virtual ICollection<CountryCurrency> CountryCurrencies
        {
            get
            {
                if (_countryCurrencies == null)
                {
                    var newCollection = new FixupCollection<CountryCurrency>();
                    newCollection.CollectionChanged += FixupCountryCurrencies;
                    _countryCurrencies = newCollection;
                }
                return _countryCurrencies;
            }
            set
            {
                if (!ReferenceEquals(_countryCurrencies, value))
                {
                    var previousValue = _countryCurrencies as FixupCollection<CountryCurrency>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCountryCurrencies;
                    }
                    _countryCurrencies = value;
                    var newValue = value as FixupCollection<CountryCurrency>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCountryCurrencies;
                    }
                }
            }
        }
        private ICollection<CountryCurrency> _countryCurrencies;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupStore(Store previousValue)
        {
            if (previousValue != null && previousValue.Countries.Contains(this))
            {
                previousValue.Countries.Remove(this);
            }
    
            if (Store != null)
            {
                if (!Store.Countries.Contains(this))
                {
                    Store.Countries.Add(this);
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
    
        private void FixupCountryStates(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CountryState item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CountryState item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }
    
        private void FixupDMFTerrorities(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (DMFTerrority item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (DMFTerrority item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
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
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Store item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
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
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CountryAddress item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }
    
        private void FixupCountryParameters(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CountryParameter item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CountryParameter item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }
    
        private void FixupEUUPSZones(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (EUUPSZone item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (EUUPSZone item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }
    
        private void FixupECOPartnerServiceCoverages(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ECOPartnerServiceCoverage item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ECOPartnerServiceCoverage item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }
    
        private void FixupCountryLanguages(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CountryLanguage item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CountryLanguage item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }
    
        private void FixupCountryCurrencies(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CountryCurrency item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CountryCurrency item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }

        #endregion

    }
}
