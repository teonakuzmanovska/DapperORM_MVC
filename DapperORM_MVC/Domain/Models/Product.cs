using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM_MVC.Domain.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int LastUserId { get; set; }
        public DateTime? LastDateUpdated { get; set; }

        // M:M relationship between orders and products
        //public List<OrderDetails> OrderDetails { get; set; }
    }
}