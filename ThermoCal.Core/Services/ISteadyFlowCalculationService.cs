using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISteadyFlowCalculationService
{
    Task<CustomResponseDto<SteadyFlowCalculationResponseDto>> CalculateSteadyFlowAsync(SteadyFlowCalculationRequestDto request);
}