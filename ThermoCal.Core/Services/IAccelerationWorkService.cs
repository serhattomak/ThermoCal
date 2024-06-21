using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAccelerationWorkService
{
    Task<CustomResponseDto<AccelerationWorkResponseDto>> CalculateAccelerationWorkAsync(AccelerationWorkRequestDto request);
}