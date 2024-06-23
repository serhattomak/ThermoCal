using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IVolumetricFlowService
{
    Task<CustomResponseDto<VolumetricFlowResponseDto>> CalculateVolumetricFlowAsync(VolumetricFlowRequestDto request);
}