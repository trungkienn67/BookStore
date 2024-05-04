using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
