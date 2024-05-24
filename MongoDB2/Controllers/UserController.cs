using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB2.Interface;

namespace MongoDB2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _User;
        public UserController(IUser user)
        {
            _User = user;
        }
        [HttpGet(Name ="getAll")]
        public IActionResult Get()
        {
            

        }
    }
}
