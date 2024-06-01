using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAccelerationWorkService
{
    AccelerationWorkResponseDto CalculateAccelerationWork(AccelerationWorkRequestDto request);
}