using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Application.Services;
using Domain.Interfaces.Repositories;
using Infrastructure.Repositories;

namespace Api.Extensions
{
   public static class ModuleCollectionExtension
   {
      public static IServiceCollection AddCoreModules(this IServiceCollection services)
      {
         // Services / Use Cases
         services.AddScoped<ICategoryService, CategoryService>();
         services.AddScoped<IProductService, ProductService>();

            return services;
      }

      public static IServiceCollection AddInfrastructureModules(this IServiceCollection services)
      {
         // Repositories
         services.AddScoped<ICategoryRepository, CategoryRepository>();
         services.AddScoped<IProductRepository, ProductRepository>();

            return services;
      }
   }
}