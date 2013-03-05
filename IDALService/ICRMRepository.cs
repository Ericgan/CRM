using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRM.Model;

namespace CRM.IDALServices
{
    public interface ICRMRepository : IRepository<PkgOrder>
    {
        IEnumerable<PkgOrder> GetPkgOrders();

        PkgOrder GetPkgOrder(int pkgOrderId);
    }
}
