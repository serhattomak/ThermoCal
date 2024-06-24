using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ReversibleWorkCalculationService: IReversibleWorkCalculationService
{
    public Task<CustomResponseDto<ReversibleWorkCalculationResponseDto>> CalculateReversibleWorkAsync(ReversibleWorkCalculationRequestDto reversibleWorkCalculationRequestDto)
    {
        var response = CalculateReversibleWork(reversibleWorkCalculationRequestDto);

        return Task.FromResult(CustomResponseDto<ReversibleWorkCalculationResponseDto>.Success(200, response));
    }

    private ReversibleWorkCalculationResponseDto CalculateReversibleWork(ReversibleWorkCalculationRequestDto request)
    {
        double wRev = 0;
        double u=request.U;
        double u0=request.U0;
        double t0=request.T0;
        double s=request.S;
        double s0=request.S0;
        double p0=request.P0;
        double v=request.V;
        double v0=request.V0;

        wRev = u-u0-t0*(s-s0)+p0*(v-v0);

        return new ReversibleWorkCalculationResponseDto
        {
            WRev = wRev,
            U = u,
            U0 = u0,
            T0 = t0,
            S = s,
            S0 = s0,
            P0 = p0,
            V = v,
            V0 = v0
        };
    }
}