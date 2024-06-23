using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMinimizeCompressorWorkService
{
    Task<CustomResponseDto<MinimizeCompressorWorkResponseDto>> CalculateMinimizeCompressorWorkAsync(MinimizeCompressorWorkRequestDto request);
}