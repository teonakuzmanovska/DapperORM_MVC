using DapperORM_MVC.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DapperORM_MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            InitializeDatabase();
            PopulateDatabase();

        }

        public void InitializeDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Create instances of the services
            CategoryService categoryService = new CategoryService(connectionString);
            ProductService productService = new ProductService(connectionString);
            OrderService orderService = new OrderService(connectionString);
            OrderDetailsService orderDetailsService = new OrderDetailsService(connectionString);

            // Drop tables if they exist
            orderDetailsService.DropOrderdetailsTableIfExists();
            orderService.DropOrdersTableIfExists();
            productService.DropProductsTableIfExists();
            categoryService.DropCategoriesTableIfExists();

            // Calling functions for creating tables
            categoryService.CreateCategoriesTable();
            productService.CreateProductsTable();
            orderService.CreateOrdersTable();
            orderDetailsService.CreateOrderDetailsTable();
        }

        public void PopulateDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Create instances of the services
            CategoryService categoryService = new CategoryService(connectionString);
            ProductService productService = new ProductService(connectionString);
            OrderService orderService = new OrderService(connectionString);
            OrderDetailsService orderDetailsService = new OrderDetailsService(connectionString);

            // Inserting new categories
            categoryService.InsertCategories();

            // Inserting new products
            productService.InsertProducts();

            // Inserting new orders            
            orderService.InsertOrders();

            // Inserting new orderdetails
            orderDetailsService.InsertOrderDetails();
        }
    }
}
