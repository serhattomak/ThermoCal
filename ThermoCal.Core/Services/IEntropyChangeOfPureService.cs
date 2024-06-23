using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfPureService
{
    Task<CustomResponseDto<EntropyChangeOfPureResponseDto>> CalculateEntropyChangeOfPureAsync(EntropyChangeOfPureRequestDto request);
}