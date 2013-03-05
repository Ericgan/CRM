using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.IDALServices
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
