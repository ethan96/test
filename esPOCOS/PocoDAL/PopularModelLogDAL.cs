using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eStore.POCOS.DAL;

namespace eStore.POCOS{ 

public partial class PopularModelLog
{
    private PopularModelLogHelper _helper = null;

    public PopularModelLogHelper helper
    {
        get { return _helper; }
        set { _helper = value; }
    }

    public int save()
    {
        if (_helper == null)
            _helper = new PopularModelLogHelper();
        return _helper.save(this);
    }
}
}