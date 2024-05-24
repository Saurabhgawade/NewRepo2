using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace unittestpractise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly Interfacedemo _inter;
        public DemoController(Interfacedemo inter)
        {
            _inter = inter;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _inter.getValue(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
    }
}
