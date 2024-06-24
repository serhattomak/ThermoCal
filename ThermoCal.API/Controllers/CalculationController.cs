using Microsoft.AspNetCore.Mvc;
using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : Controller
    {
        private readonly ILogger<CalculationController> _logger;
        private readonly IAccelerationWorkService _accelerationWorkService;
        private readonly IAdiabaticEfficiencyNozzleService _adiabaticEfficiencyNozzleService;
        private readonly IAdiabaticEfficiencyOfCompressorService _adiabaticEfficiencyOfCompressorService;
        private readonly IAdiabaticEfficiencyOfPumpService _adiabaticEfficiencyOfPumpService;
        private readonly IAdiabaticEfficiencyOfTurbineService _adiabaticEfficiencyOfTurbineService;
        private readonly IAdiabaticExponentService _adiabaticExponentService;
        private readonly IAdiabaticPhaseChangeService _adiabaticPhaseChangeService;
        private readonly ICarnotHeatPumpCalculationService _carnotHeatPumpCalculationService;
        private readonly ICarnotRefrigeratorCalculationService _carnotRefrigeratorCalculationService;
        private readonly ICompressibilityMultiplierCalculationService _compressibilityMultiplierCalculationService;
        private readonly ICompressorCalculationService _compressorCalculationService;
        private readonly IConstantPressurePhaseChangeService _constantPressurePhaseChangeService;
        private readonly IConstantVolumePhaseChangeService _constantVolumePhaseChangeService;
        private readonly IDegreeOfDrynessCalculationService _degreeOfDrynessCalculationService;
        private readonly IDiffuserCalculationService _diffuserCalculationService;
        private readonly IElectricalWorkService _electricalWorkService;
        private readonly IEntropyBalanceForClosedSystemService _entropyBalanceForClosedSystemService;
        private readonly IEntropyBalanceForControlVolumeService _entropyBalanceForControlVolumeService;
        private readonly IEntropyCalculationForSteadyFlowOpenSystemService _entropyCalculationForSteadyFlowOpenSystemService;
        private readonly IEntropyCalculationForUniformFlowBalancedOpenSystemService _entropyCalculationForUniformFlowBalancedOpenSystemService;
        private readonly IEntropyCalculationService _entropyCalculationService;
        private readonly IEntropyChangeOfLiquidService _entropyChangeOfLiquidService;
        private readonly IEntropyChangeOfPerfectGasesApproximateService _entropyChangeOfPerfectGasesApproximateService;
        private readonly IEntropyChangeOfPerfectGasesExactService _entropyChangeOfPerfectGasesExactService;
        private readonly IEntropyChangeOfPureService _entropyChangeOfPureService;
        private readonly IEntropyChangeOfSolidService _entropyChangeOfSolidService;
        private readonly IExergyCalculationService _exergyCalculationService;
        private readonly IFlexibleRodWorkService _flexibleRodWorkService;
        private readonly IFlowCalculationInDuctService _flowCalculationInDuctService;
        private readonly IFlowCalculationInPipeService _flowCalculationInPipeService;
        private readonly IFlowWorkService _flowWorkService;
        private readonly IGravityWorkService _gravityWorkService;
        private readonly IHeatAndHeatTransferService _heatAndHeatTransferService;
        private readonly IHeatEngineCalculationService _heatEngineCalculationService;
        private readonly IHeatExchangersCalculationService _heatExchangersCalculationService;
        private readonly IHeatPumpEfficiencyService _heatPumpEfficiencyService;
        private readonly IIdealGasService _idealGasService;
        private readonly IIrreversibilityCalculationService _irreversibilityCalculationService;
        private readonly IIsentropicPhaseChangeOfPerfectGasesApproximateService _isentropicPhaseChangeOfPerfectGasesApproximateService;
        private readonly IIsentropicPhaseChangeOfPerfectGasesExactService _isentropicPhaseChangeOfPerfectGasesExactService;
        private readonly IIsothermalPhaseChangeService _isothermalPhaseChangeService;
        private readonly IMassFlowService _massFlowService;
        private readonly IMechanicalWorkService _mechanicalWorkService;
        private readonly IMinimizeCompressorWorkService _minimizeCompressorWorkService;
        private readonly IMixingChamberCalculationService _mixingChamberCalculationService;
        private readonly INozzleCalculationService _nozzleCalculationService;
        private readonly IPolytropicPhaseChangeService _polytropicPhaseChangeService;
        private readonly IPressureCalculationService _pressureCalculationService;
        private readonly IPumpCalculationService _pumpCalculationService;
        private readonly IReducedPressureAndTemperatureService _reducedPressureAndTemperatureService;
        private readonly IRefrigeratorCalculationService _refrigeratorCalculationService;
        private readonly IRefrigeratorEfficiencyService _refrigeratorEfficiencyService;
        private readonly IReversibleContinuousFlowCalculationService _reversibleContinousFlowCalculationService;
        private readonly IReversibleWorkCalculationService _reversibleWorkCalculationService;
        private readonly ISpindleWorkService _spindleWorkService;
        private readonly ISpringWorkService _springWorkService;
        private readonly ISteadyFlowCalculationService _steadyFlowCalculationService;
        private readonly IStressCalculationOfLiquidSurfaceService _stressCalculationOfLiquidSurfaceService;
        private readonly IThrottleValveCalculationService _throttleValveCalculationService;
        private readonly ITurbineCalculationService _turbineCalculationService;
        private readonly IUsefulWorkCalculationService _usefulWorkCalculationService;
        private readonly IVolumetricFlowService _volumetricFlowService;
        private readonly IWorkConsumingDeviceEfficiencyService _workConsumingDeviceEfficiencyService;
        private readonly IWorkProducingDeviceEfficiencyService _workProducingDeviceEfficiencyService;


        public CalculationController(IAccelerationWorkService accelerationWorkService,
            ILogger<CalculationController> logger,
            IAdiabaticEfficiencyNozzleService adiabaticEfficiencyNozzleService,
            IAdiabaticEfficiencyOfCompressorService adiabaticEfficiencyOfCompressorService,
            IAdiabaticEfficiencyOfPumpService adiabaticEfficiencyOfPumpService,
IAdiabaticEfficiencyOfTurbineService adiabaticEfficiencyOfTurbineService,
IAdiabaticExponentService adiabaticExponentService,
IAdiabaticPhaseChangeService adiabaticPhaseChangeService,
ICarnotHeatPumpCalculationService carnotHeatPumpCalculationService,
ICarnotRefrigeratorCalculationService carnotRefrigeratorCalculationService,
ICompressibilityMultiplierCalculationService compressibilityMultiplierCalculationService,
ICompressorCalculationService compressorCalculationService,
IConstantPressurePhaseChangeService constantPressurePhaseChangeService,
IConstantVolumePhaseChangeService constantVolumePhaseChangeService,
IDegreeOfDrynessCalculationService degreeOfDrynessCalculationService,
IDiffuserCalculationService diffuserCalculationService, IElectricalWorkService electricalWorkService,
IEntropyBalanceForClosedSystemService entropyBalanceForClosedSystemService,
IEntropyBalanceForControlVolumeService entropyBalanceForControlVolumeService,
IEntropyCalculationForSteadyFlowOpenSystemService entropyCalculationForSteadyFlowOpenSystemService,
IEntropyCalculationForUniformFlowBalancedOpenSystemService
    entropyCalculationForUniformFlowBalancedOpenSystemService,
IEntropyCalculationService entropyCalculationService,
IEntropyChangeOfLiquidService entropyChangeOfLiquidService,
IEntropyChangeOfPerfectGasesApproximateService entropyChangeOfPerfectGasesApproximateService,
IEntropyChangeOfPerfectGasesExactService entropyChangeOfPerfectGasesExactService,
IEntropyChangeOfPureService entropyChangeOfPureService,
IEntropyChangeOfSolidService entropyChangeOfSolidService, IExergyCalculationService exergyCalculationService,
 IFlexibleRodWorkService flexibleRodWorkService,
IFlowCalculationInDuctService flowCalculationInDuctService,
IFlowCalculationInPipeService flowCalculationInPipeService, IFlowWorkService flowWorkService, IGravityWorkService gravityWorkService,
IHeatAndHeatTransferService heatAndHeatTransferService,
IHeatEngineCalculationService heatEngineCalculationService,
IHeatExchangersCalculationService heatExchangersCalculationService,
IHeatPumpEfficiencyService heatPumpEfficiencyService, IIdealGasService idealGasService,
IIrreversibilityCalculationService irreversibilityCalculationService,
IIsentropicPhaseChangeOfPerfectGasesApproximateService
    isentropicPhaseChangeOfPerfectGasesApproximateService,
IIsentropicPhaseChangeOfPerfectGasesExactService isentropicPhaseChangeOfPerfectGasesExactService, IIsothermalPhaseChangeService isothermalPhaseChangeService, IMassFlowService massFlowService, IMechanicalWorkService mechanicalWorkService, IMinimizeCompressorWorkService minimizeCompressorWorkService, IMixingChamberCalculationService mixingChamberCalculationService, INozzleCalculationService nozzleCalculationService, IPolytropicPhaseChangeService polytropicPhaseChangeService, IPressureCalculationService pressureCalculationService, IPumpCalculationService pumpCalculationService, IReducedPressureAndTemperatureService reducedPressureAndTemperatureService, IRefrigeratorCalculationService refrigeratorCalculationService, IRefrigeratorEfficiencyService refrigeratorEfficiencyService, IReversibleContinuousFlowCalculationService reversibleContinousFlowCalculationService, IReversibleWorkCalculationService reversibleWorkCalculationService, ISpindleWorkService spindleWorkService, ISpringWorkService springWorkService, ISteadyFlowCalculationService steadyFlowCalculationService, IStressCalculationOfLiquidSurfaceService stressCalculationOfLiquidSurfaceService, IThrottleValveCalculationService throttleValveCalculationService, ITurbineCalculationService turbineCalculationService, IUsefulWorkCalculationService usefulWorkCalculationService, IVolumetricFlowService volumetricFlowService, IWorkConsumingDeviceEfficiencyService workConsumingDeviceEfficiencyService, IWorkProducingDeviceEfficiencyService workProducingDeviceEfficiencyService)
        {
            _accelerationWorkService = accelerationWorkService;
            _logger = logger;
            _adiabaticEfficiencyNozzleService = adiabaticEfficiencyNozzleService;
            _adiabaticEfficiencyOfCompressorService = adiabaticEfficiencyOfCompressorService;
            _adiabaticEfficiencyOfPumpService = adiabaticEfficiencyOfPumpService;
            _adiabaticEfficiencyOfTurbineService = adiabaticEfficiencyOfTurbineService;
            _adiabaticExponentService = adiabaticExponentService;
            _adiabaticPhaseChangeService = adiabaticPhaseChangeService;
            _carnotHeatPumpCalculationService = carnotHeatPumpCalculationService;
            _carnotRefrigeratorCalculationService = carnotRefrigeratorCalculationService;
            _compressibilityMultiplierCalculationService = compressibilityMultiplierCalculationService;
            _compressorCalculationService = compressorCalculationService;
            _constantPressurePhaseChangeService = constantPressurePhaseChangeService;
            _constantVolumePhaseChangeService = constantVolumePhaseChangeService;
            _degreeOfDrynessCalculationService = degreeOfDrynessCalculationService;
            _diffuserCalculationService = diffuserCalculationService;
            _electricalWorkService = electricalWorkService;
            _entropyBalanceForClosedSystemService = entropyBalanceForClosedSystemService;
            _entropyBalanceForControlVolumeService = entropyBalanceForControlVolumeService;
            _entropyCalculationForSteadyFlowOpenSystemService = entropyCalculationForSteadyFlowOpenSystemService;
            _entropyCalculationForUniformFlowBalancedOpenSystemService =
                entropyCalculationForUniformFlowBalancedOpenSystemService;
            _entropyCalculationService = entropyCalculationService;
            _entropyChangeOfLiquidService = entropyChangeOfLiquidService;
            _entropyChangeOfPerfectGasesApproximateService = entropyChangeOfPerfectGasesApproximateService;
            _entropyChangeOfPerfectGasesExactService = entropyChangeOfPerfectGasesExactService;
            _entropyChangeOfPureService = entropyChangeOfPureService;
            _entropyChangeOfSolidService = entropyChangeOfSolidService;
            _exergyCalculationService = exergyCalculationService;
            _flexibleRodWorkService = flexibleRodWorkService;
            _flowCalculationInDuctService = flowCalculationInDuctService;
            _flowCalculationInPipeService = flowCalculationInPipeService;
            _flowWorkService = flowWorkService;
            _gravityWorkService = gravityWorkService;
            _heatAndHeatTransferService = heatAndHeatTransferService;
            _heatEngineCalculationService = heatEngineCalculationService;
            _heatExchangersCalculationService = heatExchangersCalculationService;
            _heatPumpEfficiencyService = heatPumpEfficiencyService;
            _idealGasService = idealGasService;
            _irreversibilityCalculationService = irreversibilityCalculationService;
            _isentropicPhaseChangeOfPerfectGasesApproximateService =
                isentropicPhaseChangeOfPerfectGasesApproximateService;
            _isentropicPhaseChangeOfPerfectGasesExactService = isentropicPhaseChangeOfPerfectGasesExactService;
            _isothermalPhaseChangeService = isothermalPhaseChangeService;
            _massFlowService = massFlowService;
            _mechanicalWorkService = mechanicalWorkService;
            _minimizeCompressorWorkService = minimizeCompressorWorkService;
            _mixingChamberCalculationService = mixingChamberCalculationService;
            _nozzleCalculationService = nozzleCalculationService;
            _polytropicPhaseChangeService = polytropicPhaseChangeService;
            _pressureCalculationService = pressureCalculationService;
            _pumpCalculationService = pumpCalculationService;
            _reducedPressureAndTemperatureService = reducedPressureAndTemperatureService;
            _refrigeratorCalculationService = refrigeratorCalculationService;
            _refrigeratorEfficiencyService = refrigeratorEfficiencyService;
            _reversibleContinousFlowCalculationService = reversibleContinousFlowCalculationService;
            _reversibleWorkCalculationService = reversibleWorkCalculationService;
            _spindleWorkService = spindleWorkService;
            _springWorkService = springWorkService;
            _steadyFlowCalculationService = steadyFlowCalculationService;
            _stressCalculationOfLiquidSurfaceService = stressCalculationOfLiquidSurfaceService;
            _throttleValveCalculationService = throttleValveCalculationService;
            _turbineCalculationService = turbineCalculationService;
            _usefulWorkCalculationService = usefulWorkCalculationService;
            _volumetricFlowService = volumetricFlowService;
            _workConsumingDeviceEfficiencyService = workConsumingDeviceEfficiencyService;
            _workProducingDeviceEfficiencyService = workProducingDeviceEfficiencyService;

        }

        [HttpPost("AccelerationWork")]
        public async Task<IActionResult> CalculateAccelerationWork([FromBody] AccelerationWorkRequestDto request)
        {
            if (request == null)
            {
                _logger.LogError("Request is null.");
                return BadRequest(new { Errors = new List<string> { "Request cannot be null." } });
            }

            _logger.LogInformation("Received request: {@Request}", request);

            var response = await _accelerationWorkService.CalculateAccelerationWorkAsync(request);

            if (response == null || response.Data == null)
            {
                _logger.LogError("Service returned null response or null data.");
                return StatusCode(500, new { Errors = new List<string> { "Service returned null response or null data." } });
            }

            _logger.LogInformation("Sending response: {@Response}", response);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost("AdiabaticEfficiencyNozzle")]
        public async Task<IActionResult> CalculateAdiabaticEfficiencyNozzle([FromBody] AdiabaticEfficiencyNozzleRequestDto request)
        {
            var response = await _adiabaticEfficiencyNozzleService.CalculateAdiabaticEfficiencyNozzleAsync(request);
            return Ok(response);
        }
        [HttpPost("AdiabaticEfficiencyOfCompressor")]
        public async Task<IActionResult> CalculateAdiabaticEfficiencyOfCompressor([FromBody] AdiabaticEfficiencyOfCompressorRequestDto request)
        {
            var response = await _adiabaticEfficiencyOfCompressorService.CalculateAdiabaticEfficiencyOfCompressorAsync(request);
            return Ok(response);
        }
        [HttpPost("AdiabaticEfficiencyOfPump")]
        public async Task<IActionResult> CalculateAdiabaticEfficiencyOfPump([FromBody] AdiabaticEfficiencyOfPumpRequestDto request)
        {
            var response = await _adiabaticEfficiencyOfPumpService.CalculateAdiabaticEfficiencyOfPumpAsync(request);
            return Ok(response);
        }
        [HttpPost("AdiabaticEfficiencyOfTurbine")]
        public async Task<IActionResult> CalculateAdiabaticEfficiencyOfTurbine([FromBody] AdiabaticEfficiencyOfTurbineRequestDto request)
        {
            var response = await _adiabaticEfficiencyOfTurbineService.CalculateAdiabaticEfficiencyOfTurbineAsync(request);
            return Ok(response);
        }
        [HttpPost("AdiabaticExponent")]
        public async Task<IActionResult> CalculateAdiabaticExponent([FromBody] AdiabaticExponentRequestDto request)
        {
            var response = await _adiabaticExponentService.CalculateAdiabaticExponentAsync(request);
            return Ok(response);
        }
        [HttpPost("AdiabaticPhaseChange")]
        public async Task<IActionResult> CalculateAdiabaticPhaseChange([FromBody] AdiabaticPhaseChangeRequestDto request)
        {
            var response = await _adiabaticPhaseChangeService.CalculateAdiabaticPhaseChangeAsync(request);
            return Ok(response);
        }
        [HttpPost("CarnotHeatPump")]
        public async Task<IActionResult> CalculateCarnotHeatPump([FromBody] CarnotHeatPumpCalculationRequestDto request)
        {
            var response = await _carnotHeatPumpCalculationService.CalculateCarnotHeatPumpAsync(request);
            return Ok(response);
        }
        [HttpPost("CarnotRefrigerator")]
        public async Task<IActionResult> CalculateCarnotRefrigerator([FromBody] CarnotRefrigeratorCalculationRequestDto request)
        {
            var response = await _carnotRefrigeratorCalculationService.CalculateCarnotRefrigeratorAsync(request);
            return Ok(response);
        }
        [HttpPost("CompressibilityMultiplier")]
        public async Task<IActionResult> CalculateCompressibilityMultiplier([FromBody] CompressibilityMultiplierCalculationRequestDto request)
        {
            var response = await _compressibilityMultiplierCalculationService.CalculateCompressibilityMultiplierAsync(request);
            return Ok(response);
        }
        [HttpPost("Compressor")]
        public async Task<IActionResult> CalculateCompressorCalculation([FromBody] CompressorCalculationRequestDto request)
        {
            var response = await _compressorCalculationService.CalculateCompressorCalculationAsync(request);
            return Ok(response);
        }
        [HttpPost("ConstantPressurePhaseChange")]
        public async Task<IActionResult> CalculateConstantPressurePhaseChange([FromBody] ConstantPressurePhaseChangeRequestDto request)
        {
            var response = await _constantPressurePhaseChangeService.CalculateConstantPressurePhaseChangeAsync(request);
            return Ok(response);
        }
        [HttpPost("ConstantVolumePhaseChange")]
        public async Task<IActionResult> CalculateConstantVolumePhaseChange([FromBody] ConstantVolumePhaseChangeRequestDto request)
        {
            var response = await _constantVolumePhaseChangeService.CalculateConstantVolumePhaseChangeAsync(request);
            return Ok(response);
        }
        [HttpPost("DegreeOfDryness")]
        public async Task<IActionResult> CalculateDegreeOfDryness([FromBody] DegreeOfDrynessCalculationRequestDto request)
        {
            var response = await _degreeOfDrynessCalculationService.CalculateDegreeOfDrynessAsync(request);
            return Ok(response);
        }
        [HttpPost("Diffuser")]
        public async Task<IActionResult> CalculateDiffuser([FromBody] DiffuserCalculationRequestDto request)
        {
            var response = await _diffuserCalculationService.CalculateDiffuserAsync(request);
            return Ok(response);
        }
        [HttpPost("ElectricalWork")]
        public async Task<IActionResult> CalculateElectricalWork([FromBody] ElectricalWorkRequestDto request)
        {
            var response = await _electricalWorkService.CalculateElectricalWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyBalanceForClosedSystem")]
        public async Task<IActionResult> CalculateEntropyBalanceForClosedSystem([FromBody] EntropyBalanceForClosedSystemRequestDto request)
        {
            var response = await _entropyBalanceForClosedSystemService.CalculateEntropyBalanceForClosedSystemAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyBalanceForControlVolume")]
        public async Task<IActionResult> CalculateEntropyBalanceForControlVolume([FromBody] EntropyBalanceForControlVolumeRequestDto request)
        {
            var response = await _entropyBalanceForControlVolumeService.CalculateEntropyBalanceForControlVolumeAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyCalculationForSteadyFlowOpenSystem")]
        public async Task<IActionResult> CalculateEntropyCalculationForSteadyFlowOpenSystem([FromBody] EntropyCalculationForSteadyFlowOpenSystemRequestDto request)
        {
            var response = await _entropyCalculationForSteadyFlowOpenSystemService
                .CalculateEntropyCalculationForSteadyFlowOpenSystemAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyCalculationForUniformFlowBalancedOpenSystem")]
        public async Task<IActionResult> CalculateEntropyCalculationForUniformFlowBalancedOpenSystem([FromBody] EntropyCalculationForUniformFlowBalancedOpenSystemRequestDto request)
        {
            var response = await _entropyCalculationForUniformFlowBalancedOpenSystemService
                .CalculateEntropyCalculationForUniformFlowBalancedOpenSystemAsync(request);
            return Ok(response);
        }
        [HttpPost("Entropy")]
        public async Task<IActionResult> CalculateEntropy([FromBody] EntropyCalculationRequestDto request)
        {
            var response = await _entropyCalculationService.CalculateEntropyAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyChangeOfLiquid")]
        public async Task<IActionResult> CalculateEntropyChangeOfLiquid([FromBody] EntropyChangeOfLiquidRequestDto request)
        {
            var response = await _entropyChangeOfLiquidService.CalculateEntropyChangeOfLiquidAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyChangeOfPerfectGasesApproximate")]
        public async Task<IActionResult> CalculateEntropyChangeOfPerfectGasesApproximate([FromBody] EntropyChangeOfPerfectGasesApproximateRequestDto request)
        {
            var response = await _entropyChangeOfPerfectGasesApproximateService
                .CalculateEntropyChangeOfPerfectGasesApproximateAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyChangeOfPerfectGasesExact")]
        public async Task<IActionResult> CalculateEntropyChangeOfPerfectGasesExact([FromBody] EntropyChangeOfPerfectGasesExactRequestDto request)
        {
            var response = await _entropyChangeOfPerfectGasesExactService.CalculateEntropyChangeOfPerfectGasesExactAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyChangeOfPure")]
        public async Task<IActionResult> CalculateEntropyChangeOfPure([FromBody] EntropyChangeOfPureRequestDto request)
        {
            var response = await _entropyChangeOfPureService.CalculateEntropyChangeOfPureAsync(request);
            return Ok(response);
        }
        [HttpPost("EntropyChangeOfSolid")]
        public async Task<IActionResult> CalculateEntropyChangeOfSolid([FromBody] EntropyChangeOfSolidRequestDto request)
        {
            var response = await _entropyChangeOfSolidService.CalculateEntropyChangeOfSolidAsync(request);
            return Ok(response);
        }
        [HttpPost("Exergy")]
        public async Task<IActionResult> CalculateExergy([FromBody] ExergyCalculationRequestDto request)
        {
            var response = await _exergyCalculationService.CalculateExergyAsync(request);
            return Ok(response);
        }
        [HttpPost("FlexibleRodWork")]
        public async Task<IActionResult> CalculateFlexibleRodWork([FromBody] FlexibleRodWorkRequestDto request)
        {
            var response = await _flexibleRodWorkService.CalculateFlexibleRodWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("FlowCalculationInDuct")]
        public async Task<IActionResult> CalculateFlowCalculationInDuct([FromBody] FlowCalculationInDuctRequestDto request)
        {
            var response = await _flowCalculationInDuctService.CalculateFlowCalculationInDuctAsync(request);
            return Ok(response);
        }
        [HttpPost("FlowCalculationInPipe")]
        public async Task<IActionResult> CalculateFlowCalculationInPipe([FromBody] FlowCalculationInPipeRequestDto request)
        {
            var response = await _flowCalculationInPipeService.CalculateFlowCalculationInPipeAsync(request);
            return Ok(response);
        }
        [HttpPost("FlowWork")]
        public async Task<IActionResult> CalculateFlowWork([FromBody] FlowWorkRequestDto request)
        {
            var response = await _flowWorkService.CalculateFlowWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("GravityWork")]
        public async Task<IActionResult> CalculateGravityWork([FromBody] GravityWorkRequestDto request)
        {
            var response = await _gravityWorkService.CalculateGravityWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("HeatAndHeatTransfer")]
        public async Task<IActionResult> CalculateHeatAndHeatTransfer([FromBody] HeatAndHeatTransferRequestDto request)
        {
            var response = await _heatAndHeatTransferService.CalculateHeatAndHeatTransferAsync(request);
            return Ok(response);
        }
        [HttpPost("HeatEngine")]
        public async Task<IActionResult> CalculateHeatEngine([FromBody] HeatEngineCalculationRequestDto request)
        {
            var response = await _heatEngineCalculationService.CalculateHeatEngineAsync(request);
            return Ok(response);
        }
        [HttpPost("HeatExchangers")]
        public async Task<IActionResult> CalculateHeatExchangers([FromBody] HeatExchangersCalculationRequestDto request)
        {
            var response = await _heatExchangersCalculationService.CalculateHeatExchangersAsync(request);
            return Ok(response);
        }
        [HttpPost("HeatPumpEfficiency")]
        public async Task<IActionResult> CalculateHeatPumpEfficiency([FromBody] HeatPumpEfficiencyRequestDto request)
        {
            var response = await _heatPumpEfficiencyService.CalculateHeatPumpEfficiencyAsync(request);
            return Ok(response);
        }
        [HttpPost("IdealGas")]
        public async Task<IActionResult> CalculateIdealGas([FromBody] IdealGasRequestDto request)
        {
            var response = await _idealGasService.CalculateIdealGasAsync(request);
            return Ok(response);
        }
        [HttpPost("Irreversibility")]
        public async Task<IActionResult> CalculateIrreversibility([FromBody] IrreversibilityCalculationRequestDto request)
        {
            var response = await _irreversibilityCalculationService.CalculateIrreversibilityAsync(request);
            return Ok(response);
        }
        [HttpPost("IsentropicPhaseChangeOfPerfectGasesApproximate")]
        public async Task<IActionResult> CalculateIsentropicPhaseChangeOfPerfectGasesApproximate([FromBody] IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto request)
        {
            var response = await _isentropicPhaseChangeOfPerfectGasesApproximateService
                .CalculateIsentropicPhaseChangeOfPerfectGasesApproximateAsync(request);
            return Ok(response);
        }
        [HttpPost("IsentropicPhaseChangeOfPerfectGasesExact")]
        public async Task<IActionResult> CalculateIsentropicPhaseChangeOfPerfectGasesExact([FromBody] IsentropicPhaseChangeOfPerfectGasesExactRequestDto request)
        {
            var response = await _isentropicPhaseChangeOfPerfectGasesExactService
                .CalculateIsentropicPhaseChangeOfPerfectGasesExactAsync(request);
            return Ok(response);
        }
        [HttpPost("IsothermalPhaseChange")]
        public async Task<IActionResult> CalculateIsothermalPhaseChange([FromBody] IsothermalPhaseChangeRequestDto request)
        {
            var response = await _isothermalPhaseChangeService.CalculateIsothermalPhaseChangeAsync(request);
            return Ok(response);
        }
        [HttpPost("MassFlow")]
        public async Task<IActionResult> CalculateMassFlow([FromBody] MassFlowRequestDto request)
        {
            var response = await _massFlowService.CalculateMassFlowAsync(request);
            return Ok(response);
        }
        [HttpPost("MechanicalWork")]
        public async Task<IActionResult> CalculateMechanicalWork([FromBody] MechanicalWorkRequestDto request)
        {
            var response = await _mechanicalWorkService.CalculateMechanicalWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("MinimizeCompressorWork")]
        public async Task<IActionResult> CalculateMinimizeCompressorWork([FromBody] MinimizeCompressorWorkRequestDto request)
        {
            var response = await _minimizeCompressorWorkService.CalculateMinimizeCompressorWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("MixingChamber")]
        public async Task<IActionResult> CalculateMixingChamber([FromBody] MixingChamberCalculationRequestDto request)
        {
            var response = await _mixingChamberCalculationService.CalculateMixingChamberAsync(request);
            return Ok(response);
        }
        [HttpPost("Nozzle")]
        public async Task<IActionResult> CalculateNozzle([FromBody] NozzleCalculationRequestDto request)
        {
            var response = await _nozzleCalculationService.CalculateNozzleAsync(request);
            return Ok(response);
        }
        [HttpPost("PolytropicPhaseChange")]
        public async Task<IActionResult> CalculatePolytropicPhaseChange([FromBody] PolytropicPhaseChangeRequestDto request)
        {
            var response = await _polytropicPhaseChangeService.CalculatePolytropicPhaseChangeAsync(request);
            return Ok(response);
        }
        [HttpPost("Pressure")]
        public async Task<IActionResult> CalculatePressure([FromBody] PressureCalculationRequestDto request)
        {
            var response = await _pressureCalculationService.CalculatePressureAsync(request);
            return Ok(response);
        }
        [HttpPost("Pump")]
        public async Task<IActionResult> CalculatePump([FromBody] PumpCalculationRequestDto request)
        {
            var response = await _pumpCalculationService.CalculatePumpAsync(request);
            return Ok(response);
        }
        [HttpPost("ReducedPressureAndTemperature")]
        public async Task<IActionResult> CalculateReducedPressureAndTemperature([FromBody] ReducedPressureAndTemperatureRequestDto request)
        {
            var response = await _reducedPressureAndTemperatureService.CalculateReducedPressureAndTemperatureAsync(request);
            return Ok(response);
        }
        [HttpPost("Refrigerator")]
        public async Task<IActionResult> CalculateRefrigerator([FromBody] RefrigeratorCalculationRequestDto request)
        {
            var response = await _refrigeratorCalculationService.CalculateRefrigeratorAsync(request);
            return Ok(response);
        }
        [HttpPost("RefrigeratorEfficiency")]
        public async Task<IActionResult> CalculateRefrigeratorEfficiency([FromBody] RefrigeratorEfficiencyRequestDto request)
        {
            var response = await _refrigeratorEfficiencyService.CalculateRefrigeratorEfficiencyAsync(request);
            return Ok(response);
        }
        [HttpPost("ReversibleContinuousFlow")]
        public async Task<IActionResult> CalculateReversibleContinousFlow([FromBody] ReversibleContinuousFlowCalculationRequestDto request)
        {
            var response = await _reversibleContinousFlowCalculationService.CalculateReversibleContinuousFlowAsync(request);
            return Ok(response);
        }
        [HttpPost("ReversibleWork")]
        public async Task<IActionResult> CalculateReversibleWork([FromBody] ReversibleWorkCalculationRequestDto request)
        {
            var response = await _reversibleWorkCalculationService.CalculateReversibleWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("SpindleWork")]
        public async Task<IActionResult> CalculateSpindleWork([FromBody] SpindleWorkRequestDto request)
        {
            var response = await _spindleWorkService.CalculateSpindleWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("SpringWork")]
        public async Task<IActionResult> CalculateSpringWork([FromBody] SpringWorkRequestDto request)
        {
            var response = await _springWorkService.CalculateSpringWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("SteadyFlow")]
        public async Task<IActionResult> CalculateSteadyFlow([FromBody] SteadyFlowCalculationRequestDto request)
        {
            var response = await _steadyFlowCalculationService.CalculateSteadyFlowAsync(request);
            return Ok(response);
        }
        [HttpPost("StressCalculationOfLiquidSurface")]
        public async Task<IActionResult> CalculateStressCalculationOfLiquidSurface([FromBody] StressCalculationOfLiquidSurfaceRequestDto request)
        {
            var response = await _stressCalculationOfLiquidSurfaceService.CalculateStressOfLiquidSurfaceAsync(request);
            return Ok(response);
        }

        [HttpPost("ThrottleValve")]
        public async Task<IActionResult> CalculateThrottleValve([FromBody] ThrottleValveCalculationRequestDto request)
        {
            var response = await _throttleValveCalculationService.CalculateThrottleValveAsync(request);
            return Ok(response);
        }
        [HttpPost("Turbine")]
        public async Task<IActionResult> CalculateTurbine([FromBody] TurbineCalculationRequestDto request)
        {
            var response = await _turbineCalculationService.CalculateTurbineAsync(request);
            return Ok(response);
        }
        [HttpPost("UsefulWork")]
        public async Task<IActionResult> CalculateUsefulWork([FromBody] UsefulWorkCalculationRequestDto request)
        {
            var response = await _usefulWorkCalculationService.CalculateUsefulWorkAsync(request);
            return Ok(response);
        }
        [HttpPost("VolumetricFlow")]
        public async Task<IActionResult> CalculateVolumetricFlow([FromBody] VolumetricFlowRequestDto request)
        {
            var response = await _volumetricFlowService.CalculateVolumetricFlowAsync(request);
            return Ok(response);
        }
        [HttpPost("WorkConsumingDeviceEfficiency")]
        public async Task<IActionResult> CalculateWorkConsumingDeviceEfficiency([FromBody] WorkConsumingDeviceEfficiencyRequestDto request)
        {
            var response = await _workConsumingDeviceEfficiencyService.CalculateWorkConsumingDeviceEfficiencyAsync(request);
            return Ok(response);
        }
        [HttpPost("WorkProducingDeviceEfficiency")]
        public async Task<IActionResult> CalculateWorkProducingDeviceEfficiency([FromBody] WorkProducingDeviceEfficiencyRequestDto request)
        {
            var response = await _workProducingDeviceEfficiencyService.CalculateWorkProducingDeviceEfficiencyAsync(request);
            return Ok(response);
        }
    }
}
