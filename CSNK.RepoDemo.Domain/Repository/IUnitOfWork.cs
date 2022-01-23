using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNK.RepoDemo.Domain.Repository
{
    public interface IUnitOfWork
    {
        IBlogRepository Blog { get; }

        IPostRepository Post { get; }

        int SaveChanges();
    }
}
