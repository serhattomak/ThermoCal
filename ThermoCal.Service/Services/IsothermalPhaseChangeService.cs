using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class IsothermalPhaseChangeService: IIsothermalPhaseChangeService
{
    public Task<CustomResponseDto<IsothermalPhaseChangeResponseDto>> CalculateIsothermalPhaseChangeAsync(IsothermalPhaseChangeRequestDto request)
    {
        var response = CalculateIsothermalPhaseChange(request);

        return Task.FromResult(CustomResponseDto<IsothermalPhaseChangeResponseDto>.Success(200, response));
    }

    private IsothermalPhaseChangeResponseDto CalculateIsothermalPhaseChange(IsothermalPhaseChangeRequestDto request)
    {
        double q = 0;
        double w = 0;
        double m = request.M;
        double r = request.R;
        double t = request.T;
        double c = request.C;
        double vFirst = request.VFirst;
        double vSecond = request.VSecond;

        if (c==0)
        {
            c=m*r*t;
        }
        w=c*Math.Log(vSecond/vFirst);
        q = w;

        return new IsothermalPhaseChangeResponseDto
        {
            Q = q,
            W = w,
            M = m,
            R = r,
            T = t,
            C = c,
            VFirst = vFirst,
            VSecond = vSecond
        };
    }
}