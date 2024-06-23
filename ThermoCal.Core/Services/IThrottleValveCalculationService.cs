using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IThrottleValveCalculationService
{
    Task<CustomResponseDto<ThrottleValveCalculationResponseDto>> CalculateThrottleValveAsync(ThrottleValveCalculationRequestDto request);
}