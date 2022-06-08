using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product entity)
        {
            await _productRepository.AddAsync(entity);
        }

        public async Task<IEnumerable<Product>> FindAsync(Expression<Func<Product, bool>> predicate)
        {
            return await _productRepository.FindAsync(predicate);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            // Validte If Exist
            return product;
        }

        public async Task RemoveAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.RemoveAsync(product);
        }

        public async Task UpdateAsync(int id, Product entity)
        {
            // Validate if Exist
            await _productRepository.UpdateAsync(entity);
        }
        public async Task DeleteAllByCategoryIdAsync(int id)
        {
            await _productRepository.DeleteAllByCategoryId(id);

        }
        public async Task<IEnumerable<Product>> GetAllBycategoryIdAsync(int id)
        {
            return await _productRepository.GetAllBycategoryId(id);

        }
    }
}
