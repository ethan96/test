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
 

namespace eStore.POCOS
{
    public partial class PeripheralProduct
    {
        public int qtyX {
            get {
                return 1;
            }
        }
        //获取中sproductId中的part
        private List<POCOS.Part> _partsX;
        public List<POCOS.Part> partsX
        {
            get 
            {
                if (_partsX == null)
                {
                    lock (this)
                    {
                        List<Part> parts = new List<Part>();
                        if (!string.IsNullOrEmpty(this.SProductID))
                        {
                            PartHelper helper = new PartHelper();
                            foreach (var itemSproductId in this.SProductID.Split(';'))
                            {
                                if (!string.IsNullOrEmpty(itemSproductId))
                                {
                                    Part peripheralPart = helper.getPart(itemSproductId, this.StoreID, true);
                                    if (peripheralPart != null)
                                        parts.Add(peripheralPart);
                                }
                            }
                        }

                        //wait until all parts are successfully retrieve to prevent multi-thread competition
                        _partsX = parts;
                    }
                }
                return _partsX;
            }
        }

        //产品是否都合格 必须都合格 
        public bool partIsOrderable
        {
            get {
                if (partsX == null || partsX.Count == 0)
                    return false;
                else
                {
                    foreach (var item in partsX)
                    {
                        if (!item.isOrderable())
                            return false;
                        if (item.getListingPrice().value <= 0)
                            return false;
                    }
                }
                return true;
            }
        }
        //是否保修 有一个合格就行
        public bool isWarrantable
        {
            get {
                if (partsX == null || partsX.Count == 0)
                    return false;
                else
                {
                    foreach (var item in partsX)
                    {
                        if (item.isWarrantable())
                            return true;
                    }
                }
                return false;
            }
        }
        //保修产品的price
        private decimal _getWarrantPrice;
        public decimal getWarrantPrice
        {
            get {
                if (_getWarrantPrice == 0)
                {
                    if (partsX != null && partsX.Count > 0)
                    {
                        foreach (var item in partsX)
                        {
                            //必须是保修
                            if (item.isWarrantable())
                                _getWarrantPrice += item.getListingPrice().value;
                        }
                    }                
                }
                return _getWarrantPrice;
            }
            set { _getWarrantPrice = value; }
        }

        private string _dependencyPartStr;
        public string dependencyPartStr
        {
            get {
                if (string.IsNullOrEmpty(_dependencyPartStr))
                {
                    if (partsX != null && partsX.Count > 0)
                    {
                        foreach (var item in partsX)
                        {
                            if (!string.IsNullOrEmpty(item.dependencyPartStr))
                            {
                                if (string.IsNullOrEmpty(_dependencyPartStr))
                                    _dependencyPartStr = item.dependencyPartStr;
                                else
                                    _dependencyPartStr += "|" + item.dependencyPartStr;
                            }
                        }
                    }   
                }
                return _dependencyPartStr; 
            }
            set { _dependencyPartStr = value; }
        }

        //有一个合格就行
        public bool hasBuiltInStorage
        {
            get
            {
                if (partsX == null || partsX.Count == 0)
                    return false;
                else
                {
                    foreach (var item in partsX)
                    {
                        if (item.hasBuiltInStorage())
                            return true;
                    }
                }
                return false;
            }
        }
        private ATP _atpx;
        public ATP atpX
        {
            get {
                if (_atpx == null)
                {
                    _atpx = new ATP(DateTime.MaxValue, 9999);
                    if (partsX != null && partsX.Count > 0)
                    {
                        foreach (var item in partsX)
                        {
                            //取最小的可用日期
                            if (_atpx.availableDate > item.atp.availableDate)
                                _atpx.availableDate = item.atp.availableDate;
                            //取最小的数量
                            if (_atpx.availableQty > item.atp.availableQty)
                                _atpx.availableQty = item.atp.availableQty;
                        }
                    }
                    else
                        _atpx.availableQty = 0;
                }
                return _atpx;
            }
            set { _atpx = value; }
        }

        //获取Peripheral Product价格
        public decimal getPeripheralProductPrice()
        {
            decimal totalPrice = 0;
            if (partsX != null && partsX.Count > 0)
            {
                foreach (var itemPart in partsX)
                {
                    if (itemPart.isOS())
                        return 0;//"Add for price";
                    else
                        totalPrice += itemPart.getListingPrice().value;
                }
            }
            return totalPrice;
        }
        //产品的  ABCInd
        private string _abcInd;
        public string ABCInd
        {
            get
            {
                if (string.IsNullOrEmpty(_abcInd))
                {
                    if (partsX != null && partsX.Count > 0)
                    {
                        foreach (var item in partsX)
                        {
                            if (!string.IsNullOrEmpty(_abcInd))
                                _abcInd += "<br>";
                            _abcInd += string.IsNullOrEmpty(item.ABCInd) ? "" : item.ABCInd;
                        }
                    }
                }
                return _abcInd;
            }
            set { _abcInd = value; }
        }
    }
}
