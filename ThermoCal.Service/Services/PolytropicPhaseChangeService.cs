using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class PolytropicPhaseChangeService: IPolytropicPhaseChangeService
{
    public Task<CustomResponseDto<PolytropicPhaseChangeResponseDto>> CalculatePolytropicPhaseChangeAsync(PolytropicPhaseChangeRequestDto request)
    {
        var response = CalculatePolytropicPhaseChange(request);

        return Task.FromResult(CustomResponseDto<PolytropicPhaseChangeResponseDto>.Success(200, response));
    }

    private PolytropicPhaseChangeResponseDto CalculatePolytropicPhaseChange(PolytropicPhaseChangeRequestDto request)
    {
        double w = request.W;
        double n = request.N;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;
        double vFirst = request.VFirst;
        double vSecond = request.VSecond;

        if (n-1!=0)
        {
            w=(pFirst*vFirst-pSecond*vSecond)/(n-1);
        }

        return new PolytropicPhaseChangeResponseDto
        {
            W = w,
            N = n,
            PFirst = pFirst,
            PSecond = pSecond,
            VFirst = vFirst,
            VSecond = vSecond,
        };
    }
}