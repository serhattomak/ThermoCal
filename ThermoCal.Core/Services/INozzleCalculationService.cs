using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface INozzleCalculationService
{
    NozzleCalculationResponseDto Calculate(NozzleCalculationRequestDto request);
}