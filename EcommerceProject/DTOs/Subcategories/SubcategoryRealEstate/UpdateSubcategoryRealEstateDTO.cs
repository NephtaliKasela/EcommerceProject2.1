using EcommerceProject.Models.Products;

namespace EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate
{
	public class UpdateSubcategoryRealEstateDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string CategoryId { get; set; }

		// Foreign Keys
		public Models.Category Category { get; set; }
	}
}
