﻿using DapperORM_MVC.Domain.Models;
using DapperORM_MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM_MVC.Service
{
    public class ProductService
    {
        CategoryRepository categoryRepository;
        ProductRepository productRepository;

        public ProductService(string connectionString)
        {
            categoryRepository = new CategoryRepository(connectionString);
            productRepository = new ProductRepository(connectionString);
        }

        public void DropProductsTableIfExists()
        {
            productRepository.DropProductsTableIfExists();
        }

        public void CreateProductsTable()
        {
            productRepository.CreateProductsTable();
        }

        public void InsertProducts()
        {
            Random random = new Random();
            var categories = categoryRepository.GetAllCategories();

            for (var i = 0; i <= 6; i++)
            {
                var newProduct = new
                {
                    ProductName = "Product " + i,
                    SupplierId = 1,
                    CategoryId = categories.ElementAt(random.Next(0, 2)).Id,
                    QuantityPerUnit = 10,
                    UnitPrice = 19,
                    UnitsInStock = 100,
                    UnitsOnOrder = 20,
                    ReorderLevel = 10,
                    Discontinued = false,
                    LastUserId = 1,
                    LastDateUpdated = DateTime.Now
                };

                productRepository.InsertProduct(newProduct);
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            Console.WriteLine("List of all products: ");
            var products = productRepository.GetAllProducts();

            return products;
        }
    }
}