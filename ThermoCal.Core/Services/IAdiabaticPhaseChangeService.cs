using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticPhaseChangeService
{
    AdiabaticPhaseChangeResponseDto CalculateAdiabaticPhaseChange(AdiabaticPhaseChangeRequestDto request);
}