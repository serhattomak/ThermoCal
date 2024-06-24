using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyChangeOfPerfectGasesExactService : IEntropyChangeOfPerfectGasesExactService
{
    public Task<CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>> CalculateEntropyChangeOfPerfectGasesExactAsync(EntropyChangeOfPerfectGasesExactRequestDto request)
    {
        var entropyChange = CalculateEntropyChangeOfPerfectGasesExact(request);

        var response = new EntropyChangeOfPerfectGasesExactResponseDto
        {
            S = entropyChange
        };

        return Task.FromResult(CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>.Success(200, response));
    }

    private double CalculateEntropyChangeOfPerfectGasesExact(EntropyChangeOfPerfectGasesExactRequestDto request)
    {
        double entropyChange = 0;

        double r = request.R;
        double rUOver = request.RuOver;
        double sZeroFirst = request.SZeroFirst;
        double sZeroSecond = request.SZeroSecond;
        double sZeroFirstOver = request.SZeroFirstOver;
        double sZeroSecondOver = request.SZeroSecondOver;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;

        if (r != 0)
        {
            entropyChange = sZeroSecond - sZeroFirst - (r * Math.Log(pSecond / pFirst));
        }
        else if (rUOver != 0)
        {
            entropyChange = sZeroSecondOver - sZeroFirstOver - (rUOver * Math.Log(pSecond / pFirst));
        }

        return entropyChange;
    }
}