using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EcommerceProject.Controllers;
using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.City;
using EcommerceProject.DTOs.Continent;
using EcommerceProject.DTOs.Country;
using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.Subcategory;
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

            CreateMap<AddSubcategoryDTO, Subcategory>();
            CreateMap<Subcategory, GetSubcategoryDTO>();
            CreateMap<UpdateSubcategoryDTO, GetSubcategoryDTO>();

            //CreateMap<GetStoreDTO, Store>();
            CreateMap<Store, GetStoreDTO>();
            CreateMap<AddStoreDTO, Store>();
        }
    }
}