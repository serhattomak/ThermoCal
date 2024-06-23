using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlowWorkService
{
    Task<CustomResponseDto<FlowWorkResponseDto>> CalculateFlowWorkAsync(FlowWorkRequestDto request);
}