using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.SUbCategory;

namespace EcommerceProject.DTOs.Actions
{
	public class AddProduct_action
	{
		public List<GetStoreDTO> Stores { get; set; } = new List<GetStoreDTO>();
		public List<GetSubCategoryDTO> Subcategories { get; set; } = new List<GetSubCategoryDTO>();
	}
}
