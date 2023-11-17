using Microsoft.AspNetCore.Mvc;

namespace FammsMVC.Controllers
{
    public class BlogListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
