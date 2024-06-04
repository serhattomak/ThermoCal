using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyBalanceForControlVolumeService
{
    EntropyBalanceForControlVolumeResponseDto CalculateEntropyBalanceForControlVolume(EntropyBalanceForControlVolumeRequestDto request);
}