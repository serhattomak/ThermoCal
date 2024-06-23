using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfSolidService
{
    Task<CustomResponseDto<EntropyChangeOfSolidResponseDto>> CalculateEntropyChangeOfSolidAsync(EntropyChangeOfSolidRequestDto request);
}