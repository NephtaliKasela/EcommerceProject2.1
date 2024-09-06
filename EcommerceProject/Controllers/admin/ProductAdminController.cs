//using EcommerceProject.DTOs.Actions;
//using EcommerceProject.Models;
//using EcommerceProject.Services.ProductService;
//using EcommerceProject.Services.StoreServices;
//using EcommerceProject.Services.SubCategoryServices;
//using Microsoft.AspNetCore.Mvc;

//namespace EcommerceProject.Controllers.admin
//{
//    public class ProductAdminController : Controller
//    {
//		private readonly ISubCategoryServices _subCategoryServices;
//		private readonly IStoreServices _storeServices;
//		//private readonly IProductService _productService;

//		public ProductAdminController(ISubCategoryServices subCategoryServices, IStoreServices storeServices)
//        {
//			_subCategoryServices = subCategoryServices;
//			_storeServices = storeServices;
//		}
        

//        public async Task<IActionResult> Index()
//        {
//            //var sr = await _productService.GetAllProducts();
//            //var products = sr.Data;
//            return View();
//        }

//		public async Task<IActionResult> GetProduct()
//		{
//			var sr = await _productService.GetAllProducts();
//			var products = sr.Data;
//			return View(products);
//		}

//		public async Task<IActionResult> AddProduct()
//		{
//			var subcategories = await _subCategoryServices.GetAllSubCategories();
//			var stores = await _storeServices.GetAllStores();

//			var storesAndsubcategories = new AddProduct_action();

//			storesAndsubcategories.Subcategories = subcategories.Data;
//			storesAndsubcategories.Stores = stores.Data;

//			return View(storesAndsubcategories);
//		}

//		public async Task<IActionResult> UpdateProduct(int id)
//		{
//			var product = await _productService.GetProductById(id);

//			var productAndSubCategories = new UpdateProduct_action();

//			var subcategories = await _subCategoryServices.GetAllSubCategories();
//			var stores = await _storeServices.GetAllStores();

//			productAndSubCategories.SubCategories = subcategories.Data;
//			productAndSubCategories.Stores = stores.Data;
//			productAndSubCategories.Product = product.Data;

//			return View(productAndSubCategories);
//		}

//		//public async Task<IActionResult> SaveUpdateProduct(UpdateProductDTO updatedProduct)
//		//{
//		//	await _productService.UpdateProduct(updatedProduct);
//		//	return RedirectToAction("GetProduct", "ProductAdmin");
//		//}
//	}
//}
