using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class SpringWorkService : ISpringWorkService
{
    public Task<CustomResponseDto<SpringWorkResponseDto>> CalculateSpringWorkAsync(SpringWorkRequestDto springWorkRequestDto)
    {
        var response = CalculateSpringWork(springWorkRequestDto);

        return Task.FromResult(CustomResponseDto<SpringWorkResponseDto>.Success(200, response));
    }

    private SpringWorkResponseDto CalculateSpringWork(SpringWorkRequestDto request)
    {
        double work = 0;
        double f = request.F;
        double x = request.X;
        double k = request.K;

        f = k * x;
        work = 0.5 * k * x * x;

        return new SpringWorkResponseDto
        {
            W = work,
            F = f,
            X = x,
            K = k
        };
    }
}