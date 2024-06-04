using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlexibleRodWorkService
{
    FlexibleRodWorkResponseDto CalculateFlexibleRodWork(FlexibleRodWorkRequestDto request);
}