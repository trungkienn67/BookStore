using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ContactUSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
