using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Mongo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISession _session;
        private readonly IConfiguration _configuration;
        public SessionController(ISession session,IConfiguration configuration)
        {
            _session = session;
            _configuration = configuration;
        }
        [HttpGet(Name ="getall")]
        [Authorize]
        public IActionResult getSessions()
        {
            try
            {
                var result = _session.GetSessionById("5a97f9c91c807bb9c6eb5fb4");
                return Ok(result);
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }
        //public IActionResult AllSessions()
        //{
        //    var result = _session.AllSessions();
        //    return Ok(result);
        //}
        [HttpGet("GetToken")]
        [AllowAnonymous]
        public string GetToken()
        {
            var symmentricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SigningKey"]));

            var credential = new SigningCredentials(symmentricKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["JWT:Issuer"], _configuration["JWT:Audience"], null,expires: DateTime.Now.AddMinutes(2), signingCredentials:credential);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
