//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace eStore.POCOS.Sync
{
    public partial class es_cbomtree
    {
        #region Primitive Properties
    
        public virtual int cbomid
        {
            get;
            set;
        }
    
        public virtual int nodeid
        {
            get { return _nodeid; }
            set
            {
                if (_nodeid != value)
                {
                    if (es_sharebomtree != null && es_sharebomtree.nodeid != value)
                    {
                        es_sharebomtree = null;
                    }
                    _nodeid = value;
                }
            }
        }
        private int _nodeid;
    
        public virtual Nullable<int> seq
        {
            get;
            set;
        }
    
        public virtual Nullable<int> defaults
        {
            get;
            set;
        }
    
        public virtual string exceplist
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> discount
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> price
        {
            get;
            set;
        }
    
        public virtual string input
        {
            get;
            set;
        }
    
        public virtual string show
        {
            get;
            set;
        }
    
        public virtual Nullable<int> quantity
        {
            get;
            set;
        }
    
        public virtual string localPartno
        {
            get;
            set;
        }
    
        public virtual int id
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> insertdate
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> cost
        {
            get;
            set;
        }
    
        public virtual string message
        {
            get;
            set;
        }
    
        public virtual int maxquantity
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual es_sharebomtree es_sharebomtree
        {
            get { return _es_sharebomtree; }
            set
            {
                if (!ReferenceEquals(_es_sharebomtree, value))
                {
                    var previousValue = _es_sharebomtree;
                    _es_sharebomtree = value;
                    Fixupes_sharebomtree(previousValue);
                }
            }
        }
        private es_sharebomtree _es_sharebomtree;

        #endregion
        #region Association Fixup
    
        private void Fixupes_sharebomtree(es_sharebomtree previousValue)
        {
            if (previousValue != null && previousValue.es_cbomtree.Contains(this))
            {
                previousValue.es_cbomtree.Remove(this);
            }
    
            if (es_sharebomtree != null)
            {
                if (!es_sharebomtree.es_cbomtree.Contains(this))
                {
                    es_sharebomtree.es_cbomtree.Add(this);
                }
                if (nodeid != es_sharebomtree.nodeid)
                {
                    nodeid = es_sharebomtree.nodeid;
                }
            }
        }

        #endregion
    }
}
