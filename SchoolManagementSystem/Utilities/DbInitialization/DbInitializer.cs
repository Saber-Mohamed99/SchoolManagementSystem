using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Utilities.DbInitialization
{
    public class DbInitializer :IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public DbInitializer(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser> userManager
            ,ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }
        
        public async Task Initialize()
        {
            if( _context.Database.GetPendingMigrations().Any())
                _context.Database.Migrate();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new (SD.Admin_Role));
                await _roleManager.CreateAsync(new (SD.Student_Role));
                await _roleManager.CreateAsync(new (SD.Teacher_Role));
            }
            var user = await _userManager.FindByEmailAsync("Admin@gmail.com");
            if (user == null)
            {
                await _userManager.CreateAsync(new ApplicationUser
                {
                    FullName = "Admin",
                    Email = "Admin@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Admin123"
                }, "Admin123@");

                await _userManager.AddToRoleAsync(user, SD.Admin_Role);
            }
        }
    }

}

