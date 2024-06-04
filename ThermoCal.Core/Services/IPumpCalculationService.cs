using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IPumpCalculationService
{
    PumpCalculationResponseDto Calculate(PumpCalculationRequestDto request);
}