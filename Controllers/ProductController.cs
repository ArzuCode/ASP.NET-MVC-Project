using FammsMVC.Data;
using Microsoft.AspNetCore.Mvc;
using FammsMVC.Models;

namespace FammsMVC.Controllers
{
    //{
    //public class ProductsController : Controller
    //{
    //    private readonly DataRepository _dataRepository;

    //    public ProductsController(DataRepository dataRepository)
    //    {
    //        _dataRepository = dataRepository;
    //    }

    //    public IActionResult Index()
    //    {
    //        ProductsViewModel viewModel = new ProductsViewModel
    //        {
    //            Products = _dataRepository.GetProducts()
    //        };

    //        return View(viewModel);
    //    }
    //}

public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProductIndexViewModel
            {
                Products = ProductRepository.GetProducts()
            };
            return View(model);
        }
    }
}
