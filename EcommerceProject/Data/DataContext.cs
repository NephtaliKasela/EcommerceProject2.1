using EcommerceProject.Models;
using EcommerceProject.Models.Images;
using EcommerceProject.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EcommerceProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //public DbSet<User> Users => Set<User>();

        public DbSet<Store> Stores => Set<Store>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        public DbSet<Subcategory> SubCategories => Set<Subcategory>();
        public DbSet<ProductImage> ProductImages => Set<ProductImage>();

        //*******************

        public DbSet<Continent> Continents => Set<Continent>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Subcategory> SubcategoriesRealEstate => Set<Subcategory>();
        public DbSet<BodyProduct> BodyProducts => Set<BodyProduct>();
        public DbSet<BodyProductImage> productImagesRealEstate => Set<BodyProductImage>();

    }
}