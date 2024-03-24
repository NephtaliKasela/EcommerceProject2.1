using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Models;
using System.Runtime.CompilerServices;

namespace EcommerceProject.Services.SubCategoryServices
{
    public interface ISubCategoryServices
    {
        Task<ServiceResponse<List<GetSubCategoryDTO>>> GetAllSubCategories();
		Task<ServiceResponse<GetSubCategoryDTO>> GetSubCategoryById(int id);

		Task<ServiceResponse<List<GetSubCategoryDTO>>> AddSubCategory(AddSubCategoryDTO newProduct);
        Task<ServiceResponse<GetSubCategoryDTO>> UpdateSubCategory(UpdateSubCategoryDTO updatedSubCategory);
        Task<ServiceResponse<List<GetSubCategoryDTO>>> DeleteSubCategory(int id);
    }
}
