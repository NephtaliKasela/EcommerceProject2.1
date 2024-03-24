using EcommerceProject.DTOs.Category;
using EcommerceProject.DTOs.Store;
using EcommerceProject.Services.CategoryServices;
using EcommerceProject.Services.StoreServices;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
	public class StoreController : Controller
	{
		private readonly IStoreServices _storeServices;

		public StoreController(IStoreServices storeServices)
		{
			_storeServices = storeServices;
		}

		[HttpPost]
		public IActionResult SaveAddStore(AddStoreDTO newStore)
		{
			_storeServices.AddStore(newStore);

			return RedirectToAction("GetStore", "Admin");
		}

		[HttpPost]
		public async Task<IActionResult> SaveUpdateStore(UpdateStoreDTO updatedStore)
		{
			await _storeServices.UpdateStore(updatedStore);
			return RedirectToAction("GetStore", "Admin");
		}

		public async Task<IActionResult> SaveDeleteCategory(int id)
		{
			await _storeServices.DeleteStore(id);
			return RedirectToAction("GetStore", "Admin");
		}
	}
}
