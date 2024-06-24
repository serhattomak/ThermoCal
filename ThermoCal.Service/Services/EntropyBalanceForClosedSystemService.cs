using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyBalanceForClosedSystemService: IEntropyBalanceForClosedSystemService
{
    public Task<CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>> CalculateEntropyBalanceForClosedSystemAsync(EntropyBalanceForClosedSystemRequestDto request)
    {
        var entropy = CalculateEntropyBalanceForClosedSystem(request);

        var response = new EntropyBalanceForClosedSystemResponseDto
        {
            S = entropy
        };

        return Task.FromResult(CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>.Success(200, response));
    }

    private double CalculateEntropyBalanceForClosedSystem(EntropyBalanceForClosedSystemRequestDto request)
    {
        double entropy = 0;
        double tR = request.TFirst;
        double qR = request.TSecond;
        double s1 = request.SFirst;
        double s2 = request.SSecond;

        entropy = (s2 - s1) - (qR / tR);

        return entropy;
    }
}