using BlogData.Abstract;
using BlogData.Concrete;
using BlogData.Concrete.EntityFramework.Context;
using BlogServices.Abstract;
using BlogServices.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BlogServices.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryManager>();
            return services;
        }

    }
}