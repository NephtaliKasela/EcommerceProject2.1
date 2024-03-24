using EcommerceProject.DTOs.Product;

namespace EcommerceProject.DTOs.Actions
{
    public class DisplayProduct_action
    {
        public GetProductDTO product {  get; set; } = new GetProductDTO();
        public List<GetProductDTO> Products { get; set; } = new List<GetProductDTO>();
    }
}
