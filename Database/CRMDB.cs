using System.Data.Entity;
using CRM.Model;

namespace CRM.Database
{
    public class CRMDB : DbContext
    {
        public CRMDB() : base("PkgOrderDB"){ }

        public DbSet<PkgOrder> PkgOrders { get; set; }
    }
}
