﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRM.IDALServices;

namespace CRM.IDALServices.Test.Fake
{
    public class FakeDALContext : IDALContext
    {
        private ICRMRepository pkgOrderRepository = null;

        public ICRMRepository PkgOrders
        {
            get
            {
                if (pkgOrderRepository == null)
                    pkgOrderRepository = new FakeCRMRepository();
                return pkgOrderRepository;
            }
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}