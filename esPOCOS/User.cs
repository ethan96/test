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
    public partial class User
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string UserID
        {
            get;
            set;
        }
    
        public virtual string CompanyName
        {
            get;
            set;
        }
    
        public virtual string CompanyID
        {
            get;
            set;
        }
    
        public virtual string OrgID
        {
            get;
            set;
        }
    
        public virtual string LoginPassword
        {
            get;
            set;
        }
    
        public virtual string UserType
        {
            get;
            set;
        }
    
        public virtual string FirstName
        {
            get;
            set;
        }
    
        public virtual string LastName
        {
            get;
            set;
        }
    
        public virtual string TelNo
        {
            get;
            set;
        }
    
        public virtual string TelExt
        {
            get;
            set;
        }
    
        public virtual string FaxNo
        {
            get;
            set;
        }
    
        public virtual string FaxExt
        {
            get;
            set;
        }
    
        public virtual string JobTitle
        {
            get;
            set;
        }
    
        public virtual string JobFunction
        {
            get;
            set;
        }
    
        public virtual string BusinessApplicationAreaCode
        {
            get;
            set;
        }
    
        public virtual string BusinessApplicationArea
        {
            get;
            set;
        }
    
        public virtual string BusinessTypeCode
        {
            get;
            set;
        }
    
        public virtual string BusinessType
        {
            get;
            set;
        }
    
        public virtual string InterestedProduct
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LastUpdated
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> CreatedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ERPConveyed
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> ERPconveyDate
        {
            get;
            set;
        }
    
        public virtual string User_Field_TXT1
        {
            get;
            set;
        }
    
        public virtual string User_Field_TXT2
        {
            get;
            set;
        }
    
        public virtual string Department
        {
            get;
            set;
        }
    
        public virtual string ResellerID
        {
            get;
            set;
        }
    
        public virtual string eMailSubscription
        {
            get;
            set;
        }
    
        public virtual string PriceGrade
        {
            get;
            set;
        }
    
        public virtual string UserStatus
        {
            get;
            set;
        }
    
        public virtual string GroupID
        {
            get;
            set;
        }
    
        public virtual string Bank
        {
            get;
            set;
        }
    
        public virtual string BankAccount
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> CreditAppDate
        {
            get;
            set;
        }
    
        public virtual string CreditResult
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> CreditResultDate
        {
            get;
            set;
        }
    
        public virtual string CreditProcessBy
        {
            get;
            set;
        }
    
        public virtual string CreditAppBy
        {
            get;
            set;
        }
    
        public virtual string CreditComment
        {
            get;
            set;
        }
    
        public virtual string FederalID
        {
            get;
            set;
        }
    
        public virtual string VATStatus
        {
            get;
            set;
        }
    
        public virtual string VATProcessBy
        {
            get;
            set;
        }
    
        public virtual string VATResult
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> VATResultDate
        {
            get;
            set;
        }
    
        public virtual string LastUpdatedBy
        {
            get;
            set;
        }
    
        public virtual string FollowUpComments
        {
            get;
            set;
        }
    
        public virtual string FollowUpStatus
        {
            get;
            set;
        }
    
        public virtual string ResellerCertificate
        {
            get;
            set;
        }
    
        public virtual string NetTermID
        {
            get;
            set;
        }
    
        public virtual string UserGrade
        {
            get;
            set;
        }
    
        public virtual string AccountAssistant
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (UserID == null) {
						 error_message.Add(new ErrorMessage("UserID", "UserID can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(User); // Get type pointer
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
    
        public virtual ICollection<Contact> Contacts
        {
            get
            {
                if (_contacts == null)
                {
                    var newCollection = new FixupCollection<Contact>();
                    newCollection.CollectionChanged += FixupContacts;
                    _contacts = newCollection;
                }
                return _contacts;
            }
            set
            {
                if (!ReferenceEquals(_contacts, value))
                {
                    var previousValue = _contacts as FixupCollection<Contact>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupContacts;
                    }
                    _contacts = value;
                    var newValue = value as FixupCollection<Contact>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupContacts;
                    }
                }
            }
        }
        private ICollection<Contact> _contacts;
    
        public virtual ICollection<UserShortCut> UserShortCuts
        {
            get
            {
                if (_userShortCuts == null)
                {
                    var newCollection = new FixupCollection<UserShortCut>();
                    newCollection.CollectionChanged += FixupUserShortCuts;
                    _userShortCuts = newCollection;
                }
                return _userShortCuts;
            }
            set
            {
                if (!ReferenceEquals(_userShortCuts, value))
                {
                    var previousValue = _userShortCuts as FixupCollection<UserShortCut>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupUserShortCuts;
                    }
                    _userShortCuts = value;
                    var newValue = value as FixupCollection<UserShortCut>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupUserShortCuts;
                    }
                }
            }
        }
        private ICollection<UserShortCut> _userShortCuts;
    
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
    
        private void FixupContacts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Contact item in e.NewItems)
                {
                    item.User = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Contact item in e.OldItems)
                {
                    if (ReferenceEquals(item.User, this))
                    {
                        item.User = null;
                    }
                }
            }
        }
    
        private void FixupUserShortCuts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (UserShortCut item in e.NewItems)
                {
                    item.User = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (UserShortCut item in e.OldItems)
                {
                    if (ReferenceEquals(item.User, this))
                    {
                        item.User = null;
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
                    if (!item.Users.Contains(this))
                    {
                        item.Users.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (AdminRole item in e.OldItems)
                {
                    if (item.Users.Contains(this))
                    {
                        item.Users.Remove(this);
                    }
                }
            }
        }

        #endregion

    }
}
