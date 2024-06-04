using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IConstantPressurePhaseChangeService
{
    ConstantPressurePhaseChangeResponseDto CalculateConstantPressurePhaseChange(ConstantPressurePhaseChangeRequestDto request);
}