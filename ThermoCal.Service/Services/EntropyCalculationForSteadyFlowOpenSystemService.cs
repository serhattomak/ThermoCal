using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyCalculationForSteadyFlowOpenSystemService: IEntropyCalculationForSteadyFlowOpenSystemService
{
    public Task<CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>> CalculateEntropyCalculationForSteadyFlowOpenSystemAsync(EntropyCalculationForSteadyFlowOpenSystemRequestDto request)
    {
        var entropy = CalculateEntropyCalculationForSteadyFlowOpenSystem(request);

        var response = new EntropyCalculationForSteadyFlowOpenSystemResponseDto
        {
            SGenDot = entropy
        };

        return Task.FromResult(CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>.Success(200, response));
    }

    private double CalculateEntropyCalculationForSteadyFlowOpenSystem(EntropyCalculationForSteadyFlowOpenSystemRequestDto request)
    {
        double entropy = 0;
        double tR = request.Tr;
        double mDotIn = request.MInDot;
        double mDotOut = request.MOutDot;
        double qR = request.QrDot;
        double sI = request.SIn;
        double sO = request.SOut;
        double sGenDot = request.SGenDot;

        sGenDot = (mDotOut * sO) - (mDotIn*sI)+ (qR / tR);

        return sGenDot;
    }
}