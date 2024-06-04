using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class PumpCalculationService: IPumpCalculationService
{
    public PumpCalculationResponseDto Calculate(PumpCalculationRequestDto request)
    {
        var result = new PumpCalculationResponseDto();
        return result;
    }
}