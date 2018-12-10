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
    public partial class SolutionsAssosociateItem
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
    
        public virtual int SolutionId
        {
            get { return _solutionId; }
            set
            {
                if (_solutionId != value)
                {
                    if (Solution != null && Solution.Id != value)
                    {
                        Solution = null;
                    }
                    _solutionId = value;
                }
            }
        }
        private int _solutionId;
    
        public virtual string StoreID
        {
            get { return _storeID; }
            set
            {
                if (_storeID != value)
                {
                    if (Part != null && Part.StoreID != value)
                    {
                        Part = null;
                    }
                    _storeID = value;
                }
            }
        }
        private string _storeID;
    
        public virtual string SProductID
        {
            get { return _sProductID; }
            set
            {
                if (_sProductID != value)
                {
                    if (Part != null && Part.SProductID != value)
                    {
                        Part = null;
                    }
                    _sProductID = value;
                }
            }
        }
        private string _sProductID;
    
        public virtual System.DateTime CreatedDate
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get;
            set;
        }
    
        public virtual string LastUpdateBy
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LastUpdateDate
        {
            get;
            set;
        }
    
        public virtual bool PublishStatus
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
		 if (SProductID == null) {
						 error_message.Add(new ErrorMessage("SProductID", "SProductID can not be Null "));
				}
		 if (CreatedBy == null) {
						 error_message.Add(new ErrorMessage("CreatedBy", "CreatedBy can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(SolutionsAssosociateItem); // Get type pointer
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
    
        public virtual Part Part
        {
            get { return _part; }
            set
            {
                if (!ReferenceEquals(_part, value))
                {
                    var previousValue = _part;
                    _part = value;
                    FixupPart(previousValue);
                }
            }
        }
        private Part _part;
    
        public virtual Solution Solution
        {
            get { return _solution; }
            set
            {
                if (!ReferenceEquals(_solution, value))
                {
                    var previousValue = _solution;
                    _solution = value;
                    FixupSolution(previousValue);
                }
            }
        }
        private Solution _solution;

        #endregion

        #region Association Fixup
    
        private void FixupPart(Part previousValue)
        {
            if (Part != null)
            {
                if (StoreID != Part.StoreID)
                {
                    StoreID = Part.StoreID;
                }
                if (SProductID != Part.SProductID)
                {
                    SProductID = Part.SProductID;
                }
            }
        }
    
        private void FixupSolution(Solution previousValue)
        {
            if (previousValue != null && previousValue.SolutionsAssosociateItems.Contains(this))
            {
                previousValue.SolutionsAssosociateItems.Remove(this);
            }
    
            if (Solution != null)
            {
                if (!Solution.SolutionsAssosociateItems.Contains(this))
                {
                    Solution.SolutionsAssosociateItems.Add(this);
                }
                if (SolutionId != Solution.Id)
                {
                    SolutionId = Solution.Id;
                }
            }
        }

        #endregion

    }
}
