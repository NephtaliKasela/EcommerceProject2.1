﻿using EcommerceProject.Models;

namespace EcommerceProject.DTOs.Continent
{
    public class UpdateContinentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Foreign Keys
        public List<Models.Country>? Countries { get; set; }
    }
}
