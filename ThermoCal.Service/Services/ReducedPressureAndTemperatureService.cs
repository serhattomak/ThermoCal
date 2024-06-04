using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ReducedPressureAndTemperatureService: IReducedPressureAndTemperatureService
{
    public ReducedPressureAndTemperatureResponseDto Calculate(ReducedPressureAndTemperatureRequestDto request)
    {
        var result = new ReducedPressureAndTemperatureResponseDto();
        return result;
    }
}