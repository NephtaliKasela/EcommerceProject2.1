﻿using EcommerceProject.Data;
using EcommerceProject.DTOs.Actions;
using EcommerceProject.Models;
using EcommerceProject.Services.CategoryServices;
using EcommerceProject.Services.ProductService;
using EcommerceProject.Services.UserServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EcommerceProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryServices _categoryServices;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryServices categoryServices, 
                                UserManager<IdentityUser> userManager, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _productService = productService;
            _categoryServices = categoryServices;
            _userManager = userManager;
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IActionResult> Index()
        {
            //var user = await _userManager.GetUserAsync(User);

            //string userName = string.Empty;

            //if (User.Identity.IsAuthenticated)
            //{
            //    // Retrieve the user name
            //    userName = User.Identity.Name.ToLowerInvariant();
            //}s

            //var users = await _applicationDbContext.Users.ToListAsync();


            var products = await _productService.GetAllProducts();
            var categories = await _categoryServices.GetCategories();

            var v = new Home_action();
            v.Products = products.Data;
            v.Categories = categories.Data;
            return View(v);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}