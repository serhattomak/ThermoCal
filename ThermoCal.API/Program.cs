using ThermoCal.Core.Services;
using ThermoCal.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IAccelerationWorkService), typeof(AccelerationWorkService));
builder.Services.AddScoped(typeof(IAdiabaticEfficiencyNozzleService), typeof(AdiabaticEfficiencyNozzleService));
builder.Services.AddScoped(typeof(IAdiabaticEfficiencyOfCompressorService), typeof(AdiabaticEfficiencyOfCompressorService));
builder.Services.AddScoped(typeof(IAdiabaticEfficiencyOfPumpService), typeof(AdiabaticEfficiencyOfPumpService));
builder.Services.AddScoped(typeof(IAdiabaticEfficiencyOfTurbineService), typeof(AdiabaticEfficiencyOfTurbineService));
builder.Services.AddScoped(typeof(IAdiabaticExponentService), typeof(AdiabaticExponentService));
builder.Services.AddScoped(typeof(IAdiabaticPhaseChangeService), typeof(AdiabaticPhaseChangeService));
builder.Services.AddScoped(typeof(ICarnotHeatPumpCalculationService), typeof(CarnotHeatPumpCalculationService));
builder.Services.AddScoped(typeof(ICarnotRefrigeratorCalculationService), typeof(CarnotRefrigeratorCalculationService));
builder.Services.AddScoped(typeof(ICompressibilityMultiplierCalculationService), typeof(CompressibilityMultiplierCalculationService));
builder.Services.AddScoped(typeof(ICompressorCalculationService), typeof(CompressorCalculationService));
builder.Services.AddScoped(typeof(IConstantPressurePhaseChangeService), typeof(ConstantPressurePhaseChangeService));
builder.Services.AddScoped(typeof(IConstantVolumePhaseChangeService), typeof(ConstantVolumePhaseChangeService));
builder.Services.AddScoped(typeof(IDegreeOfDrynessCalculationService), typeof(DegreeOfDrynessCalculationService));
builder.Services.AddScoped(typeof(IDiffuserCalculationService), typeof(DiffuserCalculationService));
builder.Services.AddScoped(typeof(IElectricalWorkService), typeof(ElectricalWorkService));
builder.Services.AddScoped(typeof(IEntropyBalanceForClosedSystemService), typeof(EntropyBalanceForClosedSystemService));
builder.Services.AddScoped(typeof(IEntropyBalanceForControlVolumeService), typeof(EntropyBalanceForControlVolumeService));
builder.Services.AddScoped(typeof(IEntropyCalculationForSteadyFlowOpenSystemService), typeof(EntropyCalculationForSteadyFlowOpenSystemService));
builder.Services.AddScoped(typeof(IEntropyCalculationForUniformFlowBalancedOpenSystemService), typeof(EntropyCalculationForUniformFlowBalancedOpenSystemService));
builder.Services.AddScoped(typeof(IEntropyCalculationService), typeof(EntropyCalculationService));
builder.Services.AddScoped(typeof(IEntropyChangeOfLiquidService), typeof(EntropyChangeOfLiquidService));
builder.Services.AddScoped(typeof(IEntropyChangeOfPerfectGasesApproximateService), typeof(EntropyChangeOfPerfectGasesApproximateService));
builder.Services.AddScoped(typeof(IEntropyChangeOfPerfectGasesExactService), typeof(EntropyChangeOfPerfectGasesExactService));
builder.Services.AddScoped(typeof(IEntropyChangeOfPureService), typeof(EntropyChangeOfPureService));
builder.Services.AddScoped(typeof(IEntropyChangeOfSolidService), typeof(EntropyChangeOfSolidService));
builder.Services.AddScoped(typeof(IFlexibleRodWorkService), typeof(FlexibleRodWorkService));
builder.Services.AddScoped(typeof(IExergyCalculationService), typeof(ExergyCalculationService));
builder.Services.AddScoped(typeof(IFlowCalculationInDuctService), typeof(FlowCalculationInDuctService));
builder.Services.AddScoped(typeof(IFlowCalculationInPipeService), typeof(FlowCalculationInPipeService));
builder.Services.AddScoped(typeof(IFlowWorkService), typeof(FlowWorkService));
builder.Services.AddScoped(typeof(IGravityWorkService), typeof(GravityWorkService));
builder.Services.AddScoped(typeof(IHeatAndHeatTransferService), typeof(HeatAndHeatTransferService));
builder.Services.AddScoped(typeof(IHeatEngineCalculationService), typeof(HeatEngineCalculationService));
builder.Services.AddScoped(typeof(IHeatExchangersCalculationService), typeof(HeatExchangersCalculationService));
builder.Services.AddScoped(typeof(IHeatPumpEfficiencyService), typeof(HeatPumpEfficiencyService));
builder.Services.AddScoped(typeof(IIdealGasService), typeof(IdealGasService));
builder.Services.AddScoped(typeof(IIrreversibilityCalculationService), typeof(IrreversibilityCalculationService));
builder.Services.AddScoped(typeof(IIsentropicPhaseChangeOfPerfectGasesApproximateService), typeof(IsentropicPhaseChangeOfPerfectGasesApproximateService));
builder.Services.AddScoped(typeof(IIsentropicPhaseChangeOfPerfectGasesExactService), typeof(IsentropicPhaseChangeOfPerfectGasesExactService));
builder.Services.AddScoped(typeof(IIsothermalPhaseChangeService), typeof(IsothermalPhaseChangeService));
builder.Services.AddScoped(typeof(IMassFlowService), typeof(MassFlowService));
builder.Services.AddScoped(typeof(IMechanicalWorkService), typeof(MechanicalWorkService));
builder.Services.AddScoped(typeof(IMinimizeCompressorWorkService), typeof(MinimizeCompressorWorkService));
builder.Services.AddScoped(typeof(IMixingChamberCalculationService), typeof(MixingChamberCalculationService));
builder.Services.AddScoped(typeof(INozzleCalculationService), typeof(NozzleCalculationService));
builder.Services.AddScoped(typeof(IPolytropicPhaseChangeService), typeof(PolytropicPhaseChangeService));
builder.Services.AddScoped(typeof(IPressureCalculationService), typeof(PressureCalculationService));
builder.Services.AddScoped(typeof(IPumpCalculationService), typeof(PumpCalculationService));
builder.Services.AddScoped(typeof(IReducedPressureAndTemperatureService), typeof(ReducedPressureAndTemperatureService));
builder.Services.AddScoped(typeof(IRefrigeratorCalculationService), typeof(RefrigeratorCalculationService));
builder.Services.AddScoped(typeof(IRefrigeratorEfficiencyService), typeof(RefrigeratorEfficiencyService));
builder.Services.AddScoped(typeof(IReversibleContinuousFlowCalculationService), typeof(ReversibleContinuousFlowCalculationService));
builder.Services.AddScoped(typeof(IReversibleWorkCalculationService), typeof(ReversibleWorkCalculationService));
builder.Services.AddScoped(typeof(ISpindleWorkService), typeof(SpindleWorkService));
builder.Services.AddScoped(typeof(ISpringWorkService), typeof(SpringWorkService));
builder.Services.AddScoped(typeof(ISteadyFlowCalculationService), typeof(SteadyFlowCalculationService));
builder.Services.AddScoped(typeof(IStressCalculationOfLiquidSurfaceService), typeof(StressCalculationOfLiquidSurfaceService));
builder.Services.AddScoped(typeof(IThrottleValveCalculationService), typeof(ThrottleValveCalculationService));
builder.Services.AddScoped(typeof(ITurbineCalculationService), typeof(TurbineCalculationService));
builder.Services.AddScoped(typeof(IUsefulWorkCalculationService), typeof(UsefulWorkCalculationService));
builder.Services.AddScoped(typeof(IVolumetricFlowService), typeof(VolumetricFlowService));
builder.Services.AddScoped(typeof(IWorkConsumingDeviceEfficiencyService), typeof(WorkConsumingDeviceEfficiencyService));
builder.Services.AddScoped(typeof(IWorkProducingDeviceEfficiencyService), typeof(WorkProducingDeviceEfficiencyService));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
