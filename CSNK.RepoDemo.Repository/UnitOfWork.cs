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

        public UnitOfWork(BlogsDBContext context)
        {
            _context = context;
                        
        }

        private IBlogRepository _blog;
        public IBlogRepository Blog => _blog ?? (_blog = new BlogRepository(_context));
        

        private IPostRepository _post;
        public IPostRepository Post => _post ?? (_post = new PostRepository(_context));


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
