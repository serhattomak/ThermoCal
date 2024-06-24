using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ConstantPressurePhaseChangeService : IConstantPressurePhaseChangeService
{
    public Task<CustomResponseDto<ConstantPressurePhaseChangeResponseDto>> CalculateConstantPressurePhaseChangeAsync(ConstantPressurePhaseChangeRequestDto request)
    {
        var Q = CalculateQ(request);

        var responseDto = new ConstantPressurePhaseChangeResponseDto
        {
            Q = Q,
            M = request.M,
            Cp = request.Cp,
            R = request.R,
            TFirst = request.TFirst,
            TSecond = request.TSecond,
            P = request.P,
            VFirst = request.VFirst,
            VSecond = request.VSecond
        };

        return Task.FromResult(CustomResponseDto<ConstantPressurePhaseChangeResponseDto>.Success(200, responseDto));
    }

    private double CalculateQ(ConstantPressurePhaseChangeRequestDto request)
    {
        double Q = 0;
        double m = request.M;
        double cP = request.Cp;
        double cV = request.Cv;
        double R = request.R;
        double T1 = request.TFirst;
        double T2 = request.TSecond;
        double P = request.P;
        double V1 = request.VFirst;
        double V2 = request.VSecond;

        if (cP==0)
        {
            Q= m * cV * (T2 - T1)+P*(V2-V1);
        }

        Q = m * cP * (T2 - T1);

        return Q;
    }
}