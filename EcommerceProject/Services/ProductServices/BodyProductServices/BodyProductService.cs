using AutoMapper;
using EcommerceProject.Data;
using EcommerceProject.DTOs.Products;
using EcommerceProject.DTOs.Subcategory;
using EcommerceProject.Models;
using EcommerceProject.Models.Products;
using EcommerceProject.Services.ImageServices;
using EcommerceProject.Services.OtherServices;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace EcommerceProject.Services.ProductServices.BodyProductServices
{
    public class BodyProductService : IBodyProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IImageServices _imageServices;
        private readonly IMapper _mapper;
        private readonly IOtherServices _otherServices;

        public BodyProductService(ApplicationDbContext context, IImageServices imageServices, IMapper mapper, IOtherServices otherServices)
        {
            _context = context;
            _imageServices = imageServices;
            _mapper = mapper;
            _otherServices = otherServices;
        }

        public async Task<ServiceResponse<List<GetBodyProductDTO>>> GetAllProducts()
        {
            var products = await _context.BodyProducts
                .Include(x => x.Subcategory)
                .Include(x => x.Store)
                .Include(x => x.BodyProductImages)
                .ToListAsync();
            var serviceResponse = new ServiceResponse<List<GetBodyProductDTO>>()
            {
                Data = products.Select(x => _mapper.Map<GetBodyProductDTO>(x)).ToList()
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetBodyProductDTO>> GetProductById(int id)
        {
            var serviceResponse = new ServiceResponse<GetBodyProductDTO>();
            try
            {
                var product = await _context.BodyProducts
                    .Include(p => p.Store)
                    .Include(p => p.Subcategory)
                    .Include(p => p.BodyProductImages)
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (product is null) { throw new Exception($"Product with Id '{id}' not found"); }

                serviceResponse.Data = _mapper.Map<GetBodyProductDTO>(product);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }



            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetBodyProductDTO>>> AddProduct(AddBodyProductDTO newProduct)
        {
            var serviceResponse = new ServiceResponse<List<GetBodyProductDTO>>();
            var product = _mapper.Map<BodyProduct>(newProduct);

            bool result; int number;
            // Get Subcategory
            (result, number) = _otherServices.CheckIfInteger(newProduct.SubcategoryId);
            if (result == true)
            {
                var subcategory = await _context.SubCategories.FirstOrDefaultAsync(x => x.Id == number);
                if (subcategory is not null)
                {
                    product.Subcategory = subcategory;
                }
            }

            // Get Store
            (result, number) = _otherServices.CheckIfInteger(newProduct.StoreId);
            if (result == true)
            {
                var store = await _context.Stores.FirstOrDefaultAsync(x => x.Id == number);
                if (store is not null)
                {
                    product.Store = store;
                }
            }

            //Save product
            _context.BodyProducts.Add(product);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.BodyProducts
                .Select(p => _mapper.Map<GetBodyProductDTO>(p)).ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetBodyProductDTO>> UpdateProduct(UpdateBodyProductDTO updatedProduct)
        {
            var serviceResponse = new ServiceResponse<GetBodyProductDTO>();

            try
            {
                var product = await _context.BodyProducts
                    .FirstOrDefaultAsync(x => x.Id == updatedProduct.Id);
                if (product is null) { throw new Exception($"Product with Id '{updatedProduct.Id}' not found"); }

                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.ShortDescription = updatedProduct.ShortDescription;
                product.LongDescription = updatedProduct.LongDescription;

                bool result; int number;

                // Get the Subcategory
                (result, number) = _otherServices.CheckIfInteger(updatedProduct.SubcategoryId);
                if (result == true)
                {
                    var subcategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.Id == number);
                    if (subcategory is not null)
                    {
                        product.Subcategory = subcategory;
                    }

                }

                // Get Store
                (result, number) = _otherServices.CheckIfInteger(updatedProduct.StoreId);
                if (result == true)
                {
                    var store = await _context.Stores.FirstOrDefaultAsync(s => s.Id == number);
                    if (store is not null)
                    {
                        product.Store = store;
                    }
                }

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetBodyProductDTO>(product);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetBodyProductDTO>>> DeleteProduct(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetBodyProductDTO>>();

            try
            {
                var product = await _context.BodyProducts.FirstOrDefaultAsync(x => x.Id == id);
                if (product is null) { throw new Exception($"Product with Id '{id}' not found"); }

                _context.BodyProducts.Remove(product);

                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.BodyProducts
                    .Select(x => _mapper.Map<GetBodyProductDTO>(x)).ToListAsync();
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
