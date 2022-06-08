using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Common;
using Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task DeleteAllByCategoryId(int id)
        {
            var products = _appDbContext.Products.Where(aux => aux.CategoryId == id).ToList();
            foreach (var item in products)
            {
                _appDbContext.Remove(item);
                await _appDbContext.SaveChangesAsync();
            }
        }
        public Task<List<Product>> GetAllBycategoryId(int id)
        {
            return Task.FromResult(_appDbContext.Products.Where(aux => aux.CategoryId == id).ToList());
        }
    }
}
