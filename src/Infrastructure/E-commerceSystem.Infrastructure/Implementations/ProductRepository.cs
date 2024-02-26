using E_commerceSystem.Application.Contracts;
using E_commerceSystem.Application.DTOs;
using E_commerceSystem.Domain.Entities;

namespace E_commerceSystem.Infrastructure.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public Task<ServiceResponse> AddProductAsync(Product obj)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> UpdateProductAsync(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
