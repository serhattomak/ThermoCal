using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ConstantVolumePhaseChangeService: IConstantVolumePhaseChangeService
{
    public Task<CustomResponseDto<ConstantVolumePhaseChangeResponseDto>> CalculateConstantVolumePhaseChangeAsync(ConstantVolumePhaseChangeRequestDto request)
    {
        var Q = CalculateQ(request);

        var responseDto = new ConstantVolumePhaseChangeResponseDto
        {
            Q = Q,
            M = request.M,
            Cv = request.Cv,
            TFirst = request.TFirst,
            TSecond = request.TSecond
        };

        return Task.FromResult(CustomResponseDto<ConstantVolumePhaseChangeResponseDto>.Success(200, responseDto));
    }

    private double CalculateQ(ConstantVolumePhaseChangeRequestDto request)
    {
        double Q = 0;
        double m = request.M;
        double cV = request.Cv;
        double T1 = request.TFirst;
        double T2 = request.TSecond;

        Q = m * cV * (T2 - T1);

        return Q;
    }
}