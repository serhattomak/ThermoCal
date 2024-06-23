using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IRefrigeratorCalculationService
{
    Task<CustomResponseDto<RefrigeratorCalculationResponseDto>> CalculateRefrigeratorAsync(RefrigeratorCalculationRequestDto request);
}