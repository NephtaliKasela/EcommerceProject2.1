using EcommerceProject.Models.Products;

namespace EcommerceProject.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Foreign Keys
        public Category Category { get; set; }
        public List<BodyProduct>? BodyProducts { get; set; }

    }
}
