using CSNK.RepoDemo.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CSNK.RepoDemo.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, string dbFile)
        {
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<BlogsDBContext>(opt => opt
                .UseSqlite($"Data Source={dbFile}"));


            return services;
        }
    }
}
