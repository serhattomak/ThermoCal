using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IDegreeOfDrynessCalculationService
{
    DegreeOfDrynessCalculationResponseDto CalculateDegreeOfDryness(DegreeOfDrynessCalculationRequestDto request);
}