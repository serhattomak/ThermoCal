using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyBalanceForClosedSystemService
{
    Task<CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>> CalculateEntropyBalanceForClosedSystemAsync(EntropyBalanceForClosedSystemRequestDto request);
}