using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISurroundWorkCalculationService
{
    Task<CustomResponseDto<SurroundWorkCalculationResponseDto>> CalculateSurroundWorkAsync(SurroundWorkCalculationRequestDto request);
}