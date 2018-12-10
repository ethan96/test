﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eStore.POCOS.DAL;

namespace eStore.POCOS
{
    public partial class SpecAttributeValuelang
    {
        private SpecAttributeValuelangHelper _helper = null;

        public SpecAttributeValuelangHelper helper
        {
            get { return _helper; }
            set { _helper = value; }
        }


        public int save()
        {
            if (_helper == null)
                _helper = new SpecAttributeValuelangHelper();
            return _helper.save(this);
        }

        public int delete()
        {
            if (_helper == null)
                _helper = new SpecAttributeValuelangHelper();
            return _helper.delete(this);
        }
    }
}
