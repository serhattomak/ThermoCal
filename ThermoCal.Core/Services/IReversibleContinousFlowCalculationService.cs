using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReversibleContinousFlowCalculationService
{
    ReversibleContinousFlowCalculationResponseDto Calculate(ReversibleContinousFlowCalculationRequestDto request);
}