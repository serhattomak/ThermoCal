using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IVolumetricFlowService
{
    VolumetricFlowResponseDto Calculate(VolumetricFlowRequestDto request);
}