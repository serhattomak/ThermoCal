using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReversibleWorkCalculationService
{
    ReversibleWorkCalculationResponseDto CalculateReversibleWork(ReversibleWorkCalculationRequestDto reversibleWorkCalculationRequestDto);
}