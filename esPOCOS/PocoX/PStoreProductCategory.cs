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
using eStore.POCOS.DAL;

using System.Linq;
using System.Text.RegularExpressions;

namespace eStore.POCOS
{
    public partial class PStoreProductCategory
    {
        public PStore pstoreX
        {
            get;
            set;
        }
        private List<PStoreProductCategory> _childCategoriesX;
        public List<PStoreProductCategory> childCategoriesX
        {
            get
            {
                if (_childCategoriesX == null)
                {
                    PStoreProductCategoryHelper helper = new PStoreProductCategoryHelper();
                    _childCategoriesX = helper.getSubCategories(pstoreX, this);
                }
                return _childCategoriesX;
            }

        }
        private PStoreProductCategory _parentX;
        public PStoreProductCategory parentX
        {
            get
            {
                if (_parentX == null)
                {
                    PStoreProductCategoryHelper helper = new PStoreProductCategoryHelper();
                    _parentX = helper.getParent(pstoreX, this);
                }
                return _parentX;
            }

        }
        public PStoreProductCategory getRootCategory()
        {
            if (this.parentX == null)
                return this;
            else
            {
                return this.parentX.getRootCategory();
            }
        }
        private List<PStoreProduct> _productList = null;
        public List<PStoreProduct> productList
        {
            get
            {
                if (_productList == null)
                {
                    if (pstoreX == null)
                        return new List<PStoreProduct>();

                    PStoreProductCategoryHelper helper = new PStoreProductCategoryHelper();
                    _productList = new List<PStoreProduct>();
                    if (this.childCategoriesX.Count > 0)
                    {
                        foreach (PStoreProductCategory pc in this.childCategoriesX)
                        {
                            _productList.AddRange(pc.productList);
                        }
                    }
                    else
                    {
                        _productList = helper.getProducts(pstoreX.storeX, this);
                    }

                
                }
                return _productList;
            }
        }

                private List< SpecFilter> _filter;
        public  List< SpecFilter> filter
        {
            get {
                if (_filter == null)
                {    
                    PStoreProductCategoryHelper helper = new PStoreProductCategoryHelper();
                    _filter = helper.getSpecFilter(this);
                    if (_filter == null)
                        _filter = new List<SpecFilter>();
                }
                return _filter;
            }
        }

        public class SpecFilter {
            public string AttributeName { get; set; }
            public List<SpecFilterValue> Values { get; set; }
        }
        public class SpecFilterValue
        {
            private static Dictionary<string,long> _units;
            private static Dictionary<string, long> units
            {
                get {
                    if (_units == null)
                    {
                        _units = new Dictionary<string, long>();
                        _units.Add("K", 1024L);
                        _units.Add("KB", 1024L);
                        _units.Add("M", 1024L * 1024L);
                        _units.Add("MB", 1024L * 1024L);
                        _units.Add("G", 1024L * 1024L * 1024L);
                        _units.Add("T", 1024L * 1024L * 1024L * 1024L);
                        _units.Add("GB", 1024L * 1024L * 1024L);
                        _units.Add("TB", 1024L * 1024L * 1024L * 1024L);
                        units.Add("MB/S", 1024L * 1024L);
                        units.Add("GB/S", 1024L * 1024L * 1024L);
                    }
                    return _units;
                }
            }
            public string Name { get; set; }
            public string Products { get; set; }
            public int Count { get; set; }

            public long Sequnce
            {
                get {
                  
                
                    if (string.IsNullOrEmpty(Name))
                        return 0;
                    try
                    {
                        Regex regexObj = new Regex(@"(?<number>^[-+]?\b[0-9]*\.?[0-9]+(?:[eE][-+]?[0-9]+)?)+(?<unit>.*)");
                        Match match = regexObj.Match(Name);
                        if (match.Success)
                        {
                            string snumber = match.Groups["number"].Value;
                            string unitname = match.Groups["unit"].Value.Trim().ToUpper();
                            long value = 0L;
                            if (long.TryParse(snumber, out value))
                            {
                                if (units.ContainsKey(unitname))
                                { return value * units[unitname]; }
                                else
                                {
                                    return value;
                                }
                           
                            }
                            else
                            {
                                return 0;
                            }
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        return 0;
                    }
  
                }
            }

        }

        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaTitle { get; set; }
    }
}
