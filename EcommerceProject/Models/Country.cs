using EcommerceProject.Models.Products;

namespace EcommerceProject.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Freign Keys
        public Continent Continent { get; set; }
        public List<City>? Cities { get; set; }
        public List<BodyProduct>? BodyProducts {  get; set; }    
        public List<Store>? Stores {  get; set; }    
    }
}
