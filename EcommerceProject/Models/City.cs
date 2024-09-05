using EcommerceProject.Models.Products;

namespace EcommerceProject.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Foreign Keys
        public Country Country { get; set; }

        // Product FK
        public List<BodyProduct>? BodyProducts { get; set; }
        public List<Store>? Stores { get; set; }
    }
}
