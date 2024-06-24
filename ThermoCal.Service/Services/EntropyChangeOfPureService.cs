using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyChangeOfPureService : IEntropyChangeOfPureService
{
    public Task<CustomResponseDto<EntropyChangeOfPureResponseDto>> CalculateEntropyChangeOfPureAsync(EntropyChangeOfPureRequestDto request)
    {
        var entropyChange = CalculateEntropyChangeOfPure(request);

        var response = new EntropyChangeOfPureResponseDto
        {
            S = entropyChange
        };

        return Task.FromResult(CustomResponseDto<EntropyChangeOfPureResponseDto>.Success(200, response));
    }

    private double CalculateEntropyChangeOfPure(EntropyChangeOfPureRequestDto request)
    {
        double entropyChange = 0;

        double sFirst = request.SFirst;
        double sSecond = request.SSecond;
        double m = request.M;

        if (m != 0)
        {
            entropyChange = m * (sSecond - sFirst);
        }
        else
        {
            entropyChange = sSecond - sFirst;
        }

        return entropyChange;
    }
}