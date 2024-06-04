using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlowCalculationInDuctService
{
    FlowCalculationInDuctResponseDto CalculateFlowCalculationInDuct(FlowCalculationInDuctRequestDto request);
}