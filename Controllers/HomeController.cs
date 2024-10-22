using Baby_ShoppingOnline.Models;
using Baby_ShoppingOnline.Service;
using Baby_ShoppingOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baby_ShoppingOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var categories = _productService.GetCategories();
            var featuredProducts = _productService.GetFeaturedProducts();

            var viewModel = new HomePage
            {
                Categories = categories.ToList(),
                FeaturedProducts = featuredProducts.ToList()
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
