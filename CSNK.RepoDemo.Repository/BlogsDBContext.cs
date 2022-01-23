using CSNK.RepoDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNK.RepoDemo.Repository
{
    public partial class BlogsDBContext : DbContext
    {
        public BlogsDBContext()
        { 

        }

        public BlogsDBContext(DbContextOptions<BlogsDBContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; } = null!;

        public DbSet<Blog> Blog { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blogs");
                entity.Property(e => e.BlogId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Posts");

                entity.Property(e => e.PostId).ValueGeneratedNever();

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId);
            });

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
