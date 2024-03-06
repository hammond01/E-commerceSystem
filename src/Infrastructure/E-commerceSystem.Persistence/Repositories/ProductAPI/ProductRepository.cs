using E_commerceSystem.Application.Contracts.ProductAPI;
using E_commerceSystem.Application.DTOs;
using E_commerceSystem.Domain.Entities;
using E_commerceSystem.Persistence._Share;
using E_commerceSystem.Persistence.Data.Impl;

namespace E_commerceSystem.Persistence.Repositories.ProductAPI;
public class ProductRepository : IProductRepository
{
    private readonly IDataAccess _db;
    public ProductRepository(IDataAccess db)
    {
        _db = db;
    }
    public async Task<ServiceResponse> AddProductAsync(Product obj)
    {
        try
        {
            var query = Extension.GetInsertQuery("Products", "ProductID", "ProductName", "SupplierID", "CategoryID",
                "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued");
            var result = await _db.SaveData(query, obj);
            if (result)
                return new ServiceResponse(true, "Added a new record successfully!");
            else
                return new ServiceResponse(false, "Adding a new record failed!");
        }
        catch (Exception ex)
        {
            return new ServiceResponse(false, ex.Message);
        }
    }

    public Task<ServiceResponse> DeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        try
        {
            var query = "SELECT * FROM Products";
            var result = await _db.GetData<Product, dynamic>(query, new { });
            return result.ToList();
        }
        catch
        {
            throw;
        }
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
