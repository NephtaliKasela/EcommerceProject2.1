using EcommerceProject.DTOs.Actions;
using EcommerceProject.DTOs.Product.ProductRealEstate;
using EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.ProductService.ProductServicesRealEstate;
using EcommerceProject.Services.StoreServices;
using EcommerceProject.Services.SubCategoryServices;
using EcommerceProject.Services.SubCategoryServicesRealEstate;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers.Products
{
    public class ProductRealEstateController : Controller
    {
        private readonly IStoreServices _storeServices;
        private readonly IProductServicesRealEstate _productServicesRealEstate;
		private readonly ISubCategoryServicesRealEstate _subCategoryServicesRealEstate;

		public ProductRealEstateController(IProductServicesRealEstate productServicesRealEstate, ISubCategoryServicesRealEstate subCategoryServicesRealEstate, IStoreServices storeServices)
        {
            _productServicesRealEstate = productServicesRealEstate;
			_subCategoryServicesRealEstate = subCategoryServicesRealEstate;
            _storeServices = storeServices;
        }

        public async Task<IActionResult> GetProduct()
        {
            var products = await _productServicesRealEstate.GetAllProducts();
			return View(products.Data);
        }

        public async Task<IActionResult> AddProduct()
        {
            var subcategories = await _subCategoryServicesRealEstate.GetAllSubcategoriesRealEstate();
            var stores = await _storeServices.GetAllStores();

            var v = new AddProductRealEstate_action();

            v.Subcategories = subcategories.Data;
            v.Stores = stores.Data;

            return View(v);
        }

        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await _productServicesRealEstate.GetProductById(id);

            var v = new UpdateProductRealEstate_action();

            var subcategories = await _subCategoryServicesRealEstate.GetAllSubcategoriesRealEstate();
            var stores = await _storeServices.GetAllStores();

            v.Subcategories = subcategories.Data;
            v.Stores = stores.Data;
            v.Product = product.Data;

            return View(v);
        }

		[HttpPost]
		public async Task<IActionResult> SaveAddProduct(AddProductRealEstateDTO newProduct)
		{
			await _productServicesRealEstate.AddProduct(newProduct);

			return RedirectToAction("GetSubcategory");
		}

		[HttpPost]
		public async Task<IActionResult> SaveUpdateProduct(UpdateProductRealEsteDTO updatedProduct)
		{
			await _productServicesRealEstate.UpdateProduct(updatedProduct);
			return RedirectToAction("GetSubcategory");
		}

		public async Task<IActionResult> DeleteProduct(int id)
		{
			await _productServicesRealEstate.DeleteProduct(id);
			return RedirectToAction("GetSubcategory");
		}
	}
}
