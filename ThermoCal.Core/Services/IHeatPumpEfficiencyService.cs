using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatPumpEfficiencyService
{
    HeatPumpEfficiencyResponseDto CalculateHeatPumpEfficiency(HeatPumpEfficiencyRequestDto request);
}