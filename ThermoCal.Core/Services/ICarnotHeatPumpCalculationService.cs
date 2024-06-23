using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICarnotHeatPumpCalculationService
{
    Task<CustomResponseDto<CarnotHeatPumpCalculationResponseDto>> CalculateCarnotHeatPumpAsync(CarnotHeatPumpCalculationRequestDto request);
}