namespace EcommerceProject.DTOs.SUbCategory
{
    public class GetSubCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Other properties specific to the category

        public Models.Category Category { get; set; } 
        public List<Models.Product> Products { get; set; }
    }
}
