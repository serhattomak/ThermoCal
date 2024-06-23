using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISpindleWorkService
{
    Task<CustomResponseDto<SpindleWorkResponseDto>> CalculateSpindleWorkAsync(SpindleWorkRequestDto spindleWorkRequestDto);
}