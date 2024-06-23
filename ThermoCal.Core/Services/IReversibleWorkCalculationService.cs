using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IReversibleWorkCalculationService
{
    Task<CustomResponseDto<ReversibleWorkCalculationResponseDto>> CalculateReversibleWorkAsync(ReversibleWorkCalculationRequestDto reversibleWorkCalculationRequestDto);
}