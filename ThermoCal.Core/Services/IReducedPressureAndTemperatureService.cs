using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReducedPressureAndTemperatureService
{
    ReducedPressureAndTemperatureResponseDto Calculate(ReducedPressureAndTemperatureRequestDto request);
}