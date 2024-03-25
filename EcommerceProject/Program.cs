using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

using EcommerceProject.Data;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.SubCategoryServices;
using EcommerceProject.Services.ImageServices;
using EcommerceProject.Services.CategoryServices;
using EcommerceProject.Services.StoreServices;
using EcommerceProject.Services.UserServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        // Add dbContext
        builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(connectionString));

        // Add AutoMapper
        builder.Services.AddAutoMapper(typeof(Program).Assembly);

        //Add Injection
        builder.Services.AddScoped<ICategoryServices, CategoryServices>();
        builder.Services.AddScoped<ISubCategoryServices, SubCategoryServices>();
        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IImageServices, ImageServices>();
        builder.Services.AddScoped<IStoreServices, StoreServices>();
        builder.Services.AddScoped<IUserServices, UserServices>();


        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
    }
}