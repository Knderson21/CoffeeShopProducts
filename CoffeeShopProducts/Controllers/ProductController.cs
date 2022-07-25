using CoffeeShopProducts.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProducts.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private CoffeeShopProductDBContext context = new CoffeeShopProductDBContext();

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> result = context.Products.ToList();
            return View(result);
        }

        public IActionResult Details(int productId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == productId);
            return View(p);
        }
    }
}
