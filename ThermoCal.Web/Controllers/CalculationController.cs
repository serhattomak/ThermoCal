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
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

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

        public async Task<IActionResult> AdiabaticEfficiencyNozzle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdiabaticEfficiencyNozzle([FromBody] AdiabaticEfficiencyNozzleRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateAdiabaticEfficiencyNozzle(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency nozzle.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> AdiabaticEfficiencyOfCompressor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdiabaticEfficiencyOfCompressor([FromBody] AdiabaticEfficiencyOfCompressorRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateAdiabaticEfficiencyOfCompressor(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of compressor.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> AdiabaticEfficiencyOfPump()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdiabaticEfficiencyOfPump([FromBody] AdiabaticEfficiencyOfPumpRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateAdiabaticEfficiencyOfPump(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of pump.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> AdiabaticEfficiencyOfTurbine()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdiabaticEfficiencyOfTurbine([FromBody] AdiabaticEfficiencyOfTurbineRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateAdiabaticEfficiencyOfTurbine(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of turbine.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> AdiabaticExponent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdiabaticExponent([FromBody] AdiabaticExponentRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateAdiabaticExponent(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic exponent.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> AdiabaticPhaseChange()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdiabaticPhaseChange([FromBody] AdiabaticPhaseChangeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateAdiabaticPhaseChange(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> CarnotHeatPump()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CarnotHeatPump([FromBody] CarnotHeatPumpCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateCarnotHeatPump(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating carnot heat pump.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> CarnotRefrigerator()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CarnotRefrigerator([FromBody] CarnotRefrigeratorCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateCarnotRefrigerator(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating carnot refrigerator.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> CompressibilityMultiplier()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CompressibilityMultiplier([FromBody] CompressibilityMultiplierCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateCompressibilityMultiplier(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating compressibility multiplier.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Compressor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Compressor([FromBody] CompressorCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateCompressor(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating compressor.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ConstantPressurePhaseChange()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConstantPressurePhaseChange([FromBody] ConstantPressurePhaseChangeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateConstantPressurePhaseChange(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating constant pressure phase change.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ConstantVolumePhaseChange()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConstantVolumePhaseChange([FromBody] ConstantVolumePhaseChangeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateConstantVolumePhaseChange(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating constant volume phase change.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> DegreeOfDryness()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DegreeOfDryness([FromBody] DegreeOfDrynessCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateDegreeOfDryness(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating degree of dryness.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Diffuser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Diffuser([FromBody] DiffuserCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateDiffuser(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating diffuser.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ElectricalWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ElectricalWork([FromBody] ElectricalWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateElectricalWork(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating electrical work.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyBalanceForClosedSystem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyBalanceForClosedSystem([FromBody] EntropyBalanceForClosedSystemRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyBalanceForClosedSystem(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy balance for closed system.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyBalanceForControlVolume()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyBalanceForControlVolume([FromBody] EntropyBalanceForControlVolumeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyBalanceForControlVolume(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy balance for control volume.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyCalculationForSteadyFlowOpenSystem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyCalculationForSteadyFlowOpenSystem([FromBody] EntropyCalculationForSteadyFlowOpenSystemRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyCalculationForSteadyFlowOpenSystem(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy calculation for steady flow open system.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyCalculationForUniformFlowBalancedOpenSystem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyCalculationForUniformFlowBalancedOpenSystem([FromBody] EntropyCalculationForUniformFlowBalancedOpenSystemRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyCalculationForUniformFlowBalancedOpenSystem(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy calculation for uniform flow balanced open system.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Entropy()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Entropy([FromBody] EntropyCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyChangeOfLiquid()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyChangeOfLiquid([FromBody] EntropyChangeOfLiquidRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyChangeOfLiquid(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy change of liquid.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyChangeOfPerfectGasesApproximate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyChangeOfPerfectGasesApproximate([FromBody] EntropyChangeOfPerfectGasesApproximateRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyChangeOfPerfectGasesApproximate(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy change of perfect gases approximate.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyChangeOfPerfectGasesExact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyChangeOfPerfectGasesExact([FromBody] EntropyChangeOfPerfectGasesExactRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyChangeOfPerfectGasesExact(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy change of perfect gases exact.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyChangeOfPure()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyChangeOfPure([FromBody] EntropyChangeOfPureRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyChangeOfPureSubstance(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy change of pure substance.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> EntropyChangeOfSolid()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EntropyChangeOfSolid([FromBody] EntropyChangeOfSolidRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateEntropyChangeOfSolidSubstance(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating entropy change of solid substance.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Exergy()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Exergy([FromBody] ExergyCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateExergyCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating exergy calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> FlexibleRodWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FlexibleRodWork([FromBody] FlexibleRodWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateFlexibleRodWork(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating flexible rod work.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> FlowCalculationInDuct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FlowCalculationInDuct([FromBody] FlowCalculationInDuctRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateFlowCalculationInDuct(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating flow calculation in duct.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> FlowCalculationInPipe()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FlowCalculationInPipe([FromBody] FlowCalculationInPipeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateFlowCalculationInPipe(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating flow calculation in pipe.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> FlowWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FlowWork([FromBody] FlowWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateFlowWork(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating flow work.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> GibbsEquation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GibbsEquation([FromBody] GibbsEquationCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateGibbsEquationCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating gibbs equation calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> GravityWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GravityWork([FromBody] GravityWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateGravityWork(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating gravity work.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> HeatAndHeatTransfer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HeatAndHeatTransfer([FromBody] HeatAndHeatTransferRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateHeatAndHeatTransferCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating heat and heat transfer calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> HeatEngine()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HeatEngine([FromBody] HeatEngineCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateHeatEngineCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating heat engine calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> HeatExchangers()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HeatExchangers([FromBody] HeatExchangersCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateHeatExchangersCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating heat exchangers calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> HeatPumpEfficiency()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HeatPumpEfficiency([FromBody] HeatPumpEfficiencyRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateHeatPumpEfficiencyCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating heat pump efficiency calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> IdealGas()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IdealGas([FromBody] IdealGasRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateIdealGasCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating ideal gas calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Irreversibility()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Irreversibility([FromBody] IrreversibilityCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateIrreversibilityCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating irreversibility calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> IsentropicPhaseChangeOfPerfectGasesApproximate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IsentropicPhaseChangeOfPerfectGasesApproximate([FromBody] IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateIsentropicPhaseChangeOfPerfectGasesApproximateCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating isentropic phase change of perfect gases approximate calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> IsentropicPhaseChangeOfPerfectGasesExact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IsentropicPhaseChangeOfPerfectGasesExact([FromBody] IsentropicPhaseChangeOfPerfectGasesExactRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateIsentropicPhaseChangeOfPerfectGasesExactCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating isentropic phase change of perfect gases exact calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> IsothermalPhaseChange()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IsothermalPhaseChange([FromBody] IsothermalPhaseChangeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateIsothermalPhaseChangeCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating isothermal phase change calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> MassFlow()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MassFlow([FromBody] MassFlowRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateMassFlowCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating mass flow calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> MechanicalWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MechanicalWork([FromBody] MechanicalWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateMechanicalWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating mechanical work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> MinimizeCompressorWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MinimizeCompressorWork([FromBody] MinimizeCompressorWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateMinimizeCompressorWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating minimize compressor work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> MixingChamber()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MixingChamber([FromBody] MixingChamberCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateMixingChamberCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating mixing chamber calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Nozzle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Nozzle([FromBody] NozzleCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateNozzleCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating nozzle calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> PolytropicPhaseChange()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PolytropicPhaseChange([FromBody] PolytropicPhaseChangeRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculatePolytropicPhaseChangeCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating polytropic phase change calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Pressure()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Pressure([FromBody] PressureCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculatePressureCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating pressure calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Pump()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Pump([FromBody] PumpCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculatePumpCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating pump calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ReducedPressureAndTemperature()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ReducedPressureAndTemperature([FromBody] ReducedPressureAndTemperatureRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateReducedPressureAndTemperatureCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating reduced pressure and temperature calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Refrigerator()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Refrigerator([FromBody] RefrigeratorCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateRefrigeratorCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating refrigerator calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> RefrigeratorEfficiency()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RefrigeratorEfficiency([FromBody] RefrigeratorEfficiencyRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateRefrigeratorEfficiencyCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating refrigerator efficiency calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ReversibleContinuousFlow()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ReversibleContinuousFlow([FromBody] ReversibleContinuousFlowCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateReversibleContinuousFlowCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating reversible continuous flow calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ReversibleWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ReversibleWork([FromBody] ReversibleWorkCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateReversibleWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating reversible work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> SpindleWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SpindleWork([FromBody] SpindleWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateSpindleWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating spindle work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> SpringWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SpringWork([FromBody] SpringWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateSpringWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating spring work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> SteadyFlow()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SteadyFlow([FromBody] SteadyFlowCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateSteadyFlowCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating steady flow calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> StressCalculationOfLiquidSurface()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> StressCalculationOfLiquidSurface([FromBody] StressCalculationOfLiquidSurfaceRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateStressCalculationOfLiquidSurface(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating stress calculation of liquid surface.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> SurroundWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SurroundWork([FromBody] SurroundWorkCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateSurroundWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating surround work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> ThrottleValve()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ThrottleValve([FromBody] ThrottleValveCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateThrottleValveCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating throttle valve calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> Turbine()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Turbine([FromBody] TurbineCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateTurbineCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating turbine calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> UsefulWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UsefulWork([FromBody] UsefulWorkCalculationRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateUsefulWorkCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating useful work calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> VolumetricFlow()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> VolumetricFlow([FromBody] VolumetricFlowRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateVolumetricFlowCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating volumetric flow calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> WorkConsumingDeviceEfficiency()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> WorkConsumingDeviceEfficiency([FromBody] WorkConsumingDeviceEfficiencyRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateWorkConsumingDeviceEfficiencyCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating work consuming device efficiency calculation.");
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult> WorkProducingDeviceEfficiency()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> WorkProducingDeviceEfficiency([FromBody] WorkProducingDeviceEfficiencyRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest("Request cannot be null.");
            }

            try
            {
                var response = await _calculationApiService.CalculateWorkProducingDeviceEfficiencyCalculation(request);

                if (response.StatusCode == 200)
                {
                    return Ok(response);
                }

                return StatusCode(response.StatusCode, response.Errors);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating work producing device efficiency calculation.");
                return StatusCode(500, e.Message);
            }
        }
    }
}
