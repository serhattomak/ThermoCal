using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IIsothermalPhaseChangeService
{
    Task<CustomResponseDto<IsothermalPhaseChangeResponseDto>> CalculateIsothermalPhaseChangeAsync(IsothermalPhaseChangeRequestDto request);
}