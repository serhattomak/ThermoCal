using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReversibleContinuousFlowCalculationService
{
    Task<CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>> CalculateReversibleContinuousFlowAsync(ReversibleContinuousFlowCalculationRequestDto request);
}