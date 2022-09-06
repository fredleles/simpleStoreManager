using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SQLData.Library.DataAccess;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StoreApi.Controllers
{
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IUserData _userData;
        private readonly IConfiguration _config;
        private string userId = "";

        public TokenController(IUserData userData, IConfiguration config)
        {
            _userData = userData;
            _config = config;
        }

        [HttpPost]
        public IActionResult Create(string username, string password)
        {
            if (IsValidUsernameAndPassword(username, password))
            {
                return new ObjectResult(GenerateToken(username));
            }
            else
            {
                return BadRequest();
            }
        }
        private bool IsValidUsernameAndPassword(string username, string password)
        {
            // TODO - Improve how the password is stored and checked
            userId = _userData.VerifyLogin(username, password);
            if(!string.IsNullOrEmpty(userId)) return true;
            return false;
        }

        private dynamic GenerateToken(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString())
            };

            var token = new JwtSecurityToken(
                new JwtHeader(
                    new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetValue<string>("Secrets:SecurityKey"))),
                        SecurityAlgorithms.HmacSha256)),
                new JwtPayload(claims));


            var output = new
            {
                Access_Token = new JwtSecurityTokenHandler().WriteToken(token),
                UserName = username
            };
            return output;
        }
    }
}
