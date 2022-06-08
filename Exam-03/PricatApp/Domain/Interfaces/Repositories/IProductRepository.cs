using Domain.Common;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public Task DeleteAllByCategoryId(int id);
        public Task<List<Product>> GetAllBycategoryId(int id);
    }
}
