using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class IsentropicPhaseChangeOfPerfectGasesApproximateService : IIsentropicPhaseChangeOfPerfectGasesApproximateService
{
    public Task<CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>> CalculateIsentropicPhaseChangeOfPerfectGasesApproximateAsync(IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto request)
    {
        var response = CalculateIsentropicPhaseChangeOfPerfectGasesApproximate(request);

        return Task.FromResult(CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>.Success(200, response));
    }

    private IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto CalculateIsentropicPhaseChangeOfPerfectGasesApproximate(IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto request)
    {
        double k = request.K;
        double TFirst = request.TFirst;
        double TSecond = request.TSecond;
        double PFirst = request.PFirst;
        double PSecond = request.PSecond;
        double vSpecificFirst = request.VSpecificFirst;
        double vSpecificSecond = request.VSpecificSecond;

        if (TFirst == 0 && (TSecond != 0 && vSpecificFirst != 0 && vSpecificSecond != 0))
        {
            TFirst=(TSecond)/(Math.Pow((PSecond/PFirst),((k-1)/k)));
        }

        if (TSecond == 0 && (TFirst != 0 && vSpecificFirst != 0 && vSpecificSecond != 0))
        {
            TSecond=(TFirst)*(Math.Pow((PSecond/PFirst),((k-1)/k)));
        }

        if (PFirst == 0 && (PSecond != 0 && vSpecificFirst != 0 && vSpecificSecond != 0))
        {
            PFirst=(PSecond)/(Math.Pow((TSecond/TFirst),k/(k-1)));
        }

        if (PSecond == 0 && (PFirst != 0 && vSpecificFirst != 0 && vSpecificSecond != 0))
        {
            PSecond=(PFirst)*(Math.Pow((TSecond/TFirst),k/(k-1)));
        }

        if (vSpecificFirst == 0 && (vSpecificSecond != 0 && TFirst != 0 && TSecond != 0))
        {
            vSpecificFirst=(Math.Pow((TSecond/TFirst),1/(k-1)))*vSpecificSecond;
        }

        if (vSpecificSecond == 0 && (vSpecificFirst != 0 && TFirst != 0 && TSecond != 0))
        {
            vSpecificSecond=(Math.Pow((TSecond/TFirst),1/(k-1)))*vSpecificFirst;
        }

        return new IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto
        {
            K = k,
            TFirst = TFirst,
            TSecond = TSecond,
            PFirst = PFirst,
            PSecond = PSecond,
            VSpecificFirst = vSpecificFirst,
            VSpecificSecond = vSpecificSecond
        };
    }
}