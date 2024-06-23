using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IConstantVolumePhaseChangeService
{
    Task<CustomResponseDto<ConstantVolumePhaseChangeResponseDto>> CalculateConstantVolumePhaseChangeAsync(ConstantVolumePhaseChangeRequestDto request);
}