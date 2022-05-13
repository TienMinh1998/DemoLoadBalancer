using HolaCore.API.DTOs.Users;
using HolaCore.API.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HolaCore.API.Controllers
{
    [ApiController]
    [Route("users")]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, UserService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("search")]
        //[Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> Search([FromQuery] GetUserListRequest request)
        {
            var users = await _service.SearchAsync(request);
            return Ok(users);
        }
    }
}
