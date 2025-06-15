using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using RealWorldBackend.Data;
using RealWorldBackend.DataModels;
using RealWorldBackend.Services;
using System.Threading.Tasks;

namespace RealWorldBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserLogin _userlogin;
        private readonly ApplicationDbContext db;

        public UsersController(IUserLogin userLogin, DbContextOptions<ApplicationDbContext> options)
        {
            _userlogin = userLogin;
            db = new ApplicationDbContext(options);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] ApplicationUser user)
        {
            //ApplicationUser? user = await db.ApplicationUsers.Where(x => x.UserName == UserName).FirstOrDefaultAsync();
            if (user != null && user.UserName == "admin" && user.PasswordHash == "password")
            {
                var token = _userlogin.GenerateJwtToken(user.UserName);
                return Ok(new { token });
            }
            return Unauthorized();
        }
    }
}
