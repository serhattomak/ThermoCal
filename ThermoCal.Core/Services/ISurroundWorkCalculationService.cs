using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISurroundWorkCalculationService
{
    SurroundWorkCalculationResponseDto Calculate(SurroundWorkCalculationRequestDto request);
}