using Microsoft.AspNetCore.Mvc;
using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.API.Controllers
{
    public class AccelerationWorkController : Controller
    {
        private readonly IAccelerationWorkService _accelerationWorkService; 

        public AccelerationWorkController(IAccelerationWorkService accelerationWorkService)
        {
            _accelerationWorkService = accelerationWorkService;
        }

        [HttpPost]
        public IActionResult CalculateAccelerationWork([FromBody] AccelerationWorkRequestDto request)
        {
            var response = _accelerationWorkService.CalculateAccelerationWork(request);
            return Ok(response);
        }
    }
}
