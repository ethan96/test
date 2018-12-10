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
    public partial class CampaignStrategy
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual string StoreID
        {
            get;
            set;
        }
    
        public virtual string PromotionCode
        {
            get;
            set;
        }
    
        public virtual int CampaignID
        {
            get { return _campaignID; }
            set
            {
                if (_campaignID != value)
                {
                    if (Campaign != null && Campaign.CampaignID != value)
                    {
                        Campaign = null;
                    }
                    _campaignID = value;
                }
            }
        }
        private int _campaignID;
    
        public virtual string PromoteDesc
        {
            get;
            set;
        }
    
        public virtual string ProductType
        {
            get;
            set;
        }
    
        public virtual string BusinessGroup
        {
            get;
            set;
        }
    
        public virtual string CategoryIDList
        {
            get;
            set;
        }
    
        public virtual string ExceptionPNList
        {
            get;
            set;
        }
    
        public virtual string UserIDList
        {
            get;
            set;
        }
    
        public virtual string CustomerType
        {
            get;
            set;
        }
    
        public virtual decimal DiscountValue
        {
            get;
            set;
        }
    
        public virtual string ItemType
        {
            get;
            set;
        }
    
        public virtual Nullable<int> MinQTY
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> MinAmount
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> ExclusiveFlag
        {
            get;
            set;
        }
    
        public virtual Nullable<int> Priority
        {
            get;
            set;
        }
    
        public virtual string DiscountType
        {
            get;
            set;
        }
    
        public virtual string BenefitText
        {
            get;
            set;
        }
    
        public virtual Nullable<int> MaxQtyPerUser
        {
            get;
            set;
        }
    
        public virtual int MaxTotalAppliedTimes
        {
            get;
            set;
        }
    
        public virtual Nullable<int> TotalAppliedTimes
        {
            get;
            set;
        }
    
        public virtual System.DateTime CreatedDATE
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get;
            set;
        }
    
        public virtual string BenefitText2
        {
            get;
            set;
        }
    
        public virtual Nullable<int> MininumVolume
        {
            get;
            set;
        }
    
        public virtual Nullable<int> MaxApplicableTimesPerUser
        {
            get;
            set;
        }
    
        public virtual string ExceptionType
        {
            get;
            set;
        }
    
        public virtual string Status
        {
            get;
            set;
        }
    
        public virtual string MatchCriteria
        {
            get;
            set;
        }
    
        public virtual string DiscountValueType
        {
            get;
            set;
        }
    
        public virtual string XRule
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (PromotionCode == null) {
						 error_message.Add(new ErrorMessage("PromotionCode", "PromotionCode can not be Null "));
				}
		 if (PromoteDesc == null) {
						 error_message.Add(new ErrorMessage("PromoteDesc", "PromoteDesc can not be Null "));
				}
		 if (ProductType == null) {
						 error_message.Add(new ErrorMessage("ProductType", "ProductType can not be Null "));
				}
		 if (BusinessGroup == null) {
						 error_message.Add(new ErrorMessage("BusinessGroup", "BusinessGroup can not be Null "));
				}
		 if (ItemType == null) {
						 error_message.Add(new ErrorMessage("ItemType", "ItemType can not be Null "));
				}
		 if (DiscountType == null) {
						 error_message.Add(new ErrorMessage("DiscountType", "DiscountType can not be Null "));
				}
		 if (CreatedBy == null) {
						 error_message.Add(new ErrorMessage("CreatedBy", "CreatedBy can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(CampaignStrategy); // Get type pointer
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
    
        public virtual Campaign Campaign
        {
            get { return _campaign; }
            set
            {
                if (!ReferenceEquals(_campaign, value))
                {
                    var previousValue = _campaign;
                    _campaign = value;
                    FixupCampaign(previousValue);
                }
            }
        }
        private Campaign _campaign;

        #endregion

        #region Association Fixup
    
        private void FixupCampaign(Campaign previousValue)
        {
            if (previousValue != null && previousValue.CampaignStrategies.Contains(this))
            {
                previousValue.CampaignStrategies.Remove(this);
            }
    
            if (Campaign != null)
            {
                if (!Campaign.CampaignStrategies.Contains(this))
                {
                    Campaign.CampaignStrategies.Add(this);
                }
                if (CampaignID != Campaign.CampaignID)
                {
                    CampaignID = Campaign.CampaignID;
                }
            }
        }
    
        private void FixupCartItems(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CartItem item in e.NewItems)
                {
                    item.CampaignStrategy = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CartItem item in e.OldItems)
                {
                    if (ReferenceEquals(item.CampaignStrategy, this))
                    {
                        item.CampaignStrategy = null;
                    }
                }
            }
        }

        #endregion

    }
}
