using System.Collections.Generic;
using System.Linq;
using CRM.Model;
using CRM.Database;
using CRM.IDALServices;

namespace CRM.DALServices
{
    internal class CRMRepository : Repository<PkgOrder>, ICRMRepository
    {
        public CRMRepository(CRMDB context)
            : base(context)
        {
        }

        public IEnumerable<PkgOrder> GetPkgOrders()
        {
            return from o in DbSet
                   select o;
        }

        public PkgOrder GetPkgOrder(int pkgOrderId)
        {
            return (from o in DbSet
                    where o.OrderId == pkgOrderId
                    select o).FirstOrDefault();
        }
    }
}
