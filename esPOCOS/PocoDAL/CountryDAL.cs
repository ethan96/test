using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eStore.POCOS.DAL;

namespace eStore.POCOS
{

    public partial class Country
    {
        private CountryHelper _helper = null;

        public CountryHelper helper
        {
            get { return _helper; }
            set { _helper = value; }
        }

        public int save()
        {
            if (_helper == null)
                _helper = new CountryHelper();
            return _helper.save(this);
        }

    }
}