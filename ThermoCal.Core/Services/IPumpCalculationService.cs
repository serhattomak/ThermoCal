using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IPumpCalculationService
{
    Task<CustomResponseDto<PumpCalculationResponseDto>> CalculatePumpAsync(PumpCalculationRequestDto request);
}