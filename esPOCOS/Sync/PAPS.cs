﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.POCOS.Sync
{
    public class PAPS : IPisSync
    {
        private PISEntities _pisentity;
        public PISEntities PISEntity
        {
            get
            {
                if (this._pisentity == null)
                    this._pisentity = new PISEntities();
                return this._pisentity;
            }

            set
            {
                this._pisentity = value;
            }
        }

        private string _catalog1
        {
            get
            {
                return "0bf0ee24-fd6d-40b2-868a-9130b692b70f";
            }
        }
        private string _catalog2
        {
            get
            {
                return string.Empty;
            }
        }

        public string getCategoryID(string productName)
        {
            return (from p in PISEntity.spGetModelByPN_estore_NEW(this._catalog1, this._catalog2, productName)
                    select p.CATEGORY_ID).FirstOrDefault();
        }

        public List<spGetModelByPN_estore_Result> getModelByPartNo(string partNo)
        {
            return (from m in PISEntity.spGetModelByPN_estore_NEW(this._catalog1, this._catalog2, partNo)
                    orderby m.DISPLAY_NAME.Length descending
                    select m).ToList();
        }
    }
}
