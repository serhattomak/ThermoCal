using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMinimizeCompressorWorkService
{
    MinimizeCompressorWorkResponseDto CalculateMinimizeCompressorWork(MinimizeCompressorWorkRequestDto request);
}