using DapperORM_MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM_MVC.Service
{
    public class OrderDetailsService
    {
        OrderDetailsRepository orderDetailsRepository;
        ProductRepository productRepository;
        public OrderDetailsService(string connectionString)
        {
            orderDetailsRepository = new OrderDetailsRepository(connectionString);
            productRepository = new ProductRepository(connectionString);
        }

        public void DropOrderdetailsTableIfExists()
        {
            orderDetailsRepository.DropOrderDetailsTableIfExists();
        }

        public void CreateOrderDetailsTable()
        {
            orderDetailsRepository.CreateOrderDetailsTable();
        }

        public void InsertOrderDetails()
        {
            Random random = new Random();
            var products = productRepository.GetAllProducts();

            foreach (var product in products)
            {
                var newOrderDetails = new
                {
                    OrderId = 1, // all of the products will be placed in the first order, it doesn't matter for sorting most sold products
                    ProductId = product.Id,
                    UnitPrice = 10,
                    Quantity = random.Next(1, 20),
                    Discount = 0
                };

                orderDetailsRepository.InsertOrderDetails(newOrderDetails);
            }
        }
    }
}