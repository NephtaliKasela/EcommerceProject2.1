using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceProject.Models;

namespace EcommerceProject.DTOs.Product
{
    public class GetProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }

        // Other properties specific to the product

        public Subcategory SubCategory { get; set; } // Foreign key property
        public Models.Store Store { get; set; } // Foreign key property
        public List<Models.ProductImage> ProductImages { get; set; }
    }
}