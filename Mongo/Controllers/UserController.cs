using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public Iusercs _user;
        public UserController(Iusercs user)
        {
            _user = user;
        }

        [HttpGet(Name ="getAllUser")]
        public IActionResult getAll()
        {
            var result = _user.GetAllUser();
            return Ok(result);
        }
        //public IActionResult getbyId()
        //{
        //    var result = _user.GetUserById("59b99db4cfa9a34dcd7885b7");
        //    return Ok(result);
        //}
    }
}
