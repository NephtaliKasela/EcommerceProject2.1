using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EcommerceProject.Controllers.Subcategories;
using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.City;
using EcommerceProject.DTOs.Continent;
using EcommerceProject.DTOs.Country;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.Product.ProductRealEstate;
using EcommerceProject.DTOs.ProductImage;
using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Subcategories.SubcategoryRealEstate;
using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Models;
using EcommerceProject.Models.Products;
using EcommerceProject.Models.Subcategories;

namespace EcommerceProject
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
			// Continent
			CreateMap<Continent, GetContinentDTO>();
			CreateMap<UpdateContinentDTO, Continent>();
			CreateMap<AddContinentDTO, Continent>();

            // Country
            CreateMap<Country, GetCountryDTO>();
            CreateMap<UpdateCountryDTO, Country>();
            CreateMap<AddCountryDTO, Country>();

			// City
			CreateMap<City, GetCityDTO>();
			CreateMap<UpdateCityDTO, City>();
			CreateMap<AddCityDTO, City>();

            // Category
			//CreateMap<GetCategoryDTO, Category>();
			CreateMap<AddCategoryDTO, Category>();
			CreateMap<Category, GetCategoryDTO>();
			CreateMap<UpdateCategoryDTO, Category>();

			// SubCategory Real Estate
			CreateMap<SubcategoryRealEstate, GetSubcategoryRealEstateDTO>();
			CreateMap<UpdateSubcategoryRealEstateDTO, SubcategoryRealEstate>();
			CreateMap<AddSubcategoryRealEstateDTO, SubcategoryRealEstate>();

			// Product Real Estate
			CreateMap<ProductRealEstate, GetProductRealEstateDTO>();
			CreateMap<UpdateProductRealEsteDTO, ProductRealEstate>();
			CreateMap<AddProductRealEstateDTO, ProductRealEstate>();

			CreateMap<Product, GetProductDTO>();
            //CreateMap<GetProductDTO, Product>();
            CreateMap<AddProductDTO, Product>();

            CreateMap<AddSubCategoryDTO, SubCategory>();
            CreateMap<SubCategory, GetSubCategoryDTO>();
            //CreateMap<UpdateSubCategoryDTO, GetSubCategoryDTO>();

            CreateMap<ProductImage, GetProductImageDTO>();
            CreateMap<AddProductImageDTO, ProductImage>();

            

            //CreateMap<GetStoreDTO, Store>();
            CreateMap<Store, GetStoreDTO>();
            CreateMap<AddStoreDTO, Store>();
        }
    }
}