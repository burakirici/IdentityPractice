using IdentityPractice.Dtos;
using IdentityPractice.Models;
using IdentityPractice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var addUserDto = new AddUserDto
            {
                Email = request.Email,
                Password = request.Password,
            };

            var result = await _userService.AddUser(addUserDto);
            if (result.IsSucceed)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);
        }




    }
}
