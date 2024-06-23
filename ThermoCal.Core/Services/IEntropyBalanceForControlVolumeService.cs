using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyBalanceForControlVolumeService
{
    Task<CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>> CalculateEntropyBalanceForControlVolumeAsync(EntropyBalanceForControlVolumeRequestDto request);
}