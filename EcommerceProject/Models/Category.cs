﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Other properties specific to the category

        public List<SubCategory>? SubCategories { get; set; }
    }
}
