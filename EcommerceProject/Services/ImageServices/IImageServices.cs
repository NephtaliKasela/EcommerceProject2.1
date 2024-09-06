using EcommerceProject.Models;
using System.Web;

//using static System.Net.Mime.MediaTypeNames;


namespace EcommerceProject.Services.ImageServices
{
    public interface IImageServices
    {
        Task AddProductImage(int productId, IFormFile file);
    }
}
