using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AccelerationWorkService: IAccelerationWorkService
{
    public Task<CustomResponseDto<AccelerationWorkResponseDto>> CalculateAccelerationWorkAsync(AccelerationWorkRequestDto request)
    {
        var work = CalculateAccelerationWork(request);

        var responseDto = new AccelerationWorkResponseDto
        {
            W = work,
            F = request.F,
            M = request.M,
            A = request.A,
            VFirst = request.VFirst,
            VSecond = request.VSecond
        };

        return Task.FromResult(CustomResponseDto<AccelerationWorkResponseDto>.Success(200, responseDto));
    }

    private double CalculateAccelerationWork(AccelerationWorkRequestDto request)
    {
        double mass = request.M;
        double acceleration = request.A;
        double force = request.F;
        double velocityFirst = request.VFirst;
        double velocitySecond = request.VSecond;
        double work = 0.5*mass*(velocitySecond*velocitySecond-velocityFirst*velocityFirst);

        return work;
    }
}