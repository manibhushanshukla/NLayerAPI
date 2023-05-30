using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperLogistic.Domain.Repository;

namespace SuperLogistic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlatformController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            
        }
        [HttpGet]
        public ActionResult Get()
        {
            var user = _unitOfWork.Platform_User.GetAll();
            return Ok(user);
        }

    }
}
