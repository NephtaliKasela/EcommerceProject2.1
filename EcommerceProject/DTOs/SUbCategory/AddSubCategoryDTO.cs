using EcommerceProject.Models;

namespace EcommerceProject.DTOs.SUbCategory
{
    public class AddSubCategoryDTO
    {public string Name { get; set; }
        public string Description { get; set; }
		// Other properties specific to the category

		public Models.Category Category { get; set; }
		public string CategoryId { get; set; }
	}
}
