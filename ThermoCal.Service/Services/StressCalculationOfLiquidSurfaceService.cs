using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class StressCalculationOfLiquidSurfaceService: IStressCalculationOfLiquidSurfaceService
{
    public Task<CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>> CalculateStressOfLiquidSurfaceAsync(StressCalculationOfLiquidSurfaceRequestDto request)
    {
        var response = CalculateStressCalculationOfLiquidSurface(request);

        return Task.FromResult(CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>.Success(200, response));
    }

    private StressCalculationOfLiquidSurfaceResponseDto CalculateStressCalculationOfLiquidSurface(StressCalculationOfLiquidSurfaceRequestDto request)
    {
        double work = 0;
        double stress = request.SigmaY;
        double aFirst = request.AFirst;
        double aSecond = request.ASecond;

        work = stress * (aSecond - aFirst);

        return new StressCalculationOfLiquidSurfaceResponseDto
        {
            W = work,
            SigmaY = stress,
            AFirst = aFirst,
            ASecond = aSecond
        };
    }
}