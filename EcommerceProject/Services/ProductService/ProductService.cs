using AutoMapper;
using EcommerceProject.Data;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.SUbCategory;
using EcommerceProject.Models;
using EcommerceProject.Services.ImageServices;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace EcommerceProject.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly IImageServices _imageServices;
        private readonly IMapper _mapper;

        public ProductService(DataContext context, IImageServices imageServices, IMapper mapper)
        {
            _context = context;
            _imageServices = imageServices;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetProductDTO>>> GetAllProducts()
        {
            var products = await _context.Products
                .Include(p => p.SubCategory)
                .Include(p => p.Store)
                .Include(p => p.ProductImages)
                .ToListAsync();
            var serviceResponse = new ServiceResponse<List<GetProductDTO>>()
            {
                Data = products.Select(p => _mapper.Map<GetProductDTO>(p)).ToList()
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetProductDTO>> GetProductById(int id)
        {
            var serviceResponse = new ServiceResponse<GetProductDTO>();
            try
            {
                var product = await _context.Products
                    .Include(p => p.Store)
                    .Include(p => p.SubCategory)
				    .Include(p => p.ProductImages)
					.FirstOrDefaultAsync(p => p.Id == id);
                if (product is null) { throw new Exception($"Product with Id '{id}' not found"); }

                serviceResponse.Data = _mapper.Map<GetProductDTO>(product);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            
            
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetProductDTO>>> AddProduct(AddProductDTO newProduct)
        {
            var serviceResponse = new ServiceResponse<List<GetProductDTO>>();
            var product = _mapper.Map<Product>(newProduct);

            // Get Subcategory
            //var subC = await GetProductSubCategory(newProduct.ProductSubCategoryId);
            (bool result, int number) = CheckIfInteger(newProduct.ProductSubCategoryId);
            if (result == true)
            {
				var subcategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.Id == number);
				product.SubCategory = subcategory;
			}

			// Get Store
			(bool result2, int number2) = CheckIfInteger(newProduct.ProductSubCategoryId);
			if (result2 == true)
			{
				var store = await _context.Stores.FirstOrDefaultAsync(s => s.Id == number2);
				product.Store = store;
			}

			//Save product
			_context.Products.Add(product);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Products
                .Select(p => _mapper.Map<GetProductDTO>(p)).ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetProductDTO>> UpdateProduct(UpdateProductDTO updatedProduct)
        {
            var serviceResponse = new ServiceResponse<GetProductDTO>();

            try
            {
                var product = await _context.Products
                    .FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);
                if (product is null) { throw new Exception($"Product with Id '{updatedProduct.Id}' not found"); }

                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.Description = updatedProduct.Description;

                bool result; int number;

				// Get the Subcategory
				//var subC = await GetProductSubCategory(updatedProduct.ProductSubCategoryId);
				(result, number) = CheckIfInteger(updatedProduct.ProductSubCategoryId);
				if (result == true)
				{
					var subcategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.Id == number);
					product.SubCategory = subcategory;
				}

				// Get Store
				(result, number) = CheckIfInteger(updatedProduct.StoreId);
				if (result == true)
				{
					var store = await _context.Stores.FirstOrDefaultAsync(s => s.Id == number);
					product.Store = store;
				}

				await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetProductDTO>(product);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetProductDTO>>> DeleteProduct(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetProductDTO>>();

            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product is null) { throw new Exception($"Product with Id '{id}' not found"); }

                _context.Products.Remove(product);

                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Products
                    .Select(p => _mapper.Map<GetProductDTO>(p)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        private (bool, int) CheckIfInteger(string number)
        {
            try
            {
                int convNumber = Convert.ToInt32(number);
                return (true, convNumber);
            }
            catch 
            {
            }
            return (false, 0);
        }

        //private async Task<ServiceResponse<SubCategory>> GetProductSubCategory(string productSubCategoryId)
        //{
        //    var serviceResponse = new ServiceResponse<SubCategory>();

        //    try
        //    {
        //        int convProductSubCategoryId = Convert.ToInt32(productSubCategoryId);
        //        var SubC = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.Id == convProductSubCategoryId);

        //        if (SubC is null) { throw new Exception($"Product with Id '{productSubCategoryId}' not found"); }

        //        serviceResponse.Data = SubC;
        //        return serviceResponse;
        //    }
        //    catch (Exception ex)
        //    {
        //        serviceResponse.Success = false;
        //        serviceResponse.Message = ex.Message;
        //    }
        //    return serviceResponse;
        //}
    }
}
