using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AdiabaticPhaseChangeService: IAdiabaticPhaseChangeService
{
    public Task<CustomResponseDto<AdiabaticPhaseChangeResponseDto>> CalculateAdiabaticPhaseChangeAsync(AdiabaticPhaseChangeRequestDto request)
    {
        var work = CalculateAdiabaticPhaseChange(request);

        var responseDto = new AdiabaticPhaseChangeResponseDto
        {
            W = work,
            K = request.K,
            PFirst = request.PFirst,
            PSecond = request.PSecond,
            VFirst = request.VFirst,
            VSecond = request.VSecond,
        };

        return Task.FromResult(CustomResponseDto<AdiabaticPhaseChangeResponseDto>.Success(200, responseDto));
    }

    private double CalculateAdiabaticPhaseChange(AdiabaticPhaseChangeRequestDto request)
    {
        double w = request.W;
        double k = request.K;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;
        double vFirst = request.VFirst;
        double vSecond = request.VSecond;

        if (k-1!=0)
        {
             w=(pFirst*vFirst-pSecond*vSecond)/(k-1);
        }

        return w;
    }
}