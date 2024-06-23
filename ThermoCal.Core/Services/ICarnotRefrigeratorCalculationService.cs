using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICarnotRefrigeratorCalculationService
{
    Task<CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>> CalculateCarnotRefrigeratorAsync(CarnotRefrigeratorCalculationRequestDto request);
}