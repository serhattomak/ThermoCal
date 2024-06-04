using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICarnotHeatPumpCalculationService
{
    CarnotHeatPumpCalculationResponseDto CalculateCarnotHeatPump(CarnotHeatPumpCalculationRequestDto request);
}