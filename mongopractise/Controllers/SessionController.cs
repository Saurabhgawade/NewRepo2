using Microsoft.AspNetCore.Mvc;

namespace mongopractise.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        private readonly InterfaceMongo _inter;
        public SessionController(InterfaceMongo inter)
        {
            _inter = inter;
        }

        [HttpGet(Name ="getAllSession")]
        public IActionResult getAllSessions()
        {
           var result= _inter.getAllSessions();
            return Ok(result);
        }
    }
}
