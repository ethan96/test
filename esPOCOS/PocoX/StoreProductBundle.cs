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
    public partial class StoreProductBundle
    {
        public enum StoreProductBundleType
        {
            BundleOnly,
            BundleWith,
            Solution,
            Other
        }
       private StoreProductBundleType? _bundleTypeX;
        public StoreProductBundleType bundleTypeX
        {
            get {
                if (!_bundleTypeX.HasValue)
                {
                    StoreProductBundleType rlt = StoreProductBundleType.Other;
                    Enum.TryParse<StoreProductBundleType>(BundleType, out rlt);
                    _bundleTypeX = rlt;
                }
                return _bundleTypeX.GetValueOrDefault(StoreProductBundleType.Other);
            }
        }





    }
}
