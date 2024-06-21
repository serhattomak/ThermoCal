using Microsoft.AspNetCore.Mvc;
using ThermoCal.Core.DTOs;
using ThermoCal.Web.Services;

namespace ThermoCal.Web.Controllers
{
    public class CalculationController : Controller
    {
        private readonly CalculationApiService _calculationApiService;

        public CalculationController(CalculationApiService calculationApiService)
        {
            _calculationApiService = calculationApiService;
        }

        public async Task<IActionResult> AccelerationWork()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AccelerationWork([FromBody] AccelerationWorkRequestDto request)
        {
            var response = await _calculationApiService.CalculateAccelerationWork(request);

            if (response.StatusCode == 200)
            {
                return Ok(response);
            }

            return StatusCode(response.StatusCode, response.Errors);
        }
    }
}
