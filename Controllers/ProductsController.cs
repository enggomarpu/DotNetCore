using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SKINET.Data;
using SKINET.Entities;

namespace SKINET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        private readonly StoreContext _storeContext;
        public ProductsController(StoreContext context)
        {
            _storeContext = context;
        }


        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _storeContext.Products.ToList();
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProductsAsync()
        {
            return  await _storeContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this is a single product";
        }

    }
}
