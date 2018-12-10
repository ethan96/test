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
    public partial class Spec_Category_Lang
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
    
        public virtual int CATEGORY_ID
        {
            get { return _cATEGORY_ID; }
            set
            {
                if (_cATEGORY_ID != value)
                {
                    if (Spec_Category != null && Spec_Category.CATEGORY_ID != value)
                    {
                        Spec_Category = null;
                    }
                    _cATEGORY_ID = value;
                }
            }
        }
        private int _cATEGORY_ID;
    
        public virtual string StoreID
        {
            get;
            set;
        }
    
        public virtual string Local_Displayname
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
		 if (Local_Displayname == null) {
						 error_message.Add(new ErrorMessage("Local_Displayname", "Local_Displayname can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(Spec_Category_Lang); // Get type pointer
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
    
        public virtual Spec_Category Spec_Category
        {
            get { return _spec_Category; }
            set
            {
                if (!ReferenceEquals(_spec_Category, value))
                {
                    var previousValue = _spec_Category;
                    _spec_Category = value;
                    FixupSpec_Category(previousValue);
                }
            }
        }
        private Spec_Category _spec_Category;

        #endregion

        #region Association Fixup
    
        private void FixupSpec_Category(Spec_Category previousValue)
        {
            if (previousValue != null && previousValue.Spec_Category_Lang.Contains(this))
            {
                previousValue.Spec_Category_Lang.Remove(this);
            }
    
            if (Spec_Category != null)
            {
                if (!Spec_Category.Spec_Category_Lang.Contains(this))
                {
                    Spec_Category.Spec_Category_Lang.Add(this);
                }
                if (CATEGORY_ID != Spec_Category.CATEGORY_ID)
                {
                    CATEGORY_ID = Spec_Category.CATEGORY_ID;
                }
            }
        }

        #endregion

    }
}
