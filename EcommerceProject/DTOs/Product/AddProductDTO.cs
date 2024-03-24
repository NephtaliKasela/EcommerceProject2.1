using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceProject.Models;

namespace EcommerceProject.DTOs.Product
{
    public class AddProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }

        // Other properties specific to the product

        //public int CategoryId { get; set; } // Foreign key property
        public SubCategory SubCategory { get; set; } // Navigation property
        public Models.Store Store { get; set; } // Navigation property

        public string ProductSubCategoryId { get; set; }
        public string StoreId { get; set; }
    }
}