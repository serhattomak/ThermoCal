using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICompressibilityMultiplierCalculationService
{
    Task<CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>> CalculateCompressibilityMultiplierAsync(CompressibilityMultiplierCalculationRequestDto request);
}