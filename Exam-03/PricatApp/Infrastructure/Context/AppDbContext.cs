using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Context
{
   public class AppDbContext : DbContext
   {
      public AppDbContext()
      {
      }

      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
      }

      public DbSet<Category> Categories { get; set; }
      public DbSet<Product> Products { get; set; }
    }
}