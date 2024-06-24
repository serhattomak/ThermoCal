using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyBalanceForControlVolumeService: IEntropyBalanceForControlVolumeService
{
    public Task<CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>> CalculateEntropyBalanceForControlVolumeAsync(EntropyBalanceForControlVolumeRequestDto request)
    {
        var entropy = CalculateEntropyBalanceForControlVolume(request);

        var response = new EntropyBalanceForControlVolumeResponseDto
        {
            S = entropy
        };

        return Task.FromResult(CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>.Success(200, response));
    }

    private double CalculateEntropyBalanceForControlVolume(EntropyBalanceForControlVolumeRequestDto request)
    {
        double entropy = 0;
        double tK = request.Tk;
        double mDotIn = request.MDotIn;
        double mDotOut = request.MDotOut;
        double qK = request.QkDot;
        double sI = request.SIn;
        double sO = request.SOut;
        double sGen = request.SGen;

        entropy = (qK/tK) + (mDotIn*sI)-(mDotOut*sO)+sGen;

        return entropy;
    }
}