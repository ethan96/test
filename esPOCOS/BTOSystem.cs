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
    public partial class BTOSystem
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string BTOConfigID
        {
            get;
            set;
        }
    
        public virtual string BTONo
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (BTOConfigID == null) {
						 error_message.Add(new ErrorMessage("BTOConfigID", "BTOConfigID can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(BTOSystem); // Get type pointer
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
    
        public virtual ICollection<BTOSConfig> BTOSConfigs
        {
            get
            {
                if (_bTOSConfigs == null)
                {
                    var newCollection = new FixupCollection<BTOSConfig>();
                    newCollection.CollectionChanged += FixupBTOSConfigs;
                    _bTOSConfigs = newCollection;
                }
                return _bTOSConfigs;
            }
            set
            {
                if (!ReferenceEquals(_bTOSConfigs, value))
                {
                    var previousValue = _bTOSConfigs as FixupCollection<BTOSConfig>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupBTOSConfigs;
                    }
                    _bTOSConfigs = value;
                    var newValue = value as FixupCollection<BTOSConfig>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupBTOSConfigs;
                    }
                }
            }
        }
        private ICollection<BTOSConfig> _bTOSConfigs;

        #endregion

        #region Association Fixup
    
        private void FixupBTOSConfigs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (BTOSConfig item in e.NewItems)
                {
                    item.BTOSystem = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (BTOSConfig item in e.OldItems)
                {
                    if (ReferenceEquals(item.BTOSystem, this))
                    {
                        item.BTOSystem = null;
                    }
                }
            }
        }

        #endregion

    }
}
