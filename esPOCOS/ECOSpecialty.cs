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
    public partial class ECOSpecialty
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int SpecialtyId
        {
            get;
            set;
        }
    
        public virtual string SpecialtyName
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> PublishStatus
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> CreatedDate
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
            Type type = typeof(ECOSpecialty); // Get type pointer
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
    
        public virtual ICollection<ECOPartnerSpecialty> ECOPartnerSpecialties
        {
            get
            {
                if (_eCOPartnerSpecialties == null)
                {
                    var newCollection = new FixupCollection<ECOPartnerSpecialty>();
                    newCollection.CollectionChanged += FixupECOPartnerSpecialties;
                    _eCOPartnerSpecialties = newCollection;
                }
                return _eCOPartnerSpecialties;
            }
            set
            {
                if (!ReferenceEquals(_eCOPartnerSpecialties, value))
                {
                    var previousValue = _eCOPartnerSpecialties as FixupCollection<ECOPartnerSpecialty>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupECOPartnerSpecialties;
                    }
                    _eCOPartnerSpecialties = value;
                    var newValue = value as FixupCollection<ECOPartnerSpecialty>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupECOPartnerSpecialties;
                    }
                }
            }
        }
        private ICollection<ECOPartnerSpecialty> _eCOPartnerSpecialties;

        #endregion

        #region Association Fixup
    
        private void FixupECOPartnerSpecialties(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ECOPartnerSpecialty item in e.NewItems)
                {
                    item.ECOSpecialty = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ECOPartnerSpecialty item in e.OldItems)
                {
                    if (ReferenceEquals(item.ECOSpecialty, this))
                    {
                        item.ECOSpecialty = null;
                    }
                }
            }
        }

        #endregion

    }
}
