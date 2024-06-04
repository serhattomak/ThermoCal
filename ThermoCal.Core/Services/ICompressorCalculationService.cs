using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ICompressorCalculationService
{
    CompressorCalculationResponseDto CalculateCompressorCalculation(CompressorCalculationRequestDto request);
}