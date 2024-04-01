using EcommerceProject.Services.CategoryServices;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.StoreServices;
using EcommerceProject.Services.SubCategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers.admin
{
    public class AdminController : Controller
    {
		private readonly ISubCategoryServices _subCategoryServices;
		private readonly ICategoryServices _categoryServices;
        private readonly IStoreServices _storeServices;
        private readonly IProductService _productService;

		public AdminController(IStoreServices storeServices, IProductService productService, ISubCategoryServices subCategoryServices, ICategoryServices categoryServices)
		{
            _storeServices = storeServices;
            _productService = productService;
			_subCategoryServices = subCategoryServices;
			_categoryServices = categoryServices;
		}

		public IActionResult Index()
        {
            return View();
        }

		// Subcategory
		public async Task<IActionResult> AddSubCategory()
        {
            var category = await _categoryServices.GetCategories();
            return View(category.Data);
        }
        
        public async Task<IActionResult> GetSubcategory()
        {
			var subCategory = await _subCategoryServices.GetAllSubCategories();
			return View(subCategory.Data);
        }

        public async Task<IActionResult> UpdateSubcategory(int id)
        {
            var sc = await _subCategoryServices.GetSubCategoryById(id);   
			return View(sc.Data);
		}

        // Store
        public IActionResult AddStore()
        {
            return View();
        }

        public async Task<IActionResult> GetStore()
        {
            var stores = await _storeServices.GetAllStores();
            return View(stores.Data);
        }

        public async Task<IActionResult> UpdateStore(int id)
        {
            var store = await _storeServices.GetStoreById(id);
            return View(store.Data);
        }
    }
}
