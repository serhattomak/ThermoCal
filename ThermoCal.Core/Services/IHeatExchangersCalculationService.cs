using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatExchangersCalculationService
{
    Task<CustomResponseDto<HeatExchangersCalculationResponseDto>> CalculateHeatExchangersAsync(HeatExchangersCalculationRequestDto request);
}