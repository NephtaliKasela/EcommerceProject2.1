using AutoMapper;
using EcommerceProject.Data;
using EcommerceProject.DTOs.Product;
using EcommerceProject.DTOs.Product.ProductRealEstate;
using EcommerceProject.Models;
using EcommerceProject.Models.Products;
using EcommerceProject.Services.ImageServices;
using EcommerceProject.Services.OtherServices;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Services.ProductService.ProductServicesRealEstate
{
    public class ProductServicesRealEstate : IProductServicesRealEstate
    {
        private readonly DataContext _context;
        private readonly IImageServices _imageServices;
        private readonly IMapper _mapper;
        private readonly IOtherServices _otherServices;

        public ProductServicesRealEstate(DataContext context, IImageServices imageServices, IMapper mapper, IOtherServices otherServices)
        {
            _otherServices = otherServices;
            _context = context;
            _imageServices = imageServices;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetProductRealEstateDTO>>> GetAllProducts()
        {
            var products = await _context.BodyProducts
                .Include(p => p.Subcategory)
                .Include(p => p.Store)
                .Include(p => p.BodyProductImages)
                .ToListAsync();
            var serviceResponse = new ServiceResponse<List<GetProductRealEstateDTO>>()
            {
                Data = products.Select(p => _mapper.Map<GetProductRealEstateDTO>(p)).ToList()
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetProductRealEstateDTO>> GetProductById(int id)
        {
            var serviceResponse = new ServiceResponse<GetProductRealEstateDTO>();
            try
            {
                var product = await _context.BodyProducts
                    .Include(p => p.Store)
                    .Include(p => p.Subcategory)
                    .Include(p => p.BodyProductImages)
                    .FirstOrDefaultAsync(p => p.Id == id);
                if (product is null) { throw new Exception($"Product with Id '{id}' not found"); }

                serviceResponse.Data = _mapper.Map<GetProductRealEstateDTO>(product);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetProductRealEstateDTO>>> AddProduct(AddProductRealEstateDTO newProduct)
        {
            var serviceResponse = new ServiceResponse<List<GetProductRealEstateDTO>>();
            var product = _mapper.Map<BodyProduct>(newProduct);

            bool result; int number;

            // Get Subcategory
            (result, number) = _otherServices.CheckIfInteger(newProduct.ProductSubCategoryId);
            if (result == true)
            {
                var subcategory = await _context.SubcategoriesRealEstate.FirstOrDefaultAsync(sc => sc.Id == number);
                if (subcategory is not null)
                {
                    product.Subcategory = subcategory;
                }
            }

            // Get Store
            (result, number) = _otherServices.CheckIfInteger(newProduct.StoreId);
            if (result == true)
            {
                var store = await _context.Stores.FirstOrDefaultAsync(s => s.Id == number);
                if (store is not null)
                {
                    product.Store = store;
                }
            }



            product.PublicationDate = DateTime.Now;

			//Save product
			_context.BodyProducts.Add(product);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.BodyProducts
                .Select(p => _mapper.Map<GetProductRealEstateDTO>(p)).ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetProductRealEstateDTO>> UpdateProduct(UpdateProductRealEsteDTO updatedProduct)
        {
            var serviceResponse = new ServiceResponse<GetProductRealEstateDTO>();

            try
            {
                var product = await _context.BodyProducts
                    .FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);
                if (product is null) { throw new Exception($"Product with Id '{updatedProduct.Id}' not found"); }

                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.ShortDescription = updatedProduct.Description;
                // add more *******

                bool result; int IdNumber;
				// Get the Subcategory
				(result, IdNumber) = _otherServices.CheckIfInteger(updatedProduct.ProductSubCategoryId);
                if (result == true)
                {
                    var subcategory = await _context.SubcategoriesRealEstate.FirstOrDefaultAsync(sc => sc.Id == IdNumber);
                    product.Subcategory = subcategory;
                }

                // Get Store
                (result, IdNumber) = _otherServices.CheckIfInteger(updatedProduct.StoreId);
                if (result == true)
                {
                    var store = await _context.Stores.FirstOrDefaultAsync(s => s.Id == IdNumber);
                    product.Store = store;
                }

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetProductRealEstateDTO>(product);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetProductRealEstateDTO>>> DeleteProduct(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetProductRealEstateDTO>>();

            try
            {
                var product = await _context.BodyProducts.FirstOrDefaultAsync(p => p.Id == id);
                if (product is null) { throw new Exception($"Product with Id '{id}' not found"); }

                _context.BodyProducts.Remove(product);

                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.BodyProducts
                    .Select(p => _mapper.Map<GetProductRealEstateDTO>(p)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
