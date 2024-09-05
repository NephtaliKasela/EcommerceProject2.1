using System.Drawing;

namespace EcommerceProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }

        // Other properties specific to the product
        public Store Store { get; set; }
        public Subcategory SubCategory { get; set; } // Foreign key property
        public List<ProductImage>? ProductImages { get; set; } 
    }
}
