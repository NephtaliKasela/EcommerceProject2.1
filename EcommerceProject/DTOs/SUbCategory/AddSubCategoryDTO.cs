using EcommerceProject.Models;

namespace EcommerceProject.DTOs.Subcategory
{
    public class AddSubcategoryDTO
    {
		public string Name { get; set; }
        public string Description { get; set; }
		// Other properties specific to the category

		public Models.Category Category { get; set; }
		public string CategoryId { get; set; }
	}
}
