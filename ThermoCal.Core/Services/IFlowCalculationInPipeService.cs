using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlowCalculationInPipeService
{
    FlowCalculationInPipeResponseDto CalculateFlowCalculationInPipe(FlowCalculationInPipeRequestDto request);
}