using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReversibleContinuousFlowCalculationService
{
    ReversibleContinuousFlowCalculationResponseDto Calculate(ReversibleContinuousFlowCalculationRequestDto request);
}