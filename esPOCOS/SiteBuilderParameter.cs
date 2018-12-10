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
    public partial class SiteBuilderParameter
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual int SiteBuilderId
        {
            get { return _siteBuilderId; }
            set
            {
                if (_siteBuilderId != value)
                {
                    if (SiteBuilder != null && SiteBuilder.Id != value)
                    {
                        SiteBuilder = null;
                    }
                    _siteBuilderId = value;
                }
            }
        }
        private int _siteBuilderId;
    
        public virtual string ParameterGroup
        {
            get;
            set;
        }
    
        public virtual string ParameterType
        {
            get;
            set;
        }
    
        public virtual string ParameterKey
        {
            get;
            set;
        }
    
        public virtual string ParameterValue
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ParameterStatus
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
            Type type = typeof(SiteBuilderParameter); // Get type pointer
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
    
        public virtual SiteBuilder SiteBuilder
        {
            get { return _siteBuilder; }
            set
            {
                if (!ReferenceEquals(_siteBuilder, value))
                {
                    var previousValue = _siteBuilder;
                    _siteBuilder = value;
                    FixupSiteBuilder(previousValue);
                }
            }
        }
        private SiteBuilder _siteBuilder;

        #endregion

        #region Association Fixup
    
        private void FixupSiteBuilder(SiteBuilder previousValue)
        {
            if (previousValue != null && previousValue.SiteBuilderParameters.Contains(this))
            {
                previousValue.SiteBuilderParameters.Remove(this);
            }
    
            if (SiteBuilder != null)
            {
                if (!SiteBuilder.SiteBuilderParameters.Contains(this))
                {
                    SiteBuilder.SiteBuilderParameters.Add(this);
                }
                if (SiteBuilderId != SiteBuilder.Id)
                {
                    SiteBuilderId = SiteBuilder.Id;
                }
            }
        }

        #endregion

    }
}