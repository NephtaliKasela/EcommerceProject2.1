using EcommerceProject.Models;

namespace EcommerceProject.DTOs.Category
{
    public class AddCategoryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // Other properties specific to the category

        public List<Subcategory> SubCategories { get; set; }
    }
}
