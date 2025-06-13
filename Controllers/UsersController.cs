using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RealWorldBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost(Name = "Login")]
        public ActionResult<User> login()
        {

        }
    }
}
