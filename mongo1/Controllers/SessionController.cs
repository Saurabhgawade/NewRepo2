using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mongo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISession _session;
        public SessionController(ISession session)
        {
            _session = session;
        }

        [HttpGet(Name = "getsessions")]
        public IActionResult GetSessions()
        {
            var result = _session.GetSession();
            return Ok(result);
        }
        //public IActionResult GetbyId()
        //{
        //    var result= _session.GetSessionById("5a97f9c91c807bb9c6eb5fb4");
        //    return Ok(result);
        //}
    }
}
