using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM_MVC.Domain.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        // 1:M relationship between categories and products
        public List<Product> Products { get; set; }
    }
}