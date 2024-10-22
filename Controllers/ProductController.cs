using Microsoft.AspNetCore.Mvc;

namespace Baby_ShoppingOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
