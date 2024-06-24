using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyChangeOfLiquidService: IEntropyChangeOfLiquidService
{
    public Task<CustomResponseDto<EntropyChangeOfLiquidResponseDto>> CalculateEntropyChangeOfLiquidAsync(EntropyChangeOfLiquidRequestDto request)
    {
        var entropyChange=CalculateEntropyChangeOfLiquid(request);

        var response = new EntropyChangeOfLiquidResponseDto
        {
            S = entropyChange
        };

        return Task.FromResult(CustomResponseDto<EntropyChangeOfLiquidResponseDto>.Success(200, response));
    }

    private double CalculateEntropyChangeOfLiquid(EntropyChangeOfLiquidRequestDto request)
    {
        double entropyChange = 0;

        double tFirst=request.TFirst;
        double tSecond=request.TSecond;
        double sFirst=request.SFirst;
        double sSecond=request.SSecond;
        double cAverage=request.CAverage;

        entropyChange = cAverage * Math.Log(tSecond / tFirst);

        return entropyChange;
    }
}