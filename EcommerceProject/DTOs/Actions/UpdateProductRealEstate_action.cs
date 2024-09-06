using EcommerceProject.DTOs.City;
using EcommerceProject.DTOs.Country;
using EcommerceProject.DTOs.Store;

namespace EcommerceProject.DTOs.Actions
{
	public class UpdateProductRealEstate_action
	{
		public List<GetStoreDTO> Stores { get; set; }
		public List<GetCountryDTO> Countries { get; set; }
		public List<GetCityDTO> Cities { get; set; }

		public UpdateProductRealEstate_action()
		{
			Stores = new List<GetStoreDTO>();
			Countries = new List<GetCountryDTO>();
			Cities = new List<GetCityDTO>();
		}
	}
}
