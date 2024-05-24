using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MongoDB1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private ISession _Sessions;
        public SessionsController(ISession Sessions)
        {
            _Sessions = Sessions;
        }

        
        [HttpGet(Name = "getAllSessions")]
        public IActionResult GetAll()
        {
            var result = _Sessions.getSessions();
            return Ok(result);
        }
        [HttpGet(Name = ("getSession"))]
        public IActionResult Get()
        {
            var result = _Sessions.getSessionById("5a97f9c91c807bb9c6eb5fb4");
            return Ok(result);
        }
    }
}
