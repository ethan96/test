﻿using eStore.POCOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.POCOS
{
    public partial class KitThemeMappingDetail
    {
        private KitThemeMappingDetailHelper _helper = null;

        public KitThemeMappingDetailHelper helper
        {
            get { return _helper; }
            set { _helper = value; }
        }

        public int save()
        {
            if (_helper == null)
                _helper = new KitThemeMappingDetailHelper();
            return _helper.save(this);
        }

        public int delete()
        {
            if (_helper == null)
                _helper = new KitThemeMappingDetailHelper();
            return _helper.delete(this);
        }
    }
}
