using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers.admin
{
    public class ContinentController : Controller
    {
        public IActionResult AddContinent()
        {
            return View();
        }

        public async Task<IActionResult> GetContinent()
        {
            return View();
        }

        public async Task<IActionResult> UpdateContinent(int id)
        {
            //var c = await _categoryServices.GetCategoryById(id);
            return View();
        }
    }
}
