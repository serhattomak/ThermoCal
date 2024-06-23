using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IDegreeOfDrynessCalculationService
{
    Task<CustomResponseDto<DegreeOfDrynessCalculationResponseDto>> CalculateDegreeOfDrynessAsync(DegreeOfDrynessCalculationRequestDto request);
}