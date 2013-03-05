using CRM.Database;
using CRM.IDALServices;

namespace CRM.DALServices
{
    public class DALContext : IDALContext
    {
        private CRMDB dbContext = null;
        private ICRMRepository pkgOrderRepository = null;

        public DALContext()
        {
            this.dbContext = new CRMDB();
        }

        public ICRMRepository PkgOrders
        {
            get
            {
                if (pkgOrderRepository == null)
                {
                    pkgOrderRepository = new CRMRepository(this.dbContext);
                }

                return pkgOrderRepository;
            }
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (PkgOrders != null)
                PkgOrders.Dispose();

            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
