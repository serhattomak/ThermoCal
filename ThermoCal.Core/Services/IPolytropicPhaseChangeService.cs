using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IPolytropicPhaseChangeService
{
    PolytropicPhaseChangeResponseDto Calculate(PolytropicPhaseChangeRequestDto request);
}