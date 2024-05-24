using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPerson _person;
        public PersonsController(IPerson person)
        {
            _person = person;
        }
        [HttpGet(Name ="getById")]
        public IActionResult getById()
        {
            var result= _person.getById(1);
            return Ok(result);
        }
    }
}
