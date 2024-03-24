﻿namespace EcommerceProject.DTOs.Store
{
    public class GetStoreDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Models.Product>? Products { get; set; }
    }
}
