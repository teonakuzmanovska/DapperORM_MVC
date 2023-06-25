using DapperORM_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperORM_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController()
        {
            string connectionString = "server=localhost;Database=OrderDB_MVC;Trusted_Connection=True;MultipleActiveResultSets=true;";
            _productService = new ProductService(connectionString);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllProducts()
        {
            var sortedProducts = _productService.GetAllProducts();
            // You can return a view or redirect to another action if needed.
            return View(sortedProducts);
        }

    }
}