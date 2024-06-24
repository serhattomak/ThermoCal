using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class CarnotHeatPumpCalculationService: ICarnotHeatPumpCalculationService
{
    public Task<CustomResponseDto<CarnotHeatPumpCalculationResponseDto>> CalculateCarnotHeatPumpAsync(CarnotHeatPumpCalculationRequestDto request)
    {
        var copHeatRev = CalculateCarnotHeatPump(request);

        var responseDto = new CarnotHeatPumpCalculationResponseDto
        {
            Th = request.Th,
            Tl = request.Tl,
            COPHeatRev = copHeatRev
        };

        return Task.FromResult(CustomResponseDto<CarnotHeatPumpCalculationResponseDto>.Success(200, responseDto));
    }

    private double CalculateCarnotHeatPump(CarnotHeatPumpCalculationRequestDto request)
    {
        double tHigh = request.Th;
        double tLow = request.Tl;
        double efficiency = 1/(1-(tLow/tHigh));

        return efficiency;
    }
}