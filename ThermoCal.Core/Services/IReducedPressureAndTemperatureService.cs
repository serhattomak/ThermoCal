using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReducedPressureAndTemperatureService
{
    Task<CustomResponseDto<ReducedPressureAndTemperatureResponseDto>> CalculateReducedPressureAndTemperatureAsync(ReducedPressureAndTemperatureRequestDto request);
}