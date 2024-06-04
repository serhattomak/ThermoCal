using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyBalanceForClosedSystemService
{
    EntropyBalanceForClosedSystemResponseDto CalculateEntropyBalanceForClosedSystem(EntropyBalanceForClosedSystemRequestDto request);
}