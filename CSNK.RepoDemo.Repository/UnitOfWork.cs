using CSNK.RepoDemo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNK.RepoDemo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogsDBContext _context;

        public UnitOfWork(BlogsDBContext context, 
                            IBlogRepository blog,
                            IPostRepository post)
        {
            _context = context;

            Blog = blog;
            Post = post;
        }

        public IBlogRepository Blog { get; }
        public IPostRepository Post { get; }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
