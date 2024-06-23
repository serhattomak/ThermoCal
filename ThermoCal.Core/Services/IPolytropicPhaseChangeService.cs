using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IPolytropicPhaseChangeService
{
    Task<CustomResponseDto<PolytropicPhaseChangeResponseDto>> CalculatePolytropicPhaseChangeAsync(PolytropicPhaseChangeRequestDto request);
}