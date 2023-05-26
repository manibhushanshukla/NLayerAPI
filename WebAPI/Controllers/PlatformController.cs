using Buisness.Common;
using Buisness.Service;
using DataAccess;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly PlatformUserService _userService;
        private readonly DataContext _context;
        public PlatformController(PlatformUserService userService)
        {
            _userService = userService;
            
        }

        [HttpPost("PlatformUserRegistration")]
        public async Task<IActionResult> SuperRegistration(PlatformRegistration register)
        {
            try
            {
                var user = await _userService.SuperRegistration(register);

                GenricResponse response = new GenricResponse
                {
                    Response = HttpStatusCode.OK,
                    Status = true,
                   // Data = new { Token = user.PasswordCreationToken, UserId = user.Id },
                    Message = $"Successfully Registered and a link to create a password has been sent to your email: {user.email}"
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "An Error Occurred while processing the request");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("CreatePassword")]

        public async Task<IActionResult> CreatePassword(Platform_CreatePassword create)
        {
            var user = await _userService.CreatePassword(create);

            GenricResponse ab = new GenricResponse()
            {
                Response = HttpStatusCode.OK,
                Status = true,
                Message = $"Password Created SuccessFully"

            };

            return Ok(ab);
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(string email, string password)
        {
            var user = await _userService.Login(email, password);
            GenricResponse ab = new GenricResponse()
            {
                Response = HttpStatusCode.OK,
                Status = true,
                Data = new { },
                Message = "Successfully Logged in"

            };
            return Ok(user);

        }
    }
}
