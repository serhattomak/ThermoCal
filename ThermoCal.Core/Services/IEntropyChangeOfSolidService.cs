using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfSolidService
{
    EntropyChangeOfSolidResponseDto CalculateEntropyChangeOfSolid(EntropyChangeOfSolidRequestDto request);
}