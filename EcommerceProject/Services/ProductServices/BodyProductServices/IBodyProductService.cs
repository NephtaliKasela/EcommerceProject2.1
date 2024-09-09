using EcommerceProject.DTOs.Products;
using EcommerceProject.DTOs.Subcategory;
using EcommerceProject.Models;

namespace EcommerceProject.Services.ProductServices.BodyProductServices
{
    public interface IBodyProductService
    {
        Task<ServiceResponse<List<GetBodyProductDTO>>> GetAllProducts();
        Task<ServiceResponse<GetBodyProductDTO>> GetProductById(int id);
        Task<ServiceResponse<List<GetBodyProductDTO>>> AddProduct(AddBodyProductDTO newProduct);
        Task<ServiceResponse<GetBodyProductDTO>> UpdateProduct(UpdateBodyProductDTO UpdatedProduct);
        Task<ServiceResponse<List<GetBodyProductDTO>>> DeleteProduct(int id);
    }
}