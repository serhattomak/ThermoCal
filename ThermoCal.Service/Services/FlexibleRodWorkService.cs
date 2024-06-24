using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class FlexibleRodWorkService : IFlexibleRodWorkService
{
    public Task<CustomResponseDto<FlexibleRodWorkResponseDto>> CalculateFlexibleRodWorkAsync(FlexibleRodWorkRequestDto request)
    {
        var work = CalculateWork(request);

        var response = new FlexibleRodWorkResponseDto
        {
            W = work
        };

        return Task.FromResult(CustomResponseDto<FlexibleRodWorkResponseDto>.Success(200, response));
    }

    private double CalculateWork(FlexibleRodWorkRequestDto request)
    {
        double work = 0;
        double F = request.F;
        double P = request.P;
        double A = request.A;
        double sigmaN = request.SigmaN;
        double vFirst = request.VFirst;
        double vSecond = request.VSecond;
        double xFirst = request.XFirst;
        double xSecond = request.XSecond;

        if (P != 0 && vSecond != 0 && vFirst != 0 && A != 0)
        {
            work = P * (vSecond - vFirst);
        }
        else if (P != 0 && xSecond != 0 && xFirst != 0 && A != 0)
        {
            work = P * A * (xSecond - xFirst);
        }
        else if (F != 0 && xSecond != 0 && xFirst != 0)
        {
            work = F * (xSecond - xFirst);
        }
        else if (sigmaN != 0 && vSecond != 0 && vFirst != 0)
        {
            work = sigmaN * (vSecond - vFirst);
        }
        else if (sigmaN != 0 && xSecond != 0 && xFirst != 0 && A != 0)
        {
            work = sigmaN * A * (xSecond - xFirst);
        }
        else
        {
            work = 0;
        }

        return work;
    }
}