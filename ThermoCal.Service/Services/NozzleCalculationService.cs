using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class NozzleCalculationService: INozzleCalculationService
{
    public NozzleCalculationResponseDto Calculate(NozzleCalculationRequestDto request)
    {
        var result = new NozzleCalculationResponseDto();
        return result;
    }
}