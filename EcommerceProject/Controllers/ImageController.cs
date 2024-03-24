using EcommerceProject.DTOs.Product;
using EcommerceProject.Services.ImageServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageServices _imageServices;

        public ImageController(IImageServices imageServices) 
        {
            _imageServices = imageServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProductImage(int productId, IFormFile file)
        {
            await _imageServices.AddProductImage(productId, file);
            return RedirectToAction("GetProduct", "ProductAdmin");
        }
    }
}