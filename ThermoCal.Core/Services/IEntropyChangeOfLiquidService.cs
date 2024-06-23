using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfLiquidService
{
    Task<CustomResponseDto<EntropyChangeOfLiquidResponseDto>> CalculateEntropyChangeOfLiquidAsync(EntropyChangeOfLiquidRequestDto request);
}