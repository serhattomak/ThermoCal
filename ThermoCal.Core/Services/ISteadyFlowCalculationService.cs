using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISteadyFlowCalculationService
{
    SteadyFlowCalculationResponseDto Calculate(SteadyFlowCalculationRequestDto request);
}