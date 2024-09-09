using EcommerceProject.Models;
using EcommerceProject.Models.Images;
using EcommerceProject.Models.Prices;
using EcommerceProject.Models.Products;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace EcommerceProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //builder.HasDefaultSchema("Identity");
        //builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RoleClaims"));
        //builder.Entity<IdentityRole<string>>(entity => entity.ToTable(name: "Roles"));
        //builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UserClaims"));
        //builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UserLogins"));
        //builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UserRoles"));
        //builder.Entity<IdentityUser>(entity => entity.ToTable(name: "Users"));
        //builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UserTokens"));

        

        //public DbSet<IdentityUser> Users => Set<IdentityUser>();


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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Relationships
            builder.Entity<Store>()
            .HasOne(e => e.Location)
            .WithOne(e => e.Store)
            .HasForeignKey<StoreLocation>();
        }
    }
}