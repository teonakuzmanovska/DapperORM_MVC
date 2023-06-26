using DapperORM_MVC.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            _productService = new ProductService(connectionString);
        }

        public ActionResult Index()
        {
            var sortedProducts = _productService.GetAllProducts();
            // You can return a view or redirect to another action if needed.
            return View(sortedProducts);
        }
    }
}