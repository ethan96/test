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
    public partial class XRuleSet
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
                try
                {
                    _settingFK = true;
                    if (_storeID != value)
                    {
                        if (Store != null && Store.StoreID != value)
                        {
                            Store = null;
                        }
                        if (Parent != null && Parent.StoreID != value)
                        {
                            var previousValue = _parent;
                            _parent = null;
                            FixupParent(previousValue, skipKeys: true);
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
    
        public virtual int RulesetID
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ParentID
        {
            get { return _parentID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_parentID != value)
                    {
                        if (Parent != null && Parent.RulesetID != value)
                        {
                            var previousValue = _parent;
                            _parent = null;
                            FixupParent(previousValue, skipKeys: true);
                        }
                        _parentID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _parentID;
    
        public virtual string JoinSubRulesetBy
        {
            get;
            set;
        }
    
        public virtual string RuleSetType
        {
            get;
            set;
        }
    
        public virtual string Operator
        {
            get;
            set;
        }
    
        public virtual string MatchTerm
        {
            get;
            set;
        }
    
        public virtual int UnitQty
        {
            get;
            set;
        }
    
        public virtual Nullable<int> Priority
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> IncludeDetails
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
    
        public virtual string CheckLevel
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

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(XRuleSet); // Get type pointer
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
    
        public virtual ICollection<XRuleSet> Children
        {
            get
            {
                if (_children == null)
                {
                    var newCollection = new FixupCollection<XRuleSet>();
                    newCollection.CollectionChanged += FixupChildren;
                    _children = newCollection;
                }
                return _children;
            }
            set
            {
                if (!ReferenceEquals(_children, value))
                {
                    var previousValue = _children as FixupCollection<XRuleSet>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupChildren;
                    }
                    _children = value;
                    var newValue = value as FixupCollection<XRuleSet>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupChildren;
                    }
                }
            }
        }
        private ICollection<XRuleSet> _children;
    
        public virtual XRuleSet Parent
        {
            get { return _parent; }
            set
            {
                if (!ReferenceEquals(_parent, value))
                {
                    var previousValue = _parent;
                    _parent = value;
                    FixupParent(previousValue);
                }
            }
        }
        private XRuleSet _parent;

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
        }
    
        private void FixupParent(XRuleSet previousValue, bool skipKeys = false)
        {
            if (previousValue != null && previousValue.Children.Contains(this))
            {
                previousValue.Children.Remove(this);
            }
    
            if (Parent != null)
            {
                if (!Parent.Children.Contains(this))
                {
                    Parent.Children.Add(this);
                }
                if (StoreID != Parent.StoreID)
                {
                    StoreID = Parent.StoreID;
                }
                if (ParentID != Parent.RulesetID)
                {
                    ParentID = Parent.RulesetID;
                }
            }
            else if (!_settingFK && !skipKeys)
            {
                ParentID = null;
            }
        }
    
        private void FixupChildren(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (XRuleSet item in e.NewItems)
                {
                    item.Parent = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (XRuleSet item in e.OldItems)
                {
                    if (ReferenceEquals(item.Parent, this))
                    {
                        item.Parent = null;
                    }
                }
            }
        }

        #endregion

    }
}