using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlexibleRodWorkService
{
    Task<CustomResponseDto<FlexibleRodWorkResponseDto>> CalculateFlexibleRodWorkAsync(FlexibleRodWorkRequestDto request);
}