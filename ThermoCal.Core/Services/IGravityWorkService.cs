using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IGravityWorkService
{
    GravityWorkResponseDto CalculateGravityWork(GravityWorkRequestDto request);
}