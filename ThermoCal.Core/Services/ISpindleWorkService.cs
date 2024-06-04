using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISpindleWorkService
{
    SpindleWorkResponseDto CalculateSpindleWork(SpindleWorkRequestDto spindleWorkRequestDto);
}