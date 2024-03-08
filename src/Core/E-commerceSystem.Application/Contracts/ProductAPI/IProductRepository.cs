using E_commerceSystem.Application.DTOs;
using E_commerceSystem.Domain.Entities;

namespace E_commerceSystem.Application.Contracts.ProductAPI;
public interface IProductRepository
{
    Task<ServiceResponse> AddProductAsync(Product obj);
    Task<ServiceResponse> UpdateProductAsync(Product obj);
    Task<ServiceResponse> DeleteProductAsync(int id);
    Task<Product> GetProductByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
