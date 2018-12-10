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
    public partial class Cart
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string CartID
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
    
        public virtual string UserID
        {
            get { return _userID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_userID != value)
                    {
                        if (Creator != null && Creator.UserID != value)
                        {
                            Creator = null;
                        }
                        _userID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _userID;
    
        public virtual string Currency
        {
            get;
            set;
        }
    
        public virtual Nullable<int> SoldtoID
        {
            get { return _soldtoID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_soldtoID != value)
                    {
                        if (SoldToContact != null && SoldToContact.ContactID != value)
                        {
                            SoldToContact = null;
                        }
                        _soldtoID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _soldtoID;
    
        public virtual Nullable<int> BilltoID
        {
            get { return _billtoID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_billtoID != value)
                    {
                        if (BillToContact != null && BillToContact.ContactID != value)
                        {
                            BillToContact = null;
                        }
                        _billtoID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _billtoID;
    
        public virtual Nullable<int> ShiptoID
        {
            get { return _shiptoID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_shiptoID != value)
                    {
                        if (ShipToContact != null && ShipToContact.ContactID != value)
                        {
                            ShipToContact = null;
                        }
                        _shiptoID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _shiptoID;
    
        public virtual decimal TotalAmount
        {
            get;
            set;
        }
    
        public virtual System.DateTime CreatedDate
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_createdBy != value)
                    {
                        if (User != null && User.UserID != value)
                        {
                            User = null;
                        }
                        _createdBy = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _createdBy;
    
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
    
        public virtual string Status
        {
            get;
            set;
        }
    
        public virtual string ProtectionStatus
        {
            get;
            set;
        }
    
        public virtual string SalesDivision
        {
            get;
            set;
        }
    
        public virtual string LocalCurrency
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> LocalCurExchangeRate
        {
            get;
            set;
        }
    
        public virtual Nullable<int> MiniSiteID
        {
            get { return _miniSiteID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_miniSiteID != value)
                    {
                        if (MiniSite != null && MiniSite.ID != value)
                        {
                            MiniSite = null;
                        }
                        _miniSiteID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _miniSiteID;

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (CartID == null) {
						 error_message.Add(new ErrorMessage("CartID", "CartID can not be Null "));
				}
		 if (StoreID == null) {
						 error_message.Add(new ErrorMessage("StoreID", "StoreID can not be Null "));
				}
		 if (UserID == null) {
						 error_message.Add(new ErrorMessage("UserID", "UserID can not be Null "));
				}
		 if (Currency == null) {
						 error_message.Add(new ErrorMessage("Currency", "Currency can not be Null "));
				}
		 if (CreatedBy == null) {
						 error_message.Add(new ErrorMessage("CreatedBy", "CreatedBy can not be Null "));
				}
		 if (Status == null) {
						 error_message.Add(new ErrorMessage("Status", "Status can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(Cart); // Get type pointer
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
    
        public virtual CartContact SoldToContact
        {
            get { return _soldToContact; }
            set
            {
                if (!ReferenceEquals(_soldToContact, value))
                {
                    var previousValue = _soldToContact;
                    _soldToContact = value;
                    FixupSoldToContact(previousValue);
                }
            }
        }
        private CartContact _soldToContact;
    
        public virtual CartContact BillToContact
        {
            get { return _billToContact; }
            set
            {
                if (!ReferenceEquals(_billToContact, value))
                {
                    var previousValue = _billToContact;
                    _billToContact = value;
                    FixupBillToContact(previousValue);
                }
            }
        }
        private CartContact _billToContact;
    
        public virtual CartContact ShipToContact
        {
            get { return _shipToContact; }
            set
            {
                if (!ReferenceEquals(_shipToContact, value))
                {
                    var previousValue = _shipToContact;
                    _shipToContact = value;
                    FixupShipToContact(previousValue);
                }
            }
        }
        private CartContact _shipToContact;
    
        public virtual User User
        {
            get { return _user; }
            set
            {
                if (!ReferenceEquals(_user, value))
                {
                    var previousValue = _user;
                    _user = value;
                    FixupUser(previousValue);
                }
            }
        }
        private User _user;
    
        public virtual ICollection<CartItem> CartItems
        {
            get
            {
                if (_cartItems == null)
                {
                    var newCollection = new FixupCollection<CartItem>();
                    newCollection.CollectionChanged += FixupCartItems;
                    _cartItems = newCollection;
                }
                return _cartItems;
            }
            set
            {
                if (!ReferenceEquals(_cartItems, value))
                {
                    var previousValue = _cartItems as FixupCollection<CartItem>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCartItems;
                    }
                    _cartItems = value;
                    var newValue = value as FixupCollection<CartItem>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCartItems;
                    }
                }
            }
        }
        private ICollection<CartItem> _cartItems;
    
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
    
        public virtual User Creator
        {
            get { return _creator; }
            set
            {
                if (!ReferenceEquals(_creator, value))
                {
                    var previousValue = _creator;
                    _creator = value;
                    FixupCreator(previousValue);
                }
            }
        }
        private User _creator;
    
        public virtual ICollection<PackingList> PackingLists
        {
            get
            {
                if (_packingLists == null)
                {
                    var newCollection = new FixupCollection<PackingList>();
                    newCollection.CollectionChanged += FixupPackingLists;
                    _packingLists = newCollection;
                }
                return _packingLists;
            }
            set
            {
                if (!ReferenceEquals(_packingLists, value))
                {
                    var previousValue = _packingLists as FixupCollection<PackingList>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPackingLists;
                    }
                    _packingLists = value;
                    var newValue = value as FixupCollection<PackingList>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPackingLists;
                    }
                }
            }
        }
        private ICollection<PackingList> _packingLists;
    
        public virtual ICollection<Quotation> Quotations
        {
            get
            {
                if (_quotations == null)
                {
                    var newCollection = new FixupCollection<Quotation>();
                    newCollection.CollectionChanged += FixupQuotations;
                    _quotations = newCollection;
                }
                return _quotations;
            }
            set
            {
                if (!ReferenceEquals(_quotations, value))
                {
                    var previousValue = _quotations as FixupCollection<Quotation>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupQuotations;
                    }
                    _quotations = value;
                    var newValue = value as FixupCollection<Quotation>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupQuotations;
                    }
                }
            }
        }
        private ICollection<Quotation> _quotations;
    
        public virtual ICollection<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    var newCollection = new FixupCollection<Order>();
                    newCollection.CollectionChanged += FixupOrders;
                    _orders = newCollection;
                }
                return _orders;
            }
            set
            {
                if (!ReferenceEquals(_orders, value))
                {
                    var previousValue = _orders as FixupCollection<Order>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupOrders;
                    }
                    _orders = value;
                    var newValue = value as FixupCollection<Order>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupOrders;
                    }
                }
            }
        }
        private ICollection<Order> _orders;
    
        public virtual MiniSite MiniSite
        {
            get { return _miniSite; }
            set
            {
                if (!ReferenceEquals(_miniSite, value))
                {
                    var previousValue = _miniSite;
                    _miniSite = value;
                    FixupMiniSite(previousValue);
                }
            }
        }
        private MiniSite _miniSite;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupSoldToContact(CartContact previousValue)
        {
            if (SoldToContact != null)
            {
                if (SoldtoID != SoldToContact.ContactID)
                {
                    SoldtoID = SoldToContact.ContactID;
                }
            }
            else if (!_settingFK)
            {
                SoldtoID = null;
            }
        }
    
        private void FixupBillToContact(CartContact previousValue)
        {
            if (BillToContact != null)
            {
                if (BilltoID != BillToContact.ContactID)
                {
                    BilltoID = BillToContact.ContactID;
                }
            }
            else if (!_settingFK)
            {
                BilltoID = null;
            }
        }
    
        private void FixupShipToContact(CartContact previousValue)
        {
            if (ShipToContact != null)
            {
                if (ShiptoID != ShipToContact.ContactID)
                {
                    ShiptoID = ShipToContact.ContactID;
                }
            }
            else if (!_settingFK)
            {
                ShiptoID = null;
            }
        }
    
        private void FixupUser(User previousValue)
        {
            if (User != null)
            {
                if (CreatedBy != User.UserID)
                {
                    CreatedBy = User.UserID;
                }
            }
        }
    
        private void FixupStore(Store previousValue)
        {
            if (Store != null)
            {
                if (StoreID != Store.StoreID)
                {
                    StoreID = Store.StoreID;
                }
            }
        }
    
        private void FixupCreator(User previousValue)
        {
            if (Creator != null)
            {
                if (UserID != Creator.UserID)
                {
                    UserID = Creator.UserID;
                }
            }
        }
    
        private void FixupMiniSite(MiniSite previousValue)
        {
            if (previousValue != null && previousValue.Carts.Contains(this))
            {
                previousValue.Carts.Remove(this);
            }
    
            if (MiniSite != null)
            {
                if (!MiniSite.Carts.Contains(this))
                {
                    MiniSite.Carts.Add(this);
                }
                if (MiniSiteID != MiniSite.ID)
                {
                    MiniSiteID = MiniSite.ID;
                }
            }
            else if (!_settingFK)
            {
                MiniSiteID = null;
            }
        }
    
        private void FixupCartItems(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CartItem item in e.NewItems)
                {
                    item.Cart = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CartItem item in e.OldItems)
                {
                    if (ReferenceEquals(item.Cart, this))
                    {
                        item.Cart = null;
                    }
                }
            }
        }
    
        private void FixupPackingLists(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PackingList item in e.NewItems)
                {
                    item.Cart = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PackingList item in e.OldItems)
                {
                    if (ReferenceEquals(item.Cart, this))
                    {
                        item.Cart = null;
                    }
                }
            }
        }
    
        private void FixupQuotations(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Quotation item in e.NewItems)
                {
                    item.Cart = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Quotation item in e.OldItems)
                {
                    if (ReferenceEquals(item.Cart, this))
                    {
                        item.Cart = null;
                    }
                }
            }
        }
    
        private void FixupOrders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Order item in e.NewItems)
                {
                    item.Cart = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Order item in e.OldItems)
                {
                    if (ReferenceEquals(item.Cart, this))
                    {
                        item.Cart = null;
                    }
                }
            }
        }

        #endregion

    }
}