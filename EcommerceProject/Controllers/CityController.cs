﻿using EcommerceProject.DTOs.Actions;
using EcommerceProject.DTOs.City;
using EcommerceProject.DTOs.Country;
using EcommerceProject.Services.CityServices;
using EcommerceProject.Services.ContinentServices;
using EcommerceProject.Services.CountryServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
	public class CityController : Controller
	{
		private readonly ICountryServices _countryServices;
		private readonly ICityServices _cityServices;

		public CityController(ICountryServices countryServices, ICityServices cityServices)
		{
			_countryServices = countryServices;
			_cityServices = cityServices;
		}

		public async Task<IActionResult> AddCity()
		{
			var countries = await _countryServices.GetAllCountries();
			return View(countries.Data);
		}

		[HttpGet]
		public async Task<IActionResult> GetCity()
		{
			var cities = await _cityServices.GetAllCities();
			return View(cities.Data);
		}

		public async Task<IActionResult> UpdateCity(int id)
		{
			var city = await _cityServices.GetCityById(id);
			var countries = await _countryServices.GetAllCountries();

			var v = new UpdateCity_action();
			v.City = city.Data;
			v.Countries = countries.Data;

			return View(v);
		}

		[HttpPost]
		public async Task<IActionResult> SaveAddCity(AddCityDTO newCity)
		{
			await _cityServices.AddCity(newCity);

			return RedirectToAction("GetCity");
		}

		[HttpPost]
		public async Task<IActionResult> SaveUpdateCity(UpdateCityDTO updatedCity)
		{
			await _cityServices.UpdateCity(updatedCity);
			return RedirectToAction("GetCity");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCity(int id)
		{
			await _cityServices.DeleteCity(id);
			return RedirectToAction("GetCity");
		}
	}
}
