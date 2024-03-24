using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
