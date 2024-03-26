using EcommerceProject.Data;
using EcommerceProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EcommerceProject.Services.UserServices
{
    public class UserServices: IUserServices
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UserServices(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<int> GetUserId(string userName)
        {
            //var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.ToUpper() == userName.ToUpper());

            //if (user != null)
            //{
            //    // User found, you can access user properties or perform further operations
            //    return user.Id;
            //    // ...
            //}

            return 0;
        }
    }
}
