using Microsoft.AspNetCore.Mvc;
using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.API.Controllers
{
    public class CalculationsController : Controller
    {
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
        private readonly IGibbsEquationCalculationService _gibbsEquationCalculationService;
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
        private readonly IReversibleContinousFlowCalculationService _reversibleContinousFlowCalculationService;
        private readonly IReversibleWorkCalculationService _reversibleWorkCalculationService;
        private readonly ISpindleWorkService _spindleWorkService;
        private readonly ISpringWorkService _springWorkService;
        private readonly ISteadyFlowCalculationService _steadyFlowCalculationService;
        private readonly IStressCalculationOfLiquidSurfaceService _stressCalculationOfLiquidSurfaceService;
        private readonly ISurroundWorkCalculationService _surroundWorkCalculationService;
        private readonly IThrottleValveCalculationService _throttleValveCalculationService;
        private readonly ITurbineCalculationService _turbineCalculationService;
        private readonly IUsefulWorkCalculationService _usefulWorkCalculationService;
        private readonly IVolumetricFlowService _volumetricFlowService;
        private readonly IWorkConsumingDeviceEfficiencyService _workConsumingDeviceEfficiencyService;
        private readonly IWorkProducingDeviceEfficiencyService _workProducingDeviceEfficiencyService;

        public CalculationsController(IAccelerationWorkService accelerationWorkService,
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
            IEntropyChangeOfSolidService entropyChangeOfSolidService,
            IExergyCalculationService exergyCalculationService, IFlexibleRodWorkService flexibleRodWorkService,
            IFlowCalculationInDuctService flowCalculationInDuctService,
            IFlowCalculationInPipeService flowCalculationInPipeService, IFlowWorkService flowWorkService,
            IGibbsEquationCalculationService gibbsEquationCalculationService, IGravityWorkService gravityWorkService,
            IHeatAndHeatTransferService heatAndHeatTransferService,
            IHeatEngineCalculationService heatEngineCalculationService,
            IHeatExchangersCalculationService heatExchangersCalculationService,
            IHeatPumpEfficiencyService heatPumpEfficiencyService, IIdealGasService idealGasService,
            IIrreversibilityCalculationService irreversibilityCalculationService,
            IIsentropicPhaseChangeOfPerfectGasesApproximateService
                isentropicPhaseChangeOfPerfectGasesApproximateService,
            IIsentropicPhaseChangeOfPerfectGasesExactService isentropicPhaseChangeOfPerfectGasesExactService, IIsothermalPhaseChangeService isothermalPhaseChangeService, IMassFlowService massFlowService, IMechanicalWorkService mechanicalWorkService, IMinimizeCompressorWorkService minimizeCompressorWorkService, IMixingChamberCalculationService mixingChamberCalculationService, INozzleCalculationService nozzleCalculationService, IPolytropicPhaseChangeService polytropicPhaseChangeService, IPressureCalculationService pressureCalculationService, IPumpCalculationService pumpCalculationService, IReducedPressureAndTemperatureService reducedPressureAndTemperatureService, IRefrigeratorCalculationService refrigeratorCalculationService, IRefrigeratorEfficiencyService refrigeratorEfficiencyService, IReversibleContinousFlowCalculationService reversibleContinousFlowCalculationService, IReversibleWorkCalculationService reversibleWorkCalculationService, ISpindleWorkService spindleWorkService, ISpringWorkService springWorkService, ISteadyFlowCalculationService steadyFlowCalculationService, IStressCalculationOfLiquidSurfaceService stressCalculationOfLiquidSurfaceService, ISurroundWorkCalculationService surroundWorkCalculationService, IThrottleValveCalculationService throttleValveCalculationService, ITurbineCalculationService turbineCalculationService, IUsefulWorkCalculationService usefulWorkCalculationService, IVolumetricFlowService volumetricFlowService, IWorkConsumingDeviceEfficiencyService workConsumingDeviceEfficiencyService, IWorkProducingDeviceEfficiencyService workProducingDeviceEfficiencyService)
        {
            _accelerationWorkService = accelerationWorkService;
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
            _gibbsEquationCalculationService = gibbsEquationCalculationService;
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
            _surroundWorkCalculationService = surroundWorkCalculationService;
            _throttleValveCalculationService = throttleValveCalculationService;
            _turbineCalculationService = turbineCalculationService;
            _usefulWorkCalculationService = usefulWorkCalculationService;
            _volumetricFlowService = volumetricFlowService;
            _workConsumingDeviceEfficiencyService = workConsumingDeviceEfficiencyService;
            _workProducingDeviceEfficiencyService = workProducingDeviceEfficiencyService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalculateAccelerationWork([FromBody] AccelerationWorkRequestDto request)
        {
            var response = _accelerationWorkService.CalculateAccelerationWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateAdiabaticEfficiencyNozzle([FromBody] AdiabaticEfficiencyNozzleRequestDto request)
        {
            var response = _adiabaticEfficiencyNozzleService.CalculateAdiabaticEfficiencyNozzle(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateAdiabaticEfficiencyOfCompressor([FromBody] AdiabaticEfficiencyOfCompressorRequestDto request)
        {
            var response = _adiabaticEfficiencyOfCompressorService.CalculateAdiabaticEfficiencyOfCompressor(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateAdiabaticEfficiencyOfPump([FromBody] AdiabaticEfficiencyOfPumpRequestDto request)
        {
            var response = _adiabaticEfficiencyOfPumpService.CalculateAdiabaticEfficiencyOfPump(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateAdiabaticEfficiencyOfTurbine([FromBody] AdiabaticEfficiencyOfTurbineRequestDto request)
        {
            var response = _adiabaticEfficiencyOfTurbineService.CalculateAdiabaticEfficiencyOfTurbine(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateAdiabaticExponent([FromBody] AdiabaticExponentRequestDto request)
        {
            var response = _adiabaticExponentService.CalculateAdiabaticExponent(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateAdiabaticPhaseChange([FromBody] AdiabaticPhaseChangeRequestDto request)
        {
            var response = _adiabaticPhaseChangeService.CalculateAdiabaticPhaseChange(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateCarnotHeatPump([FromBody] CarnotHeatPumpCalculationRequestDto request)
        {
            var response = _carnotHeatPumpCalculationService.CalculateCarnotHeatPump(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateCarnotRefrigerator([FromBody] CarnotRefrigeratorCalculationRequestDto request)
        {
            var response = _carnotRefrigeratorCalculationService.CalculateCarnotRefrigerator(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateCompressibilityMultiplier([FromBody] CompressibilityMultiplierCalculationRequestDto request)
        {
            var response = _compressibilityMultiplierCalculationService.CalculateCompressibilityMultiplier(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateCompressorCalculation([FromBody] CompressorCalculationRequestDto request)
        {
            var response = _compressorCalculationService.CalculateCompressorCalculation(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateConstantPressurePhaseChange([FromBody] ConstantPressurePhaseChangeRequestDto request)
        {
            var response = _constantPressurePhaseChangeService.CalculateConstantPressurePhaseChange(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateConstantVolumePhaseChange([FromBody] ConstantVolumePhaseChangeRequestDto request)
        {
            var response = _constantVolumePhaseChangeService.CalculateConstantVolumePhaseChange(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateDegreeOfDryness([FromBody] DegreeOfDrynessCalculationRequestDto request)
        {
            var response = _degreeOfDrynessCalculationService.CalculateDegreeOfDryness(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateDiffuser([FromBody] DiffuserCalculationRequestDto request)
        {
            var response = _diffuserCalculationService.CalculateDiffuser(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateElectricalWork([FromBody] ElectricalWorkRequestDto request)
        {
            var response = _electricalWorkService.CalculateElectricalWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyBalanceForClosedSystem([FromBody] EntropyBalanceForClosedSystemRequestDto request)
        {
            var response = _entropyBalanceForClosedSystemService.CalculateEntropyBalanceForClosedSystem(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyBalanceForControlVolume([FromBody] EntropyBalanceForControlVolumeRequestDto request)
        {
            var response = _entropyBalanceForControlVolumeService.CalculateEntropyBalanceForControlVolume(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyCalculationForSteadyFlowOpenSystem([FromBody] EntropyCalculationForSteadyFlowOpenSystemRequestDto request)
        {
            var response = _entropyCalculationForSteadyFlowOpenSystemService
                .CalculateEntropyCalculationForSteadyFlowOpenSystem(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyCalculationForUniformFlowBalancedOpenSystem([FromBody] EntropyCalculationForUniformFlowBalancedOpenSystemRequestDto request)
        {
            var response = _entropyCalculationForUniformFlowBalancedOpenSystemService
                .CalculateEntropyCalculationForUniformFlowBalancedOpenSystem(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropy([FromBody] EntropyCalculationRequestDto request)
        {
            var response = _entropyCalculationService.CalculateEntropy(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyChangeOfLiquid([FromBody] EntropyChangeOfLiquidRequestDto request)
        {
            var response = _entropyChangeOfLiquidService.CalculateEntropyChangeOfLiquid(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyChangeOfPerfectGasesApproximate([FromBody] EntropyChangeOfPerfectGasesApproximateRequestDto request)
        {
            var response = _entropyChangeOfPerfectGasesApproximateService
                .CalculateEntropyChangeOfPerfectGasesApproximate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyChangeOfPerfectGasesExact([FromBody] EntropyChangeOfPerfectGasesExactRequestDto request)
        {
            var response = _entropyChangeOfPerfectGasesExactService.CalculateEntropyChangeOfPerfectGasesExact(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyChangeOfPure([FromBody] EntropyChangeOfPureRequestDto request)
        {
            var response = _entropyChangeOfPureService.CalculateEntropyChangeOfPure(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateEntropyChangeOfSolid([FromBody] EntropyChangeOfSolidRequestDto request)
        {
            var response = _entropyChangeOfSolidService.CalculateEntropyChangeOfSolid(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateExergy([FromBody] ExergyCalculationRequestDto request)
        {
            var response = _exergyCalculationService.CalculateExergy(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateFlexibleRodWork([FromBody] FlexibleRodWorkRequestDto request)
        {
            var response = _flexibleRodWorkService.CalculateFlexibleRodWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateFlowCalculationInDuct([FromBody] FlowCalculationInDuctRequestDto request)
        {
            var response = _flowCalculationInDuctService.CalculateFlowCalculationInDuct(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateFlowCalculationInPipe([FromBody] FlowCalculationInPipeRequestDto request)
        {
            var response = _flowCalculationInPipeService.CalculateFlowCalculationInPipe(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateFlowWork([FromBody] FlowWorkRequestDto request)
        {
            var response = _flowWorkService.CalculateFlowWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateGibbsEquation([FromBody] GibbsEquationCalculationRequestDto request)
        {
            var response = _gibbsEquationCalculationService.CalculateGibbsEquationCalculation(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateGravityWork([FromBody] GravityWorkRequestDto request)
        {
            var response = _gravityWorkService.CalculateGravityWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateHeatAndHeatTransfer([FromBody] HeatAndHeatTransferRequestDto request)
        {
            var response = _heatAndHeatTransferService.CalculateHeatAndHeatTransfer(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateHeatEngine([FromBody] HeatEngineCalculationRequestDto request)
        {
            var response = _heatEngineCalculationService.CalculateHeatEngine(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateHeatExchangers([FromBody] HeatExchangersCalculationRequestDto request)
        {
            var response = _heatExchangersCalculationService.CalculateHeatExchangers(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateHeatPumpEfficiency([FromBody] HeatPumpEfficiencyRequestDto request)
        {
            var response = _heatPumpEfficiencyService.CalculateHeatPumpEfficiency(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateIdealGas([FromBody] IdealGasRequestDto request)
        {
            var response = _idealGasService.CalculateIdealGas(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateIrreversibility([FromBody] IrreversibilityCalculationRequestDto request)
        {
            var response = _irreversibilityCalculationService.CalculateIrreversibility(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateIsentropicPhaseChangeOfPerfectGasesApproximate([FromBody] IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto request)
        {
            var response = _isentropicPhaseChangeOfPerfectGasesApproximateService
                .CalculateIsentropicPhaseChangeOfPerfectGasesApproximate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateIsentropicPhaseChangeOfPerfectGasesExact([FromBody] IsentropicPhaseChangeOfPerfectGasesExactRequestDto request)
        {
            var response = _isentropicPhaseChangeOfPerfectGasesExactService
                .CalculateIsentropicPhaseChangeOfPerfectGasesExact(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateIsothermalPhaseChange([FromBody] IsothermalPhaseChangeRequestDto request)
        {
            var response = _isothermalPhaseChangeService.CalculateIsothermalPhaseChange(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateMassFlow([FromBody] MassFlowRequestDto request)
        {
            var response = _massFlowService.CalculateMassFlow(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateMechanicalWork([FromBody] MechanicalWorkRequestDto request)
        {
            var response = _mechanicalWorkService.CalculateMechanicalWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateMinimizeCompressorWork([FromBody] MinimizeCompressorWorkRequestDto request)
        {
            var response = _minimizeCompressorWorkService.CalculateMinimizeCompressorWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateMixingChamber([FromBody] MixingChamberCalculationRequestDto request)
        {
            var response = _mixingChamberCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateNozzle([FromBody] NozzleCalculationRequestDto request)
        {
            var response = _nozzleCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculatePolytropicPhaseChange([FromBody] PolytropicPhaseChangeRequestDto request)
        {
            var response = _polytropicPhaseChangeService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculatePressure([FromBody] PressureCalculationRequestDto request)
        {
            var response = _pressureCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculatePump([FromBody] PumpCalculationRequestDto request)
        {
            var response = _pumpCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateReducedPressureAndTemperature([FromBody] ReducedPressureAndTemperatureRequestDto request)
        {
            var response = _reducedPressureAndTemperatureService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateRefrigerator([FromBody] RefrigeratorCalculationRequestDto request)
        {
            var response = _refrigeratorCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateRefrigeratorEfficiency([FromBody] RefrigeratorEfficiencyRequestDto request)
        {
            var response = _refrigeratorEfficiencyService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateReversibleContinousFlow([FromBody] ReversibleContinousFlowCalculationRequestDto request)
        {
            var response = _reversibleContinousFlowCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateReversibleWork([FromBody] ReversibleWorkCalculationRequestDto request)
        {
            var response = _reversibleWorkCalculationService.CalculateReversibleWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateSpindleWork([FromBody] SpindleWorkRequestDto request)
        {
            var response = _spindleWorkService.CalculateSpindleWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateSpringWork([FromBody] SpringWorkRequestDto request)
        {
            var response = _springWorkService.CalculateSpringWork(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateSteadyFlow([FromBody] SteadyFlowCalculationRequestDto request)
        {
            var response = _steadyFlowCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateStressCalculationOfLiquidSurface([FromBody] StressCalculationOfLiquidSurfaceRequestDto request)
        {
            var response = _stressCalculationOfLiquidSurfaceService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateSurroundWork([FromBody] SurroundWorkCalculationRequestDto request)
        {
            var response = _surroundWorkCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateThrottleValve([FromBody] ThrottleValveCalculationRequestDto request)
        {
            var response = _throttleValveCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateTurbine([FromBody] TurbineCalculationRequestDto request)
        {
            var response = _turbineCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateUsefulWork([FromBody] UsefulWorkCalculationRequestDto request)
        {
            var response = _usefulWorkCalculationService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateVolumetricFlow([FromBody] VolumetricFlowRequestDto request)
        {
            var response = _volumetricFlowService.Calculate(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateWorkConsumingDeviceEfficiency([FromBody] WorkConsumingDeviceEfficiencyRequestDto request)
        {
            var response = _workConsumingDeviceEfficiencyService.CalculateEfficiency(request);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult CalculateWorkProducingDeviceEfficiency([FromBody] WorkProducingDeviceEfficiencyRequestDto request)
        {
            var response = _workProducingDeviceEfficiencyService.CalculateEfficiency(request);
            return Ok(response);
        }
    }
}
