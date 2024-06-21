using ThermoCal.Core.Services;
using ThermoCal.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAccelerationWorkService, AccelerationWorkService>();
builder.Services.AddScoped<IAdiabaticEfficiencyNozzleService, AdiabaticEfficiencyNozzleService>();
builder.Services.AddScoped<IAdiabaticEfficiencyOfCompressorService, AdiabaticEfficiencyOfCompressorService>();
builder.Services.AddScoped<IAdiabaticEfficiencyOfPumpService, AdiabaticEfficiencyOfPumpService>();
builder.Services.AddScoped<IAdiabaticEfficiencyOfTurbineService, AdiabaticEfficiencyOfTurbineService>();
builder.Services.AddScoped<IAdiabaticExponentService, AdiabaticExponentService>();
builder.Services.AddScoped<IAdiabaticPhaseChangeService, AdiabaticPhaseChangeService>();
builder.Services.AddScoped<ICarnotHeatPumpCalculationService, CarnotHeatPumpCalculationService>();
builder.Services.AddScoped<ICarnotRefrigeratorCalculationService, CarnotRefrigeratorCalculationService>();
builder.Services.AddScoped<ICompressibilityMultiplierCalculationService, CompressibilityMultiplierCalculationService>();
builder.Services.AddScoped<ICompressorCalculationService, CompressorCalculationService>();
builder.Services.AddScoped<IConstantPressurePhaseChangeService, ConstantPressurePhaseChangeService>();
builder.Services.AddScoped<IConstantVolumePhaseChangeService, ConstantVolumePhaseChangeService>();
builder.Services.AddScoped<IDegreeOfDrynessCalculationService, DegreeOfDrynessCalculationService>();
builder.Services.AddScoped<IDiffuserCalculationService, DiffuserCalculationService>();
builder.Services.AddScoped<IElectricalWorkService, ElectricalWorkService>();
builder.Services.AddScoped<IEntropyBalanceForClosedSystemService, EntropyBalanceForClosedSystemService>();
builder.Services.AddScoped<IEntropyBalanceForControlVolumeService, EntropyBalanceForControlVolumeService>();
builder.Services.AddScoped<IEntropyCalculationForSteadyFlowOpenSystemService, EntropyCalculationForSteadyFlowOpenSystemService>();
builder.Services.AddScoped<IEntropyCalculationForUniformFlowBalancedOpenSystemService, EntropyCalculationForUniformFlowBalancedOpenSystemService>();
builder.Services.AddScoped<IEntropyCalculationService, EntropyCalculationService>();
builder.Services.AddScoped<IEntropyChangeOfLiquidService, EntropyChangeOfLiquidService>();
builder.Services.AddScoped<IEntropyChangeOfPerfectGasesApproximateService, EntropyChangeOfPerfectGasesApproximateService>();
builder.Services.AddScoped<IEntropyChangeOfPerfectGasesExactService, EntropyChangeOfPerfectGasesExactService>();
builder.Services.AddScoped<IEntropyChangeOfPureService, EntropyChangeOfPureService>();
builder.Services.AddScoped<IEntropyChangeOfSolidService, EntropyChangeOfSolidService>();
builder.Services.AddScoped<IFlexibleRodWorkService, FlexibleRodWorkService>();
builder.Services.AddScoped<IFlowCalculationInDuctService, FlowCalculationInDuctService>();
builder.Services.AddScoped<IFlowCalculationInPipeService, FlowCalculationInPipeService>();
builder.Services.AddScoped<IFlowWorkService, FlowWorkService>();
builder.Services.AddScoped<IGibbsEquationCalculationService, GibbsEquationCalculationService>();
builder.Services.AddScoped<IGravityWorkService, GravityWorkService>();
builder.Services.AddScoped<IHeatAndHeatTransferService, HeatAndHeatTransferService>();
builder.Services.AddScoped<IHeatEngineCalculationService, HeatEngineCalculationService>();
builder.Services.AddScoped<IHeatExchangersCalculationService, HeatExchangersCalculationService>();
builder.Services.AddScoped<IHeatPumpEfficiencyService, HeatPumpEfficiencyService>();
builder.Services.AddScoped<IIdealGasService, IdealGasService>();
builder.Services.AddScoped<IIrreversibilityCalculationService, IrreversibilityCalculationService>();
builder.Services.AddScoped<IIsentropicPhaseChangeOfPerfectGasesApproximateService, IsentropicPhaseChangeOfPerfectGasesApproximateService>();
builder.Services.AddScoped<IIsentropicPhaseChangeOfPerfectGasesExactService, IsentropicPhaseChangeOfPerfectGasesExactService>();
builder.Services.AddScoped<IIsothermalPhaseChangeService, IsothermalPhaseChangeService>();
builder.Services.AddScoped<IMassFlowService, MassFlowService>();
builder.Services.AddScoped<IMinimizeCompressorWorkService, MinimizeCompressorWorkService>();
builder.Services.AddScoped<IMixingChamberCalculationService, MixingChamberCalculationService>();
builder.Services.AddScoped<INozzleCalculationService, NozzleCalculationService>();
builder.Services.AddScoped<IPolytropicPhaseChangeService, PolytropicPhaseChangeService>();
builder.Services.AddScoped<IPressureCalculationService, PressureCalculationService>();
builder.Services.AddScoped<IPumpCalculationService, PumpCalculationService>();
builder.Services.AddScoped<IReducedPressureAndTemperatureService, ReducedPressureAndTemperatureService>();
builder.Services.AddScoped<IRefrigeratorCalculationService, RefrigeratorCalculationService>();
builder.Services.AddScoped<IRefrigeratorEfficiencyService, RefrigeratorEfficiencyService>();
builder.Services.AddScoped<IReversibleContinuousFlowCalculationService, ReversibleContinuousFlowCalculationService>();
builder.Services.AddScoped<IReversibleWorkCalculationService, ReversibleWorkCalculationService>();
builder.Services.AddScoped<ISpindleWorkService, SpindleWorkService>();
builder.Services.AddScoped<ISpringWorkService, SpringWorkService>();
builder.Services.AddScoped<ISteadyFlowCalculationService, SteadyFlowCalculationService>();
builder.Services.AddScoped<IStressCalculationOfLiquidSurfaceService, StressCalculationOfLiquidSurfaceService>();
builder.Services.AddScoped<ISurroundWorkCalculationService, SurroundWorkCalculationService>();
builder.Services.AddScoped<IThrottleValveCalculationService, ThrottleValveCalculationService>();
builder.Services.AddScoped<ITurbineCalculationService, TurbineCalculationService>();
builder.Services.AddScoped<IUsefulWorkCalculationService, UsefulWorkCalculationService>();
builder.Services.AddScoped<IVolumetricFlowService, VolumetricFlowService>();
builder.Services.AddScoped<IWorkConsumingDeviceEfficiencyService, WorkConsumingDeviceEfficiencyService>();
builder.Services.AddScoped<IWorkProducingDeviceEfficiencyService, WorkProducingDeviceEfficiencyService>();

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
