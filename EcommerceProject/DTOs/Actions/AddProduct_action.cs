using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Subcategory;

namespace EcommerceProject.DTOs.Actions
{
	public class AddProduct_action
	{
		public List<GetStoreDTO> Stores { get; set; } = new List<GetStoreDTO>();
		public List<GetSubcategoryDTO> Subcategories { get; set; } = new List<GetSubcategoryDTO>();
	}
}
