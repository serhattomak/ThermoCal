using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IConstantPressurePhaseChangeService
{
    Task<CustomResponseDto<ConstantPressurePhaseChangeResponseDto>> CalculateConstantPressurePhaseChangeAsync(ConstantPressurePhaseChangeRequestDto request);
}