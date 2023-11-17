using Microsoft.AspNetCore.Mvc;

namespace FammsMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
