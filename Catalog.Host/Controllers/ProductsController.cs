using Catalog.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IList<Product> _list;
        private readonly int _size = 10;

        public ProductsController()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            _list = new List<Product>();

            for (int i = 0; i < _size; i++)
            {
                _list.Add(new Product(i, $"Product_{i}", $"Catalog_{rand.Next(33, 77)}"));
            }
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_list);
        }
    }
}
