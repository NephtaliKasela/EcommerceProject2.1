using EcommerceProject.DTOs.City;
using EcommerceProject.DTOs.Country;
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
		public List<GetCountryDTO> Countries { get; set; }
		public List<GetCityDTO> Cities { get; set; }

		public UpdateProductRealEstate_action()
		{
			Product = new GetProductRealEstateDTO();
			Subcategories = new List<GetSubcategoryRealEstateDTO>();
			Stores = new List<GetStoreDTO>();
			Countries = new List<GetCountryDTO>();
			Cities = new List<GetCityDTO>();
		}
	}
}
