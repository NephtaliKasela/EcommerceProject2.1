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
			CreateMap<Subcategory, GetSubcategoryRealEstateDTO>();
			CreateMap<UpdateSubcategoryRealEstateDTO, Subcategory>();
			CreateMap<AddSubcategoryRealEstateDTO, Subcategory>();

			// Product Real Estate
			CreateMap<BodyProduct, GetProductRealEstateDTO>();
			CreateMap<UpdateProductRealEsteDTO, BodyProduct>();
			CreateMap<AddProductRealEstateDTO, BodyProduct>();

			CreateMap<Product, GetProductDTO>();
            //CreateMap<GetProductDTO, Product>();
            CreateMap<AddProductDTO, Product>();

            CreateMap<AddSubCategoryDTO, Subcategory>();
            CreateMap<Subcategory, GetSubCategoryDTO>();
            //CreateMap<UpdateSubCategoryDTO, GetSubCategoryDTO>();

            CreateMap<ProductImage, GetProductImageDTO>();
            CreateMap<AddProductImageDTO, ProductImage>();

            

            //CreateMap<GetStoreDTO, Store>();
            CreateMap<Store, GetStoreDTO>();
            CreateMap<AddStoreDTO, Store>();
        }
    }
}