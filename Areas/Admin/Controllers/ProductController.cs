using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductController : Controller
    {
        public  IActionResult Index()
        {

            return View();
        }
        public IActionResult Create()
        {

            return View("Create");
        }              
    }

}
