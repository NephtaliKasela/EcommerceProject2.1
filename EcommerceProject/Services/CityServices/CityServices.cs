using EcommerceProject.DTOs.City;
using EcommerceProject.Models;

namespace EcommerceProject.Services.CityServices
{
	public class CityServices : ICityServices
	{
		public Task<ServiceResponse<List<GetCityDTO>>> AddCity(AddCityDTO newCity)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<GetCityDTO>>> DeleteCity(int id)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<GetCityDTO>>> GetAllCities()
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<GetCityDTO>> GetCityById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<GetCityDTO>> UpdateCity(UpdateCityDTO updatedCity)
		{
			throw new NotImplementedException();
		}
	}
}
