using EcommerceProject.DTOs.Category;

namespace EcommerceProject.DTOs.Actions
{
    public class Home_action
    {
        public List<GetCategoryDTO> Categories { get; set; }  

        public Home_action()
        {
            Categories = new List<GetCategoryDTO>();
        }

    }
}
