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
    public partial class SpecAttributeValue
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int AttrValueID
        {
            get { return _attrValueID; }
            set
            {
                if (_attrValueID != value)
                {
                    if (SpecAttributeValue2 != null && SpecAttributeValue2.AttrValueID != value)
                    {
                        SpecAttributeValue2 = null;
                    }
                    _attrValueID = value;
                }
            }
        }
        private int _attrValueID;
    
        public virtual string AttrValueName
        {
            get;
            set;
        }
    
        public virtual int AttrID
        {
            get { return _attrID; }
            set
            {
                if (_attrID != value)
                {
                    if (SpecAttribute != null && SpecAttribute.AttrID != value)
                    {
                        SpecAttribute = null;
                    }
                    _attrID = value;
                }
            }
        }
        private int _attrID;

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
            Type type = typeof(SpecAttributeValue); // Get type pointer
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
    
        public virtual SpecAttribute SpecAttribute
        {
            get { return _specAttribute; }
            set
            {
                if (!ReferenceEquals(_specAttribute, value))
                {
                    var previousValue = _specAttribute;
                    _specAttribute = value;
                    FixupSpecAttribute(previousValue);
                }
            }
        }
        private SpecAttribute _specAttribute;
    
        public virtual ICollection<SpecAttributeValuelang> SpecAttributeValuelangs
        {
            get
            {
                if (_specAttributeValuelangs == null)
                {
                    var newCollection = new FixupCollection<SpecAttributeValuelang>();
                    newCollection.CollectionChanged += FixupSpecAttributeValuelangs;
                    _specAttributeValuelangs = newCollection;
                }
                return _specAttributeValuelangs;
            }
            set
            {
                if (!ReferenceEquals(_specAttributeValuelangs, value))
                {
                    var previousValue = _specAttributeValuelangs as FixupCollection<SpecAttributeValuelang>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupSpecAttributeValuelangs;
                    }
                    _specAttributeValuelangs = value;
                    var newValue = value as FixupCollection<SpecAttributeValuelang>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupSpecAttributeValuelangs;
                    }
                }
            }
        }
        private ICollection<SpecAttributeValuelang> _specAttributeValuelangs;
    
        public virtual SpecAttributeValue SpecAttributeValue1
        {
            get { return _specAttributeValue1; }
            set
            {
                if (!ReferenceEquals(_specAttributeValue1, value))
                {
                    var previousValue = _specAttributeValue1;
                    _specAttributeValue1 = value;
                    FixupSpecAttributeValue1(previousValue);
                }
            }
        }
        private SpecAttributeValue _specAttributeValue1;
    
        public virtual SpecAttributeValue SpecAttributeValue2
        {
            get { return _specAttributeValue2; }
            set
            {
                if (!ReferenceEquals(_specAttributeValue2, value))
                {
                    var previousValue = _specAttributeValue2;
                    _specAttributeValue2 = value;
                    FixupSpecAttributeValue2(previousValue);
                }
            }
        }
        private SpecAttributeValue _specAttributeValue2;

        #endregion

        #region Association Fixup
    
        private void FixupSpecAttribute(SpecAttribute previousValue)
        {
            if (previousValue != null && previousValue.SpecAttributeValues.Contains(this))
            {
                previousValue.SpecAttributeValues.Remove(this);
            }
    
            if (SpecAttribute != null)
            {
                if (!SpecAttribute.SpecAttributeValues.Contains(this))
                {
                    SpecAttribute.SpecAttributeValues.Add(this);
                }
                if (AttrID != SpecAttribute.AttrID)
                {
                    AttrID = SpecAttribute.AttrID;
                }
            }
        }
    
        private void FixupSpecAttributeValue1(SpecAttributeValue previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.SpecAttributeValue2, this))
            {
                previousValue.SpecAttributeValue2 = null;
            }
    
            if (SpecAttributeValue1 != null)
            {
                SpecAttributeValue1.SpecAttributeValue2 = this;
            }
        }
    
        private void FixupSpecAttributeValue2(SpecAttributeValue previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.SpecAttributeValue1, this))
            {
                previousValue.SpecAttributeValue1 = null;
            }
    
            if (SpecAttributeValue2 != null)
            {
                SpecAttributeValue2.SpecAttributeValue1 = this;
                if (AttrValueID != SpecAttributeValue2.AttrValueID)
                {
                    AttrValueID = SpecAttributeValue2.AttrValueID;
                }
            }
        }
    
        private void FixupSpecAttributeValuelangs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (SpecAttributeValuelang item in e.NewItems)
                {
                    item.SpecAttributeValue = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SpecAttributeValuelang item in e.OldItems)
                {
                    if (ReferenceEquals(item.SpecAttributeValue, this))
                    {
                        item.SpecAttributeValue = null;
                    }
                }
            }
        }

        #endregion

    }
}