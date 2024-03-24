using EcommerceProject.DTOs.Actions;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.SubCategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISubCategoryServices _subCategoryServices;

        public ProductController(IProductService productService, ISubCategoryServices subCategoryServices)
        {
            _productService = productService;
            _subCategoryServices = subCategoryServices;
        }

        public async Task<IActionResult> Index(int productId)
        {
            var srProduct = await _productService.GetProductById(productId);
            var srProducts = await _productService.GetAllProducts();

            var v = new DisplayProduct_action();

            v.product = srProduct.Data;    
            v.Products = srProducts.Data;
            return View(v);
        }

        public async Task<IActionResult> GetProduct()
        {
            var products = await _productService.GetAllProducts();
            return View(products.Data);
        }

        public async Task<IActionResult> AddProduct()
        {
            var response = await _subCategoryServices.GetAllSubCategories();
            var subCs = response.Data;
            return View(subCs);
        }

        public async Task<IActionResult> SaveAddProduct(AddProductDTO newProduct)
        {
            await _productService.AddProduct(newProduct);
            return RedirectToAction("GetProduct", "Admin");
        }

        public async Task<IActionResult> UpdateProduct()
        {
            var p = await _productService.GetProductById(12);
            var productAndSubCategories = new UpdateProduct_action();

            var response = await _subCategoryServices.GetAllSubCategories();

            productAndSubCategories.SubCategories = response.Data;
            productAndSubCategories.Product = p.Data;

            return View(productAndSubCategories);
        }

        public async Task<IActionResult> SaveUpdateProduct(UpdateProductDTO updatedProduct)
        {
            await _productService.UpdateProduct(updatedProduct);
            return RedirectToAction("GetProduct");
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }

        public async Task<IActionResult> SaveDeleteProduct(int productId)
        {
            if (productId == 0)
            {
                return RedirectToAction("DeleteSubCategory");
            }
            else
            {
                try
                {
                    //int conversionId = Convert.ToInt32(Id);
                    await _productService.DeleteProduct(productId);
                    return RedirectToAction("GetProduct");
                }
                catch (Exception ex)
                {
                    return RedirectToAction("DeleteProduct");
                }
            }

            //return View(); 
        }

        
    }
}
