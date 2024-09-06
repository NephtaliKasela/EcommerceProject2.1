namespace EcommerceProject.Models
{
    public class StoreLocation
    {
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        // Foreign key
        public Store Store { get; set; }
    }
}
