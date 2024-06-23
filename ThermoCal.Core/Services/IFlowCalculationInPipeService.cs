using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlowCalculationInPipeService
{
    Task<CustomResponseDto<FlowCalculationInPipeResponseDto>> CalculateFlowCalculationInPipeAsync(FlowCalculationInPipeRequestDto request);
}