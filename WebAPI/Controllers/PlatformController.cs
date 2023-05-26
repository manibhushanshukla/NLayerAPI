using Buisness.Common;
using Buisness.Service;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly PlatformUserService _userService;

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
    }
}
