using E_commerceSystem.Application.Contracts.ProductAPI;
using Microsoft.AspNetCore.Mvc;
namespace E_commerceSystem.ProductAPI.Controllers;
public class ProductsController : ConBase
{
    private readonly IProductRepository _repo;
    public ProductsController(IProductRepository repo)
    {
        _repo = repo;
    }
    // GET: api/<ProductsController>
    [HttpGet("get-all-product")]
    public async Task<IActionResult> Get()
    {
        var result = await _repo.GetAllProductsAsync();
        return Ok(result);
    }

    // GET api/<ProductsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ProductsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ProductsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ProductsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
