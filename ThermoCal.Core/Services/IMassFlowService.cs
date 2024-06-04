using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMassFlowService
{
    MassFlowResponseDto CalculateMassFlow(MassFlowRequestDto request);
}