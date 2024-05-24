using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace mongofinal.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly Interfaceuser _iuser;
        private readonly IConfiguration _config;
        public UsersController(Interfaceuser iuser,IConfiguration config)
        {
            _iuser = iuser;
            _config = config;
        }
        [HttpGet(Name = "getbyId")]
        public IActionResult getById()
        {
            var result = _iuser.getUserById("59b99db4cfa9a34dcd7885b6");

            return Ok(result);
        }
        //[HttpGet(Name = "getAll")]
        //public IActionResult getAll()
        //{
        //    var result = _iuser.getAllUsers();

        //    return Ok(result);
        //}

        [Authorize]
        [AllowAnonymous]
        [HttpGet(Name ="GetToken")]
        public string GetToken()
        {
            var SymmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetValue<string>("Jwt:SigningKey")));
            var credential = new SigningCredentials(SymmetricKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], null, expires:DateTime.Now.AddMinutes(2), signingCredentials:credential);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
