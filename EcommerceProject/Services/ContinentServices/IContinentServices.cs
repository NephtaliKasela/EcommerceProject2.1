using EcommerceProject.DTOs.Continent;
using EcommerceProject.Models;

namespace EcommerceProject.Services.ContinentServices
{
    public interface IContinentServices
    {
        Task<ServiceResponse<List<GetContinentDTO>>> GetAllContinents();
        Task<ServiceResponse<GetContinentDTO>> GetCategoryById(int id);
        Task<ServiceResponse<List<GetContinentDTO>>> AddContinent(AddContinentDTO newContinent);
        Task<ServiceResponse<GetContinentDTO>> UpdateContinent(UpdateContinentDTO updatedContinent);
        Task<ServiceResponse<List<GetContinentDTO>>> DeleteContinent(int id);
    }
}
