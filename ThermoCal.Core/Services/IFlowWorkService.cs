using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlowWorkService
{
    FlowWorkResponseDto CalculateFlowWork(FlowWorkRequestDto request);
}