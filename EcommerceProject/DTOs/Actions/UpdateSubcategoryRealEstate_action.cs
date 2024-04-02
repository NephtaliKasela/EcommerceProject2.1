using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate;
using EcommerceProject.DTOs.SUbCategory;

namespace EcommerceProject.DTOs.Actions
{
    public class UpdateSubcategoryRealEstate_action
    {
        public List<GetCategoryDTO> Categories { get; set; }
        public GetSubcategoryRealEstateDTO Subcategory {  get; set; }

        public UpdateSubcategoryRealEstate_action()
        {
            Categories = new List<GetCategoryDTO>();
            Subcategory= new GetSubcategoryRealEstateDTO();
        }
    }
}
