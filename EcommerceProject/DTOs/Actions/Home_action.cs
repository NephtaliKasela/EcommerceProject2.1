using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.Product.ProductRealEstate;

namespace EcommerceProject.DTOs.Actions
{
    public class Home_action
    {
        public List<GetProductDTO> Products { get; set; }  
        public List<GetProductRealEstateDTO> ProductsRealEstate { get; set; }  
        public List<GetCategoryDTO> Categories { get; set; }  

        public Home_action()
        {
            Products = new List<GetProductDTO>();
            Categories = new List<GetCategoryDTO>();
            ProductsRealEstate = new List<GetProductRealEstateDTO>();
        }

    }
}
