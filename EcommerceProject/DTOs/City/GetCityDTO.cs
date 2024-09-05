using EcommerceProject.Models;
using EcommerceProject.Models.Products;

namespace EcommerceProject.DTOs.City
{
	public class GetCityDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		// Foreign Keys
		public Models.Country Country { get; set; }

		// Product FK
		public List<BodyProduct>? ProductsRealEstate { get; set; }
	}
}
