using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfPureService
{
    EntropyChangeOfPureResponseDto CalculateEntropyChangeOfPure(EntropyChangeOfPureRequestDto request);
}