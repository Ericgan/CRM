using System.Collections.Generic;
using CRM.Model;
using CRM.IDALServices;

namespace CRM.DALServices
{
    public class CRMService : ICRMService
    {
        private IDALContext context;

        public CRMService(IDALContext context)
        {
            this.context = context;
        }

        public IEnumerable<PkgOrder> GetPkgOrders()
        {
            return context.PkgOrders.GetPkgOrders();
        }

        public PkgOrder GetPkgOrder(int pkgOrderId)
        {
            return context.PkgOrders.GetPkgOrder(pkgOrderId);
        }
    }
}
