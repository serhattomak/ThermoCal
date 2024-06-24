using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class CarnotRefrigeratorCalculationService: ICarnotRefrigeratorCalculationService
{
    public Task<CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>> CalculateCarnotRefrigeratorAsync(CarnotRefrigeratorCalculationRequestDto request)
    {
        var copRefRev = CalculateCarnotRefrigerator(request);

        var responseDto = new CarnotRefrigeratorCalculationResponseDto
        {
            Th = request.Th,
            Tl = request.Tl,
            COPRefRev = copRefRev
        };

        return Task.FromResult(CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>.Success(200, responseDto));
    }

    private double CalculateCarnotRefrigerator(CarnotRefrigeratorCalculationRequestDto request)
    {
        double tHigh = request.Th;
        double tLow = request.Tl;
        double efficiency = tLow/(tHigh-tLow);

        return efficiency;
    }
}