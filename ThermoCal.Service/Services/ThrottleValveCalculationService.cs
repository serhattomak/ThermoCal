using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ThrottleValveCalculationService : IThrottleValveCalculationService
{
    public Task<CustomResponseDto<ThrottleValveCalculationResponseDto>> CalculateThrottleValveAsync(ThrottleValveCalculationRequestDto request)
    {
        var response = CalculateThrottleValve(request);

        return Task.FromResult(CustomResponseDto<ThrottleValveCalculationResponseDto>.Success(200, response));
    }

    private ThrottleValveCalculationResponseDto CalculateThrottleValve(ThrottleValveCalculationRequestDto request)
    {
        double uFirst = request.UFirst;
        double uSecond = request.USecond;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;
        double vSpecificFirst = request.VSpecificFirst;
        double vSpecificSecond = request.VSpecificSecond;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;

        hFirst = hSecond;

        uFirst = (uSecond + (pSecond * vSpecificSecond)) / (pFirst * vSpecificFirst);

        return new ThrottleValveCalculationResponseDto
        {
            UFirst = uFirst,
            USecond = uSecond,
            PFirst = pFirst,
            PSecond = pSecond,
            VSpecificFirst = vSpecificFirst,
            VSpecificSecond = vSpecificSecond,
            HFirst = hFirst,
            HSecond = hSecond
        };
    }
}