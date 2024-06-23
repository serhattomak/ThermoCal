using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatPumpEfficiencyService
{
    Task<CustomResponseDto<HeatPumpEfficiencyResponseDto>> CalculateHeatPumpEfficiencyAsync(HeatPumpEfficiencyRequestDto request);
}