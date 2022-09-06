using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SQLData.Library.DataAccess;

namespace StoreApi.Controllers
{
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IUserData _userData;

        public TokenController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpPost]
        public async Task<IActionResult> Create(string username, string password, string grant_type)
        {
            if (await IsValidUsernameAndPassword(username, password))
            {
                return new ObjectResult(await GenerateToken(username));
            }
            else
            {
                return BadRequest();
            }
        }
        private async Task<bool> IsValidUsernameAndPassword(string username, string password)
        {
            // TODO - Improve how the password is stored and checked
            return await _userData.VerifyLogin(username, password);
        }

        private async Task<dynamic> GenerateToken(string username)
        {
            // TODO - Build token

            var output = new
            {
                Access_Token = "teste",
                UserName = username
            };
            return output;
        }
    }
}
