using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatEngineCalculationService
{
    Task<CustomResponseDto<HeatEngineCalculationResponseDto>> CalculateHeatEngineAsync(HeatEngineCalculationRequestDto request);
}