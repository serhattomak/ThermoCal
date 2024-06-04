using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICarnotRefrigeratorCalculationService
{
    CarnotRefrigeratorCalculationResponseDto CalculateCarnotRefrigerator(CarnotRefrigeratorCalculationRequestDto request);
}