using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Subcategory;

namespace EcommerceProject.DTOs.Actions
{
    public class UpdateProduct_action
    {
        public List<GetSubcategoryDTO> SubCategories { get; set; }
        public List<GetStoreDTO> Stores { get; set; }

        public UpdateProduct_action() 
        { 
            SubCategories = new List<GetSubcategoryDTO>();
            Stores = new List<GetStoreDTO>();
        }
    }
}
