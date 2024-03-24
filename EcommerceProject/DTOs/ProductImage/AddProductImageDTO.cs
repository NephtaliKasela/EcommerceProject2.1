namespace EcommerceProject.DTOs.ProductImage
{
	public class AddProductImageDTO
	{
		public string FileName { get; set; }
		public byte[] ImageData { get; set; }
		public string ContentType { get; set; }
		public Models.Product Product { get; set; }
	}
}
