using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Models;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.SubCategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryServices _subCategoryServices;
        public SubCategoryController(ISubCategoryServices subCategoryServices)
        {
            _subCategoryServices = subCategoryServices;
        }

        public IActionResult AddSubCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveAddSubCategory(AddSubCategoryDTO newSubCategory)
        {
            _subCategoryServices.AddSubCategory(newSubCategory);

            return RedirectToAction("GetSubcategory", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> DisplaySubCategory()
        {
            var subCategory = await _subCategoryServices.GetAllSubCategories();
            return View(subCategory.Data);
        }

        public IActionResult UpdateSubCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveUpdateSubCategory(UpdateSubCategoryDTO updatedSubCategory)
        {
            var subCategory = await _subCategoryServices.UpdateSubCategory(updatedSubCategory);
            return RedirectToAction("GetSubcategory", "Admin");
        }

        public IActionResult DeleteSubCategory()
        {
            return View();
        }

        public async Task<IActionResult> SaveDeleteSubCategory(int id)
        {
            await _subCategoryServices.DeleteSubCategory(id);
            return RedirectToAction("GetSubcategory", "Admin");
        }
    }
}
