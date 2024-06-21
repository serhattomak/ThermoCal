using Microsoft.AspNetCore.Mvc;
using ThermoCal.Core.DTOs;
using ThermoCal.Web.Services;

namespace ThermoCal.Web.Controllers
{
    public class CalculationController : Controller
    {
        private readonly ILogger<CalculationController> _logger;
        private readonly CalculationApiService _calculationApiService;

        public CalculationController(CalculationApiService calculationApiService, ILogger<CalculationController> logger)
        {
            _calculationApiService = calculationApiService;
            _logger = logger;
        }

        public async Task<IActionResult> AccelerationWork()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AccelerationWork([FromBody] AccelerationWorkRequestDto request)
        {
            try
            {
                var response = await _calculationApiService.CalculateAccelerationWork(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating acceleration work.");

                return StatusCode(500, e.Message);
            }
        }
    }
}
