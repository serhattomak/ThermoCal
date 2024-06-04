using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatExchangersCalculationService
{
    HeatExchangersCalculationResponseDto CalculateHeatExchangers(HeatExchangersCalculationRequestDto request);
}