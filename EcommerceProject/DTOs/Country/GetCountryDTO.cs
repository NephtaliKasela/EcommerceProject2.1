﻿using EcommerceProject.Models.Products;
using EcommerceProject.Models;

namespace EcommerceProject.DTOs.Country
{
	public class GetCountryDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		// Freign Keys
		public Models.Continent Continent { get; set; }
		public List<Models.City>? Cities { get; set; }

		// Product FK
		public List<BodyProduct>? ProductsRealEstate { get; set; }
	}
}
