using EcommerceProject.DTOs.Store;
using EcommerceProject.Models;

namespace EcommerceProject.Services.StoreServices
{
    public interface IStoreServices
    {
        Task<ServiceResponse<List<GetStoreDTO>>> GetAllStores();
        Task<ServiceResponse<GetStoreDTO>> GetStoreById(int id);
        Task<ServiceResponse<List<GetStoreDTO>>> AddStore(AddStoreDTO newStore);
        Task<ServiceResponse<GetStoreDTO>> UpdateStore(UpdateStoreDTO updatedStore);
        Task<ServiceResponse<List<GetStoreDTO>>> DeleteStore(int id);
    }
}
