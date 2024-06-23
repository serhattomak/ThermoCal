using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticPhaseChangeService
{
    Task<CustomResponseDto<AdiabaticPhaseChangeResponseDto>> CalculateAdiabaticPhaseChangeAsync(AdiabaticPhaseChangeRequestDto request);
}