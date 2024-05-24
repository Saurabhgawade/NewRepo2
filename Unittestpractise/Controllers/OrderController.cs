using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Unittestpractise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly Interface _inter;
        public OrderController(Interface inter)
        {
            _inter = inter;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result=_inter.getValue(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
    }
}
