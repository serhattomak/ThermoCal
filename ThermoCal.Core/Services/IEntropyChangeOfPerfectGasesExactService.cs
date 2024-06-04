using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfPerfectGasesExactService
{
    EntropyChangeOfPerfectGasesExactResponseDto CalculateEntropyChangeOfPerfectGasesExact(EntropyChangeOfPerfectGasesExactRequestDto request);
}