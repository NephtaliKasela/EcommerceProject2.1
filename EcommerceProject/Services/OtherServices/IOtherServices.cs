using EcommerceProject.DTOs.Category;
using EcommerceProject.Models;

namespace EcommerceProject.Services.OtherServices
{
    public interface IOtherServices
    {
        (bool, int) CheckIfInteger(string number);
		Task<ServiceResponse<Category>> GetCategoryById(string categoryId);

	}
}
