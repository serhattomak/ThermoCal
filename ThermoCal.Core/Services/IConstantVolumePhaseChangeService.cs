using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IConstantVolumePhaseChangeService
{
    ConstantVolumePhaseChangeResponseDto CalculateConstantVolumePhaseChange(ConstantVolumePhaseChangeRequestDto request);
}