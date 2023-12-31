﻿using DapperORM_MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM_MVC.Service
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;

        public CategoryService(string connectionString)
        {
            categoryRepository = new CategoryRepository(connectionString);
        }

        public void DropCategoriesTableIfExists()
        {
            categoryRepository.DropCategoriesTableIfExists();
        }

        public void CreateCategoriesTable()
        {
            categoryRepository.CreateCategoriesTable();
        }

        public void InsertCategories()
        {
            string picture;

            for (var i = 0; i < 2; i++)
            {
                if (i % 2 == 0)
                    picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQyNDBuoXEayLO2l-GxlcRsaawFMmACc2phigkFN0j4pTvYzxo4d7V9aORbvlejfU6knCk&usqp=CAU";
                else
                    picture = "https://png.pngtree.com/png-clipart/20210311/original/pngtree-brush-circle-creative-brush-effect-png-image_6020152.jpg";

                var newCategory = new
                {
                    CategoryName = "Category " + i,
                    Description = "Category " + i + " description",
                    Picture = picture
                };

                categoryRepository.InsertCategory(newCategory);
            }
        }

        public IEnumerable<dynamic> GetAllCategories()
        {
            var categories = categoryRepository.GetAllCategories();

            return categories;
        }
    }
}