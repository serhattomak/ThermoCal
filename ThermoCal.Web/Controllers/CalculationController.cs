using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
