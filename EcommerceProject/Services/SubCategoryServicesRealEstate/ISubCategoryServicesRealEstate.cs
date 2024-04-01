using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate;
using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Models;

namespace EcommerceProject.Services.SubCategoryServicesRealEstate
{
	public interface ISubCategoryServicesRealEstate
	{
		Task<ServiceResponse<List<GetSubcategoryRealEstateDTO>>> GetAllSubcategoriesRealEstate();
		Task<ServiceResponse<GetSubcategoryRealEstateDTO>> GetSubcategoryRealEstateById(int id);
		//Task<ServiceResponse<List<GetSubcategoryRealEstateDTO>>> AddSubcategoryRealEstate(AddSubcategoryRealEstateDTO newSubcategory, GetCategoryDTO category);
		Task<ServiceResponse<List<GetSubcategoryRealEstateDTO>>> AddSubcategoryRealEstate(AddSubcategoryRealEstateDTO newSubcategory);
		Task<ServiceResponse<GetSubcategoryRealEstateDTO>> UpdateSubcategoryRealEstate(UpdateSubcategoryRealEstateDTO updatedSubcategory);
		Task<ServiceResponse<List<GetSubcategoryRealEstateDTO>>> DeleteSubcategoryRealEstate(int id);
	}
}
