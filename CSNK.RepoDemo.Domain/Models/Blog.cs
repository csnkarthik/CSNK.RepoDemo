using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNK.RepoDemo.Domain.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Url { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
