using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class HeatPumpEfficiencyService: IHeatPumpEfficiencyService
{
    public Task<CustomResponseDto<HeatPumpEfficiencyResponseDto>> CalculateHeatPumpEfficiencyAsync(HeatPumpEfficiencyRequestDto request)
    {
        var response = CalculateHeatPumpEfficiency(request);

        return Task.FromResult(CustomResponseDto<HeatPumpEfficiencyResponseDto>.Success(200, response));
    }

    private HeatPumpEfficiencyResponseDto CalculateHeatPumpEfficiency(HeatPumpEfficiencyRequestDto request)
    {
        double efficiency = 0;
        double cop = request.COP;
        double copRev = request.COPRev;

        efficiency = cop / copRev;

        return new HeatPumpEfficiencyResponseDto
        {
            Efficiency = efficiency,
            COP = cop,
            COPRev = copRev
        };
    }
}