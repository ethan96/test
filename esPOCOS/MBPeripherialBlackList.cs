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
    public partial class MBPeripherialBlackList
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
    
        public virtual string MBPartNo
        {
            get;
            set;
        }
    
        public virtual string PeripherialPartNo
        {
            get;
            set;
        }
    
        public virtual string Note
        {
            get;
            set;
        }
    
        public virtual string Status
        {
            get;
            set;
        }
    
        public virtual System.DateTime StatusDate
        {
            get;
            set;
        }
    
        public virtual int MBCPUMemorySpecId
        {
            get { return _mBCPUMemorySpecId; }
            set
            {
                if (_mBCPUMemorySpecId != value)
                {
                    if (MBCPUMemorySpec != null && MBCPUMemorySpec.Id != value)
                    {
                        MBCPUMemorySpec = null;
                    }
                    _mBCPUMemorySpecId = value;
                }
            }
        }
        private int _mBCPUMemorySpecId;

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (MBPartNo == null) {
						 error_message.Add(new ErrorMessage("MBPartNo", "MBPartNo can not be Null "));
				}
		 if (PeripherialPartNo == null) {
						 error_message.Add(new ErrorMessage("PeripherialPartNo", "PeripherialPartNo can not be Null "));
				}
		 if (Note == null) {
						 error_message.Add(new ErrorMessage("Note", "Note can not be Null "));
				}
		 if (Status == null) {
						 error_message.Add(new ErrorMessage("Status", "Status can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(MBPeripherialBlackList); // Get type pointer
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
    
        public virtual MBCPUMemorySpec MBCPUMemorySpec
        {
            get { return _mBCPUMemorySpec; }
            set
            {
                if (!ReferenceEquals(_mBCPUMemorySpec, value))
                {
                    var previousValue = _mBCPUMemorySpec;
                    _mBCPUMemorySpec = value;
                    FixupMBCPUMemorySpec(previousValue);
                }
            }
        }
        private MBCPUMemorySpec _mBCPUMemorySpec;

        #endregion

        #region Association Fixup
    
        private void FixupMBCPUMemorySpec(MBCPUMemorySpec previousValue)
        {
            if (previousValue != null && previousValue.MBPeripherialBlackLists.Contains(this))
            {
                previousValue.MBPeripherialBlackLists.Remove(this);
            }
    
            if (MBCPUMemorySpec != null)
            {
                if (!MBCPUMemorySpec.MBPeripherialBlackLists.Contains(this))
                {
                    MBCPUMemorySpec.MBPeripherialBlackLists.Add(this);
                }
                if (MBCPUMemorySpecId != MBCPUMemorySpec.Id)
                {
                    MBCPUMemorySpecId = MBCPUMemorySpec.Id;
                }
            }
        }

        #endregion

    }
}