using EcommerceProject.DTOs.Product.ProductRealEstate;
using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate;

namespace EcommerceProject.DTOs.Actions
{
	public class UpdateProductRealEstate_action
	{
		public GetProductRealEstateDTO Product {  get; set; }
		public List<GetSubcategoryRealEstateDTO> Subcategories { get; set; }
		public List<GetStoreDTO> Stores { get; set; }

		public UpdateProductRealEstate_action()
		{
			Product = new GetProductRealEstateDTO();
			Subcategories = new List<GetSubcategoryRealEstateDTO>();
			Stores = new List<GetStoreDTO>();
		}
	}
}
