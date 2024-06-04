using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICompressibilityMultiplierCalculationService
{
    CompressibilityMultiplierCalculationResponseDto CalculateCompressibilityMultiplier(CompressibilityMultiplierCalculationRequestDto request);
}