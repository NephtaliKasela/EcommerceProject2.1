using EcommerceProject.Models.Products;

namespace EcommerceProject.Models.Subcategories
{
    public class SubcategoryRealEstate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Foreign Keys
        public Category Category { get; set; }
        public List<ProductRealEstate>? ProductsRealEstate { get; set; }

    }
}
