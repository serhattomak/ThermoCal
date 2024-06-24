using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class IsentropicPhaseChangeOfPerfectGasesExactService : IIsentropicPhaseChangeOfPerfectGasesExactService
{
    public Task<CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>> CalculateIsentropicPhaseChangeOfPerfectGasesExactAsync(IsentropicPhaseChangeOfPerfectGasesExactRequestDto request)
    {
        var response = CalculateIsentropicPhaseChangeOfPerfectGasesExact(request);

        return Task.FromResult(CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>.Success(200, response));
    }

    private IsentropicPhaseChangeOfPerfectGasesExactResponseDto CalculateIsentropicPhaseChangeOfPerfectGasesExact(
        IsentropicPhaseChangeOfPerfectGasesExactRequestDto request)
    {
        double T = request.T;
        double pR = request.Pr;
        double vSpecificR = request.VSpecificR;
        double r = request.R;
        double s = request.S;

        pR = Math.Exp(s / r);

        vSpecificR = T / pR;


        return new IsentropicPhaseChangeOfPerfectGasesExactResponseDto
        {
            Pr = pR,
            VSpecificR = vSpecificR
        };
    }

}