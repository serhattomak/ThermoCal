using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IThrottleValveCalculationService
{
    ThrottleValveCalculationResponseDto Calculate(ThrottleValveCalculationRequestDto request);
}