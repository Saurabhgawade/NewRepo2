using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }
        [HttpGet(Name ="GetById")]
        public IActionResult Get(int Id)
        {
            var result = _employee.getById(1);
            return Ok(result);
        }
    }
}
