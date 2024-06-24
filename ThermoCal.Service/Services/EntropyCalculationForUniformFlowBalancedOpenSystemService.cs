using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyCalculationForUniformFlowBalancedOpenSystemService: IEntropyCalculationForUniformFlowBalancedOpenSystemService
{
    public Task<CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>> CalculateEntropyCalculationForUniformFlowBalancedOpenSystemAsync(EntropyCalculationForUniformFlowBalancedOpenSystemRequestDto request)
    {
        var entropy = CalculateEntropyCalculationForUniformFlowBalancedOpenSystem(request);

        var response = new EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto
        {
            SGen = entropy
        };

        return Task.FromResult(CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>.Success(200, response));
    }

    private double CalculateEntropyCalculationForUniformFlowBalancedOpenSystem(EntropyCalculationForUniformFlowBalancedOpenSystemRequestDto request)
    {
        double entropy = 0;
        double tR = request.Tr;
        double qR = request.Qr;
        double mDotIn = request.MDotIn;
        double mDotOut = request.MDotOut;
        double sI = request.SIn;
        double sO = request.SOut;
        double sFirst = request.SCVFirst;
        double sSecond = request.SCVSecond;
        double sGen = request.SGen;

        sGen = (mDotOut * sO) - (mDotIn*sI) + (sSecond-sFirst) + (qR / tR);

        return sGen;
    }
}