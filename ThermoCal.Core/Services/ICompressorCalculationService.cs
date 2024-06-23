using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICompressorCalculationService
{
    Task<CustomResponseDto<CompressorCalculationResponseDto>> CalculateCompressorCalculationAsync(CompressorCalculationRequestDto request);
}