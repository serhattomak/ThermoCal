using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ITurbineCalculationService
{
    Task<CustomResponseDto<TurbineCalculationResponseDto>> CalculateTurbineAsync(TurbineCalculationRequestDto request);
}