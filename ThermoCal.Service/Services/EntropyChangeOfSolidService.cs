using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyChangeOfSolidService : IEntropyChangeOfSolidService
{
    public Task<CustomResponseDto<EntropyChangeOfSolidResponseDto>> CalculateEntropyChangeOfSolidAsync(EntropyChangeOfSolidRequestDto request)
    {
        var entropyChange = CalculateEntropyChangeOfSolid(request);

        var response = new EntropyChangeOfSolidResponseDto
        {
            S = entropyChange
        };

        return Task.FromResult(CustomResponseDto<EntropyChangeOfSolidResponseDto>.Success(200, response));
    }

    private double CalculateEntropyChangeOfSolid(EntropyChangeOfSolidRequestDto request)
    {
        double entropyChange = 0;

        double tFirst = request.TFirst;
        double tSecond = request.TSecond;
        double sFirst = request.SFirst;
        double sSecond = request.SSecond;
        double cAverage = request.CAverage;

        entropyChange = cAverage * Math.Log(tSecond / tFirst);

        return entropyChange;
    }
}