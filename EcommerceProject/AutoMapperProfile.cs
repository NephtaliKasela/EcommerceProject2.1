using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.ProductImage;
using EcommerceProject.DTOs.Store;
using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Models;

namespace EcommerceProject
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductDTO>();
            //CreateMap<GetProductDTO, Product>();
            CreateMap<AddProductDTO, Product>();

            CreateMap<AddSubCategoryDTO, SubCategory>();
            CreateMap<SubCategory, GetSubCategoryDTO>();
            //CreateMap<UpdateSubCategoryDTO, GetSubCategoryDTO>();

            CreateMap<ProductImage, GetProductImageDTO>();
            CreateMap<AddProductImageDTO, ProductImage>();

            CreateMap<AddCategoryDTO, Category>();
            CreateMap<Category, GetCategoryDTO>();

            //CreateMap<GetStoreDTO, Store>();
            CreateMap<Store, GetStoreDTO>();
            CreateMap<AddStoreDTO, Store>();
        }
    }
}