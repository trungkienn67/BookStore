using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
