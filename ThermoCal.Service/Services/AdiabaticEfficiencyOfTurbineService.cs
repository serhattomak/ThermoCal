using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AdiabaticEfficiencyOfTurbineService: IAdiabaticEfficiencyOfTurbineService
{
    public Task<CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>> CalculateAdiabaticEfficiencyOfTurbineAsync(AdiabaticEfficiencyOfTurbineRequestDto request)
    {
        var efficiency = CalculateAdiabaticEfficiencyOfTurbine(request);

        var responseDto = new AdiabaticEfficiencyOfTurbineResponseDto
        {
            Efficiency = efficiency,
            HFirst = request.HFirst,
            HSecond = request.HSecond,
            HSecondS = request.HSecondS,
            WActual = request.WActual,
            WIsentropic = request.WIsentropic
        };

        return Task.FromResult(CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>.Success(200, responseDto));
    }

    private double CalculateAdiabaticEfficiencyOfTurbine(AdiabaticEfficiencyOfTurbineRequestDto request)
    {
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;
        double hSecondS = request.HSecondS;
        double wActual = request.WActual;
        double wIsentropic = request.WIsentropic;
        double efficiency = 0;

        if (wIsentropic == 0)
        {
            efficiency = (hFirst - hSecond) / (hFirst - hSecondS);
        }
        else
        {
            efficiency = wActual / wIsentropic;
        }

        return efficiency;
    }
}