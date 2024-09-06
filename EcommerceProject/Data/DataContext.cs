using EcommerceProject.Models;
using EcommerceProject.Models.Images;
using EcommerceProject.Models.Prices;
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

        public DbSet<Continent> Continents => Set<Continent>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<City> Cities => Set<City>();

        public DbSet<Store> Stores => Set<Store>();
        public DbSet<StoreLocation> StoreLocations => Set<StoreLocation>();

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Subcategory> SubCategories => Set<Subcategory>();

        public DbSet<BodyProduct> BodyProducts => Set<BodyProduct>();
        public DbSet<BodyProductPrice> BodyProductPrices => Set<BodyProductPrice>();
        public DbSet<BodyProductImage> BodyproductImages => Set<BodyProductImage>();

    }
}