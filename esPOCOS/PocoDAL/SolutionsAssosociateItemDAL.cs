﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eStore.POCOS.DAL;

namespace eStore.POCOS
{
    public partial class SolutionsAssosociateItem
    {
        private SolutionsAssosociateItemHelper _helper = null;

        public SolutionsAssosociateItemHelper helper
        {
            get { return _helper; }
            set { _helper = value; }
        }

        public int save()
        {
            if (_helper == null)
                _helper = new SolutionsAssosociateItemHelper();
            return _helper.save(this);
        }

        public int delete()
        {
            if (_helper == null)
                _helper = new SolutionsAssosociateItemHelper();
            return _helper.delete(this);
        }
    }
}
