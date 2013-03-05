using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.IDALServices
{
    public interface IDALContext : IUnitOfWork
    {
        ICRMRepository PkgOrders { get; }
    }
}
