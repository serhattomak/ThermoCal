using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IPressureCalculationService
{
    Task<CustomResponseDto<PressureCalculationResponseDto>> CalculatePressureAsync(PressureCalculationRequestDto request);
}