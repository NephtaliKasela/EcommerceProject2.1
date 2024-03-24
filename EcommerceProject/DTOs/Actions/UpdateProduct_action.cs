using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.SUbCategory;

namespace EcommerceProject.DTOs.Actions
{
    public class UpdateProduct_action
    {
        public GetProductDTO Product { get; set; }
        public List<GetSubCategoryDTO> SubCategories { get; set; }
        public List<GetStoreDTO> Stores { get; set; }

        public UpdateProduct_action() 
        { 
            Product = new GetProductDTO();
            SubCategories = new List<GetSubCategoryDTO>();
            Stores = new List<GetStoreDTO>();
        }
    }
}
