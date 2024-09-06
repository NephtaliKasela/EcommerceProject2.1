using EcommerceProject.Models.Products;

namespace EcommerceProject.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Store Owner info
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerProfession { get; set; } = string.Empty;

        // Foreign Keys
        public Country Country { get; set; }
        public City? City { get; set; }
        public List<BodyProduct>? BodyProducts { get; set; }
        public StoreLocation? Location { get; set; }
    }
}