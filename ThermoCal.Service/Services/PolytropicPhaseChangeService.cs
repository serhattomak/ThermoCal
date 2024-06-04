using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class PolytropicPhaseChangeService: IPolytropicPhaseChangeService
{
    public PolytropicPhaseChangeResponseDto Calculate(PolytropicPhaseChangeRequestDto request)
    {
        var result = new PolytropicPhaseChangeResponseDto();
        return result;
    }
}