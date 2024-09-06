using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.Subcategory;
using EcommerceProject.Models;

namespace EcommerceProject.Services.CategoryServices
{
    public interface ICategoryServices
    {
        Task<ServiceResponse<List<GetCategoryDTO>>> GetCategories();
        Task<ServiceResponse<GetCategoryDTO>> GetCategoryById(int id);
        Task<ServiceResponse<List<GetCategoryDTO>>> AddCategory(AddCategoryDTO newSubCategory);
        Task<ServiceResponse<GetCategoryDTO>> UpdateCategory(UpdateCategoryDTO updatedCategory);
        Task<ServiceResponse<List<GetCategoryDTO>>> DeleteCategory(int id);
    }
}
