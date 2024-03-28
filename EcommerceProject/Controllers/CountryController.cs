using EcommerceProject.DTOs.Continent;
using EcommerceProject.DTOs.Country;
using EcommerceProject.Services.ContinentServices;
using EcommerceProject.Services.CountryServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
	public class CountryController : Controller
	{
		private readonly IContinentServices _continentServices;
		private readonly ICountryServices _countryServices;

		public CountryController(IContinentServices continentServices, ICountryServices countryServices)
		{
			_continentServices = continentServices;
			_countryServices = countryServices;
		}

		public async Task<IActionResult> AddCountry()
		{
			var continents = await _continentServices.GetAllContinents();
			return View(continents.Data);
		}

		[HttpGet]
		public async Task<IActionResult> GetCountry()
		{
			var countries = await _countryServices.GetAllCountries();
			return View(countries.Data);
		}

		public async Task<IActionResult> UpdateCountry(int id)
		{
			var country = await _countryServices.GetCountryById(id);
			return View(country.Data);
		}

		[HttpPost]
		public async Task<IActionResult> SaveAddCountry(AddCountryDTO newCountry)
		{
			await _countryServices.AddCountry(newCountry);

			return RedirectToAction("GetCountry");
		}

		[HttpPost]
		public async Task<IActionResult> SaveUpdateCountry(UpdateCountryDTO updatedCountry)
		{
			await _countryServices.UpdateCountry(updatedCountry);
			return RedirectToAction("GetCountry");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCountry(int id)
		{
			await _countryServices.DeleteCountry(id);
			return RedirectToAction("GetCountry");
		}
	}
}
