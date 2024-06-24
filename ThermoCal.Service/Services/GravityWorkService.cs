using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class GravityWorkService: IGravityWorkService
{
    public Task<CustomResponseDto<GravityWorkResponseDto>> CalculateGravityWorkAsync(GravityWorkRequestDto request)
    {
        var response = CalculateGravityWork(request);

        return Task.FromResult(CustomResponseDto<GravityWorkResponseDto>.Success(200, response));
    }

    private GravityWorkResponseDto CalculateGravityWork(GravityWorkRequestDto request)
    {
        double work = 0;
        double m = request.M;
        double g = request.G;
        double h = request.H;

        work = m * g * h;

        return new GravityWorkResponseDto
        {
            W = work
        };
    }
}