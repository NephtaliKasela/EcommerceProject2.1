using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Services.CategoryServices;
using EcommerceProject.Services.SubCategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices subCategoryServices)
        {
            _categoryServices = subCategoryServices;
        }

        

        [HttpPost]
        public IActionResult SaveAddCategory(AddCategoryDTO newCategory)
        {
            _categoryServices.AddCategory(newCategory);

            return RedirectToAction("GetCategory", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> SaveUpdateCategory(UpdateCategoryDTO updatedSubCategory)
        {
            var category = await _categoryServices.UpdateCategory(updatedSubCategory);
            return RedirectToAction("GetCategory", "Admin");
        }

        public IActionResult DeleteSubCategory()
        {
            return View();
        }

        public async Task<IActionResult> SaveDeleteCategory(int id)
        {
			var subCategory = await _categoryServices.DeleteCategory(id);
			return RedirectToAction("GetCategory", "Admin");
		}
    }
}
