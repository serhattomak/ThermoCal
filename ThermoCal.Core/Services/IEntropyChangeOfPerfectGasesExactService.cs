using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfPerfectGasesExactService
{
    Task<CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>> CalculateEntropyChangeOfPerfectGasesExactAsync(EntropyChangeOfPerfectGasesExactRequestDto request);
}