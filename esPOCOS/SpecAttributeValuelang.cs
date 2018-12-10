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
    public partial class SpecAttributeValuelang
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string StoreID
        {
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
                    if (SpecAttributeValue != null && SpecAttributeValue.AttrValueID != value)
                    {
                        SpecAttributeValue = null;
                    }
                    _attrValueID = value;
                }
            }
        }
        private int _attrValueID;
    
        public virtual string DisplayName
        {
            get;
            set;
        }
    
        public virtual int ID
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
            Type type = typeof(SpecAttributeValuelang); // Get type pointer
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
    
        public virtual SpecAttributeValue SpecAttributeValue
        {
            get { return _specAttributeValue; }
            set
            {
                if (!ReferenceEquals(_specAttributeValue, value))
                {
                    var previousValue = _specAttributeValue;
                    _specAttributeValue = value;
                    FixupSpecAttributeValue(previousValue);
                }
            }
        }
        private SpecAttributeValue _specAttributeValue;

        #endregion

        #region Association Fixup
    
        private void FixupSpecAttributeValue(SpecAttributeValue previousValue)
        {
            if (previousValue != null && previousValue.SpecAttributeValuelangs.Contains(this))
            {
                previousValue.SpecAttributeValuelangs.Remove(this);
            }
    
            if (SpecAttributeValue != null)
            {
                if (!SpecAttributeValue.SpecAttributeValuelangs.Contains(this))
                {
                    SpecAttributeValue.SpecAttributeValuelangs.Add(this);
                }
                if (AttrValueID != SpecAttributeValue.AttrValueID)
                {
                    AttrValueID = SpecAttributeValue.AttrValueID;
                }
            }
        }

        #endregion

    }
}
