using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Common;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
   public class CategoryRepository : Repository<Category>, ICategoryRepository
   {
      public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
      {
      }
   }
}