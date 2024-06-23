using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMassFlowService
{
    Task<CustomResponseDto<MassFlowResponseDto>> CalculateMassFlowAsync(MassFlowRequestDto request);
}