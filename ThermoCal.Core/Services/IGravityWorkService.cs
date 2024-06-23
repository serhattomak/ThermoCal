using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IGravityWorkService
{
    Task<CustomResponseDto<GravityWorkResponseDto>> CalculateGravityWorkAsync(GravityWorkRequestDto request);
}