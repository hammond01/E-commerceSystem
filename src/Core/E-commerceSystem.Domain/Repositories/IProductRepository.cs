using E_commerceSystem.Domain.DTOs;
using E_commerceSystem.Domain.Entities;

namespace E_commerceSystem.Domain.Repositories;
public interface IProductRepository
{
    Task<ServiceResponse> AddProductAsync(Product obj);
    Task<ServiceResponse> UpdateProductAsync(Product obj);
    Task<ServiceResponse> DeleteProductAsync(int id);
    Task<Product> GetProductByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
