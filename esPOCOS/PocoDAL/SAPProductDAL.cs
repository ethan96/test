using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eStore.POCOS.DAL;

 namespace eStore.POCOS{ 

public partial class SAPProduct{

    private SAPProductHelper _helper = null;

    public SAPProductHelper helper
    {
        get { return _helper; }
        set { _helper = value; }
    }

    public int save()
    {
        if (_helper == null)
            _helper = new SAPProductHelper();
        return _helper.save(this);
    }
} 
 }