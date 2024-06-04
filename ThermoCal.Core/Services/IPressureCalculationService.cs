using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IPressureCalculationService
{
    PressureCalculationResponseDto Calculate(PressureCalculationRequestDto request);
}