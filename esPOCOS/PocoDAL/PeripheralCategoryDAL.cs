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
    public partial class PeripheralCatagory
    {
        private PeripheralHelper _helper = null;
         public PeripheralHelper helper
         {
             get { return _helper; }
             set { _helper = value; }
         }

         public int save()
         {
             if (_helper == null)
                 _helper = new PeripheralHelper();
             return _helper.saveCategory(this);
         }

         public int delete()
         {
             if (_helper == null)
                 _helper = new PeripheralHelper();
             return _helper.delete(this);
         }
    }
 }