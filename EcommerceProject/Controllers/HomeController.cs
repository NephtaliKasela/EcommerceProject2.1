using EcommerceProject.DTOs.Actions;
using EcommerceProject.Models;
using EcommerceProject.Services.CategoryServices;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.UserServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryServices _categoryServices;
        private readonly IUserServices _userServices;

        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryServices categoryServices, IUserServices userServices)
        {
            _logger = logger;
            _productService = productService;
            _categoryServices = categoryServices;
            _userServices = userServices;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                // Retrieve the user ID
                string userName = User.Identity.Name.ToLowerInvariant();

                // Use the userId as needed in your code
                int userId = await _userServices.GetUserId(userName);
            }


            var products = await _productService.GetAllProducts();
            var categories = await _categoryServices.GetCategories();

            var v = new Home_action();
            v.Products = products.Data;
            v.Categories = categories.Data;
            return View(v);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}