using CSNK.RepoDemo.Domain.Models;
using CSNK.RepoDemo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNK.RepoDemo.Repository
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogsDBContext context) : base(context)
        {

        }
    }
}
