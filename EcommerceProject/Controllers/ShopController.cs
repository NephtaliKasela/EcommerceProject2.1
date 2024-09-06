//using EcommerceProject.Services.ProductService;
//using Microsoft.AspNetCore.Mvc;

//namespace EcommerceProject.Controllers
//{
//	public class ShopController : Controller
//	{
//		private readonly IProductService _productService;
//		public ShopController(IProductService productService)
//		{
//			_productService = productService;
//		}

//		public async Task<IActionResult> Index()
//		{
//			var sr = await _productService.GetAllProducts();
//			var p = sr.Data;
//			return View(p);
//		}
//	}
//}
