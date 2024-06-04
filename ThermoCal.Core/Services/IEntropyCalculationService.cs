using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyCalculationService
{
    EntropyCalculationResponseDto CalculateEntropy(EntropyCalculationRequestDto request);
}