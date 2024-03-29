using EcommerceProject.DTOs.Continent;
using EcommerceProject.DTOs.Country;

namespace EcommerceProject.DTOs.Actions
{
	public class UpdateCountry_action
	{
		public GetCountryDTO Country { get; set; }
		public List<GetContinentDTO> Continents { get; set; }
	}
}
