using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyCalculationService: IEntropyCalculationService
{
    public Task<CustomResponseDto<EntropyCalculationResponseDto>> CalculateEntropyAsync(EntropyCalculationRequestDto request)
    {
        var entropy = CalculateEntropy(request);

        var response = new EntropyCalculationResponseDto
        {
            S = entropy
        };

        return Task.FromResult(CustomResponseDto<EntropyCalculationResponseDto>.Success(200, response));
    }

    private double CalculateEntropy(EntropyCalculationRequestDto request)
    {
        double entropy = 0;
        double tH = request.Th;
        double tL = request.Tl;
        double qH = request.Qh;
        double qL = request.Ql;

        entropy = (qH / tH) - (qL / tL);

        return entropy;
    }
}