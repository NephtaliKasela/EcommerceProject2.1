using EcommerceProject.Models.Products;

namespace EcommerceProject.Models.Images
{
    public class BodyProductImage
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }
        public BodyProduct ProductRealEstate { get; set; }
    }
}
