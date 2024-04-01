using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate;

namespace EcommerceProject.DTOs.Actions
{
	public class AddProductRealEstate_action
	{
		public List<GetSubcategoryRealEstateDTO> Subcategories { get; set; }
		public List<GetStoreDTO> Stores { get; set; }

        public AddProductRealEstate_action()
        {
            Subcategories = new List<GetSubcategoryRealEstateDTO>();
            Stores = new List<GetStoreDTO>();
        }
    }
}
