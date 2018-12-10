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
    public partial class ProductCategory
    {
        #region Primitive Properties
     
    	public List<ErrorMessage> error_message{
    		get;
    		set;
    	}
    
    
        public virtual string Storeid
        {
            get { return _storeid; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_storeid != value)
                    {
                        if (ParentCategory != null && ParentCategory.Storeid != value)
                        {
                            var previousValue = _parentCategory;
                            _parentCategory = null;
                            FixupParentCategory(previousValue, skipKeys: true);
                        }
                        if (Store != null && Store.StoreID != value)
                        {
                            Store = null;
                        }
                        _storeid = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _storeid;
    
        public virtual int CategoryID
        {
            get;
            set;
        }
    
        public virtual string CategoryPath
        {
            get;
            set;
        }
    
        public virtual string CategoryName
        {
            get;
            set;
        }
    
        public virtual string LocalCategoryName
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ParentCategoryID
        {
            get { return _parentCategoryID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_parentCategoryID != value)
                    {
                        if (ParentCategory != null && ParentCategory.CategoryID != value)
                        {
                            var previousValue = _parentCategory;
                            _parentCategory = null;
                            FixupParentCategory(previousValue, skipKeys: true);
                        }
                        _parentCategoryID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _parentCategoryID;
    
        public virtual Nullable<System.DateTime> CreatedDate
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get;
            set;
        }
    
        public virtual string CategoryType
        {
            get;
            set;
        }
    
        public virtual string DisplayType
        {
            get;
            set;
        }
    
        public virtual string ImageURL
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual string Keywords
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> Publish
        {
            get;
            set;
        }
    
        public virtual Nullable<int> Sequence
        {
            get;
            set;
        }
    
        public virtual string PageTitle
        {
            get;
            set;
        }
    
        public virtual string PageDescription
        {
            get;
            set;
        }
    
        public virtual string ProductDivision
        {
            get;
            set;
        }
    
        public virtual Nullable<int> RuleSetId
        {
            get { return _ruleSetId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_ruleSetId != value)
                    {
                        if (RuleSet != null && RuleSet.RuleSetID != value)
                        {
                            RuleSet = null;
                        }
                        _ruleSetId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _ruleSetId;
    
        public virtual string ExtendedDescription
        {
            get;
            set;
        }
    
        public virtual string CustomURL
        {
            get;
            set;
        }
    
        public virtual Nullable<int> MiniSiteID
        {
            get { return _miniSiteID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_miniSiteID != value)
                    {
                        if (MiniSite != null && MiniSite.ID != value)
                        {
                            MiniSite = null;
                        }
                        _miniSiteID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _miniSiteID;
    
        public virtual string CategoryStatus
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> MinimumPrice
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> MinimumPriceExempted
        {
            get;
            set;
        }
    
        public virtual string StoreUrl
        {
            get;
            set;
        }
    
        public virtual string SortType
        {
            get;
            set;
        }
    
        public virtual string HtmlContent
        {
            get;
            set;
        }
    
        public virtual string CategoryPathSEO
        {
            get;
            set;
        }

        #endregion

        #region Validation
    	
    	public bool validate() {
    		error_message = new List<ErrorMessage>();
    	   		 if (Storeid == null) {
						 error_message.Add(new ErrorMessage("Storeid", "Storeid can not be Null "));
				}

    	   
    	   if(error_message.Count>0) {
    	   	return false;
    	   }else {
    	    return true;
    	   }
    	
    	}
    	
    	/* public void Write()
        {
            Type type = typeof(ProductCategory); // Get type pointer
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
    
        public virtual ICollection<ProductCategory> ChildCategories
        {
            get
            {
                if (_childCategories == null)
                {
                    var newCollection = new FixupCollection<ProductCategory>();
                    newCollection.CollectionChanged += FixupChildCategories;
                    _childCategories = newCollection;
                }
                return _childCategories;
            }
            set
            {
                if (!ReferenceEquals(_childCategories, value))
                {
                    var previousValue = _childCategories as FixupCollection<ProductCategory>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupChildCategories;
                    }
                    _childCategories = value;
                    var newValue = value as FixupCollection<ProductCategory>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupChildCategories;
                    }
                }
            }
        }
        private ICollection<ProductCategory> _childCategories;
    
        public virtual ProductCategory ParentCategory
        {
            get { return _parentCategory; }
            set
            {
                if (!ReferenceEquals(_parentCategory, value))
                {
                    var previousValue = _parentCategory;
                    _parentCategory = value;
                    FixupParentCategory(previousValue);
                }
            }
        }
        private ProductCategory _parentCategory;
    
        public virtual Store Store
        {
            get { return _store; }
            set
            {
                if (!ReferenceEquals(_store, value))
                {
                    var previousValue = _store;
                    _store = value;
                    FixupStore(previousValue);
                }
            }
        }
        private Store _store;
    
        public virtual ICollection<ProductCategroyMapping> ProductCategroyMappings
        {
            get
            {
                if (_productCategroyMappings == null)
                {
                    var newCollection = new FixupCollection<ProductCategroyMapping>();
                    newCollection.CollectionChanged += FixupProductCategroyMappings;
                    _productCategroyMappings = newCollection;
                }
                return _productCategroyMappings;
            }
            set
            {
                if (!ReferenceEquals(_productCategroyMappings, value))
                {
                    var previousValue = _productCategroyMappings as FixupCollection<ProductCategroyMapping>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupProductCategroyMappings;
                    }
                    _productCategroyMappings = value;
                    var newValue = value as FixupCollection<ProductCategroyMapping>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupProductCategroyMappings;
                    }
                }
            }
        }
        private ICollection<ProductCategroyMapping> _productCategroyMappings;
    
        public virtual RuleSet RuleSet
        {
            get { return _ruleSet; }
            set
            {
                if (!ReferenceEquals(_ruleSet, value))
                {
                    var previousValue = _ruleSet;
                    _ruleSet = value;
                    FixupRuleSet(previousValue);
                }
            }
        }
        private RuleSet _ruleSet;
    
        public virtual ICollection<CrossSellProduct> CrossSellProducts
        {
            get
            {
                if (_crossSellProducts == null)
                {
                    var newCollection = new FixupCollection<CrossSellProduct>();
                    newCollection.CollectionChanged += FixupCrossSellProducts;
                    _crossSellProducts = newCollection;
                }
                return _crossSellProducts;
            }
            set
            {
                if (!ReferenceEquals(_crossSellProducts, value))
                {
                    var previousValue = _crossSellProducts as FixupCollection<CrossSellProduct>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCrossSellProducts;
                    }
                    _crossSellProducts = value;
                    var newValue = value as FixupCollection<CrossSellProduct>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCrossSellProducts;
                    }
                }
            }
        }
        private ICollection<CrossSellProduct> _crossSellProducts;
    
        public virtual ICollection<ExtendedCategory> ExtendedCategories
        {
            get
            {
                if (_extendedCategories == null)
                {
                    var newCollection = new FixupCollection<ExtendedCategory>();
                    newCollection.CollectionChanged += FixupExtendedCategories;
                    _extendedCategories = newCollection;
                }
                return _extendedCategories;
            }
            set
            {
                if (!ReferenceEquals(_extendedCategories, value))
                {
                    var previousValue = _extendedCategories as FixupCollection<ExtendedCategory>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupExtendedCategories;
                    }
                    _extendedCategories = value;
                    var newValue = value as FixupCollection<ExtendedCategory>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupExtendedCategories;
                    }
                }
            }
        }
        private ICollection<ExtendedCategory> _extendedCategories;
    
        public virtual MiniSite MiniSite
        {
            get { return _miniSite; }
            set
            {
                if (!ReferenceEquals(_miniSite, value))
                {
                    var previousValue = _miniSite;
                    _miniSite = value;
                    FixupMiniSite(previousValue);
                }
            }
        }
        private MiniSite _miniSite;
    
        public virtual ICollection<ReplicationCategoryProductsMapping> ReplicationCategoryProductsMappings
        {
            get
            {
                if (_replicationCategoryProductsMappings == null)
                {
                    var newCollection = new FixupCollection<ReplicationCategoryProductsMapping>();
                    newCollection.CollectionChanged += FixupReplicationCategoryProductsMappings;
                    _replicationCategoryProductsMappings = newCollection;
                }
                return _replicationCategoryProductsMappings;
            }
            set
            {
                if (!ReferenceEquals(_replicationCategoryProductsMappings, value))
                {
                    var previousValue = _replicationCategoryProductsMappings as FixupCollection<ReplicationCategoryProductsMapping>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupReplicationCategoryProductsMappings;
                    }
                    _replicationCategoryProductsMappings = value;
                    var newValue = value as FixupCollection<ReplicationCategoryProductsMapping>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupReplicationCategoryProductsMappings;
                    }
                }
            }
        }
        private ICollection<ReplicationCategoryProductsMapping> _replicationCategoryProductsMappings;
    
        public virtual ICollection<ReplicationCategoryProductsMapping> ReplicationCategoryProductsMappings1
        {
            get
            {
                if (_replicationCategoryProductsMappings1 == null)
                {
                    var newCollection = new FixupCollection<ReplicationCategoryProductsMapping>();
                    newCollection.CollectionChanged += FixupReplicationCategoryProductsMappings1;
                    _replicationCategoryProductsMappings1 = newCollection;
                }
                return _replicationCategoryProductsMappings1;
            }
            set
            {
                if (!ReferenceEquals(_replicationCategoryProductsMappings1, value))
                {
                    var previousValue = _replicationCategoryProductsMappings1 as FixupCollection<ReplicationCategoryProductsMapping>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupReplicationCategoryProductsMappings1;
                    }
                    _replicationCategoryProductsMappings1 = value;
                    var newValue = value as FixupCollection<ReplicationCategoryProductsMapping>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupReplicationCategoryProductsMappings1;
                    }
                }
            }
        }
        private ICollection<ReplicationCategoryProductsMapping> _replicationCategoryProductsMappings1;
    
        public virtual ICollection<CategoriesGlobalResource> CategoriesGlobalResources
        {
            get
            {
                if (_categoriesGlobalResources == null)
                {
                    var newCollection = new FixupCollection<CategoriesGlobalResource>();
                    newCollection.CollectionChanged += FixupCategoriesGlobalResources;
                    _categoriesGlobalResources = newCollection;
                }
                return _categoriesGlobalResources;
            }
            set
            {
                if (!ReferenceEquals(_categoriesGlobalResources, value))
                {
                    var previousValue = _categoriesGlobalResources as FixupCollection<CategoriesGlobalResource>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCategoriesGlobalResources;
                    }
                    _categoriesGlobalResources = value;
                    var newValue = value as FixupCollection<CategoriesGlobalResource>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCategoriesGlobalResources;
                    }
                }
            }
        }
        private ICollection<CategoriesGlobalResource> _categoriesGlobalResources;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupParentCategory(ProductCategory previousValue, bool skipKeys = false)
        {
            if (previousValue != null && previousValue.ChildCategories.Contains(this))
            {
                previousValue.ChildCategories.Remove(this);
            }
    
            if (ParentCategory != null)
            {
                if (!ParentCategory.ChildCategories.Contains(this))
                {
                    ParentCategory.ChildCategories.Add(this);
                }
                if (Storeid != ParentCategory.Storeid)
                {
                    Storeid = ParentCategory.Storeid;
                }
                if (ParentCategoryID != ParentCategory.CategoryID)
                {
                    ParentCategoryID = ParentCategory.CategoryID;
                }
            }
            else if (!_settingFK && !skipKeys)
            {
                ParentCategoryID = null;
            }
        }
    
        private void FixupStore(Store previousValue)
        {
            if (Store != null)
            {
                if (Storeid != Store.StoreID)
                {
                    Storeid = Store.StoreID;
                }
            }
        }
    
        private void FixupRuleSet(RuleSet previousValue)
        {
            if (previousValue != null && previousValue.ProductCategories.Contains(this))
            {
                previousValue.ProductCategories.Remove(this);
            }
    
            if (RuleSet != null)
            {
                if (!RuleSet.ProductCategories.Contains(this))
                {
                    RuleSet.ProductCategories.Add(this);
                }
                if (RuleSetId != RuleSet.RuleSetID)
                {
                    RuleSetId = RuleSet.RuleSetID;
                }
            }
            else if (!_settingFK)
            {
                RuleSetId = null;
            }
        }
    
        private void FixupMiniSite(MiniSite previousValue)
        {
            if (MiniSite != null)
            {
                if (MiniSiteID != MiniSite.ID)
                {
                    MiniSiteID = MiniSite.ID;
                }
            }
            else if (!_settingFK)
            {
                MiniSiteID = null;
            }
        }
    
        private void FixupChildCategories(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ProductCategory item in e.NewItems)
                {
                    item.ParentCategory = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductCategory item in e.OldItems)
                {
                    if (ReferenceEquals(item.ParentCategory, this))
                    {
                        item.ParentCategory = null;
                    }
                }
            }
        }
    
        private void FixupProductCategroyMappings(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ProductCategroyMapping item in e.NewItems)
                {
                    item.ProductCategory = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductCategroyMapping item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory, this))
                    {
                        item.ProductCategory = null;
                    }
                }
            }
        }
    
        private void FixupCrossSellProducts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CrossSellProduct item in e.NewItems)
                {
                    item.ProductCategory = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CrossSellProduct item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory, this))
                    {
                        item.ProductCategory = null;
                    }
                }
            }
        }
    
        private void FixupExtendedCategories(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ExtendedCategory item in e.NewItems)
                {
                    item.ProductCategory = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ExtendedCategory item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory, this))
                    {
                        item.ProductCategory = null;
                    }
                }
            }
        }
    
        private void FixupReplicationCategoryProductsMappings(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ReplicationCategoryProductsMapping item in e.NewItems)
                {
                    item.ProductCategory = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ReplicationCategoryProductsMapping item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory, this))
                    {
                        item.ProductCategory = null;
                    }
                }
            }
        }
    
        private void FixupReplicationCategoryProductsMappings1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ReplicationCategoryProductsMapping item in e.NewItems)
                {
                    item.ProductCategory1 = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ReplicationCategoryProductsMapping item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory1, this))
                    {
                        item.ProductCategory1 = null;
                    }
                }
            }
        }
    
        private void FixupCategoriesGlobalResources(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CategoriesGlobalResource item in e.NewItems)
                {
                    item.ProductCategory = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CategoriesGlobalResource item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory, this))
                    {
                        item.ProductCategory = null;
                    }
                }
            }
        }

        #endregion

    }
}
