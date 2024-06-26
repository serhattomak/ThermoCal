using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class SpindleWorkService : ISpindleWorkService
{
    public Task<CustomResponseDto<SpindleWorkResponseDto>> CalculateSpindleWorkAsync(SpindleWorkRequestDto spindleWorkRequestDto)
    {
        var response = CalculateSpindleWork(spindleWorkRequestDto);

        return Task.FromResult(CustomResponseDto<SpindleWorkResponseDto>.Success(200, response));
    }

    private SpindleWorkResponseDto CalculateSpindleWork(SpindleWorkRequestDto request)
    {
        double work = 0;
        double f = request.F;
        double s = request.S;
        double n = request.NumberOfRotation;
        double r = request.R;
        double t = request.Torque;

        if (s == 0)
        {
            s = (Math.PI * r * n * 2);
        }
        if (t == 0)
        {
            t = (f * r);
        }
        if (f!=0)
        {
            work = f * s;
        }
        else if (t!=0)
        {
            work = t * s/r;
        }

        return new SpindleWorkResponseDto
        {
            W = work,
            F = f,
            S = s,
            NumberOfRotation = n,
            R = r,
            Torque = t
        };
    }
}