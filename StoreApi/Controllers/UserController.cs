using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLData.Library.DataAccess;
using SQLData.Library.Models;
using System.Security.Claims;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserData _userData;
        public UserController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpGet]
        public UserModel GetById()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _userData.GetUserById(userId).First();
        }

        [HttpGet]
        [Route("All")]
        [Authorize]
        public List<UserModel> GetAll()
        {
            return _userData.GetAll();
        }
    }
}
