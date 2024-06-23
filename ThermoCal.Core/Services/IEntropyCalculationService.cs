using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyCalculationService
{
    Task<CustomResponseDto<EntropyCalculationResponseDto>> CalculateEntropyAsync(EntropyCalculationRequestDto request);
}