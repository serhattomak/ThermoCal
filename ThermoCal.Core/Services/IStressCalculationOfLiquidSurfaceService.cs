using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IStressCalculationOfLiquidSurfaceService
{
    Task<CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>> CalculateStressOfLiquidSurfaceAsync(StressCalculationOfLiquidSurfaceRequestDto request);
}