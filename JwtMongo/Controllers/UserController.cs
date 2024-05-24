using JwtMongo.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JwtMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userIntrface;
        private readonly IConfiguration _configuration;
        public UserController(IUser userInterface,IConfiguration configuration)
        {
            _userIntrface = userInterface;
            _configuration = configuration;
        }

        //[HttpGet(Name = "getAll")]
        //public IActionResult AllUser()
        //{
        //    try
        //    {
        //        var result = _userIntrface.AllUser();
        //        return Ok(result);
        //    }
        //    catch (Exception e)
        //    {
        //        return NotFound();
        //    }
        //}
        
        [HttpGet(Name = "getById")]
        [Authorize]
        public IActionResult getById()
        {
            try
            {
                var result = _userIntrface.getById("59b99db4cfa9a34dcd7885b6");
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpGet("GetToken")]
        [AllowAnonymous]
        public string GetToken()
        {
            var signinkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SignInKey"]));
            var creadential = new SigningCredentials(signinkey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_configuration["JWT:Issuer"], _configuration["JWT:Audience"], null, expires: DateTime.Now.AddMinutes(2), signingCredentials: creadential);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
