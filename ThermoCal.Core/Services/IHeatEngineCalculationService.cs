using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatEngineCalculationService
{
    HeatEngineCalculationResponseDto CalculateHeatEngine(HeatEngineCalculationRequestDto request);
}