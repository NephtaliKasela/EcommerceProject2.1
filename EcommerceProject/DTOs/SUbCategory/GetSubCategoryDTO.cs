using EcommerceProject.Models.Products;

namespace EcommerceProject.DTOs.Subcategory
{
    public class GetSubcategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Other properties specific to the category

        public Models.Category Category { get; set; } 
        public List<BodyProduct>? BodyProducts { get; set; }
    }
}
