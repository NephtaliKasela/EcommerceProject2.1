using EcommerceProject.Models.Products;

namespace EcommerceProject.Models.Prices
{
    public class BodyProductPrice
    {
        public int Id { get; set; }
        public double MinimumPieces { get; set; }
        public double Price { get; set; }

        // Foreign keys
        public BodyProduct BodyProduct { get; set; }
    }
}
