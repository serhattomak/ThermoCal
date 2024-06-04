using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IStressCalculationOfLiquidSurfaceService
{
    StressCalculationOfLiquidSurfaceResponseDto Calculate(StressCalculationOfLiquidSurfaceRequestDto request);
}