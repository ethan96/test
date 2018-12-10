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
    public partial class CTOSAttributeValue
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual Nullable<int> AttrID
        {
            get { return _attrID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_attrID != value)
                    {
                        if (CTOSAttribute != null && CTOSAttribute.AttrID != value)
                        {
                            CTOSAttribute = null;
                        }
                        _attrID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _attrID;
    
        public virtual int AttrValue_id
        {
            get;
            set;
        }
    
        public virtual string AttrValue_name
        {
            get;
            set;
        }
    
        public virtual string AttrValue_desc
        {
            get;
            set;
        }
    
        public virtual Nullable<int> Seq
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastUpdated
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
            Type type = typeof(CTOSAttributeValue); // Get type pointer
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
    
        public virtual CTOSAttribute CTOSAttribute
        {
            get { return _cTOSAttribute; }
            set
            {
                if (!ReferenceEquals(_cTOSAttribute, value))
                {
                    var previousValue = _cTOSAttribute;
                    _cTOSAttribute = value;
                    FixupCTOSAttribute(previousValue);
                }
            }
        }
        private CTOSAttribute _cTOSAttribute;
    
        public virtual ICollection<CTOSAttributeValuelang> CTOSAttributeValuelangs
        {
            get
            {
                if (_cTOSAttributeValuelangs == null)
                {
                    var newCollection = new FixupCollection<CTOSAttributeValuelang>();
                    newCollection.CollectionChanged += FixupCTOSAttributeValuelangs;
                    _cTOSAttributeValuelangs = newCollection;
                }
                return _cTOSAttributeValuelangs;
            }
            set
            {
                if (!ReferenceEquals(_cTOSAttributeValuelangs, value))
                {
                    var previousValue = _cTOSAttributeValuelangs as FixupCollection<CTOSAttributeValuelang>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCTOSAttributeValuelangs;
                    }
                    _cTOSAttributeValuelangs = value;
                    var newValue = value as FixupCollection<CTOSAttributeValuelang>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCTOSAttributeValuelangs;
                    }
                }
            }
        }
        private ICollection<CTOSAttributeValuelang> _cTOSAttributeValuelangs;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupCTOSAttribute(CTOSAttribute previousValue)
        {
            if (previousValue != null && previousValue.CTOSAttributeValues.Contains(this))
            {
                previousValue.CTOSAttributeValues.Remove(this);
            }
    
            if (CTOSAttribute != null)
            {
                if (!CTOSAttribute.CTOSAttributeValues.Contains(this))
                {
                    CTOSAttribute.CTOSAttributeValues.Add(this);
                }
                if (AttrID != CTOSAttribute.AttrID)
                {
                    AttrID = CTOSAttribute.AttrID;
                }
            }
            else if (!_settingFK)
            {
                AttrID = null;
            }
        }
    
        private void FixupCTOSAttributeValuelangs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CTOSAttributeValuelang item in e.NewItems)
                {
                    item.CTOSAttributeValue = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CTOSAttributeValuelang item in e.OldItems)
                {
                    if (ReferenceEquals(item.CTOSAttributeValue, this))
                    {
                        item.CTOSAttributeValue = null;
                    }
                }
            }
        }

        #endregion

    }
}
