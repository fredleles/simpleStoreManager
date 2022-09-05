using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreApi.Controllers
{
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(string username, string password, string grant_type)
        {
            // check credentials
            return new ObjectResult(new { UserName = username, Access_Token = "teste" });

            //else return BadRequest();
        }
    }
}
