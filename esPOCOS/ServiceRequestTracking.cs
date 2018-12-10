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
    public partial class ServiceRequestTracking
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
    
        public virtual string ServiceRequestID
        {
            get;
            set;
        }
    
        public virtual string Remark
        {
            get;
            set;
        }
    
        public virtual string Status
        {
            get;
            set;
        }
    
        public virtual string UpdateBy
        {
            get;
            set;
        }
    
        public virtual System.DateTime UpdateDate
        {
            get;
            set;
        }
    
        public virtual long SN_ID
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (ServiceRequestID == null) {
						 error_message.Add(new ErrorMessage("ServiceRequestID", "ServiceRequestID can not be Null "));
				}
		 if (UpdateBy == null) {
						 error_message.Add(new ErrorMessage("UpdateBy", "UpdateBy can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(ServiceRequestTracking); // Get type pointer
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

    }
}