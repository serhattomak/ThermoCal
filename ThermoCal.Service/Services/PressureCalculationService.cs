using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class PressureCalculationService: IPressureCalculationService
{
    public PressureCalculationResponseDto Calculate(PressureCalculationRequestDto request)
    {
        var result = new PressureCalculationResponseDto();
        return result;
    }
}