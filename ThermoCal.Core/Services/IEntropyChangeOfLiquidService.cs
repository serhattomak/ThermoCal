using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfLiquidService
{
    EntropyChangeOfLiquidResponseDto CalculateEntropyChangeOfLiquid(EntropyChangeOfLiquidRequestDto request);
}