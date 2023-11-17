using FammsMVC.Data;
using Microsoft.AspNetCore.Mvc;
using FammsMVC.Models;
using System.Diagnostics;

namespace FammsMVC.Controllers
{

    //{
    //    public class HomeController : Controller
    //    {
    //        private readonly DataRepository _dataRepository;

    //        public HomeController(DataRepository dataRepository)
    //        {
    //            _dataRepository = dataRepository;
    //        }

    //        public IActionResult Index()
    //        {
    //            HomeViewModel viewModel = new HomeViewModel
    //            {
    //                Products = _dataRepository.GetProducts()
    //            };

    //            return View(viewModel);
    //        }
    //    }
    //}
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Products = ProductRepository.GetProducts()
            };
            return View(model);
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