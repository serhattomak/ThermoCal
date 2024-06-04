using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class RefrigeratorEfficiencyService: IRefrigeratorEfficiencyService
{
    public RefrigeratorEfficiencyResponseDto Calculate(RefrigeratorEfficiencyRequestDto request)
    {
        var efficiency = request.Efficiency;
        var cop = request.COP;
        var copRev = request.COPRev;

        // Calculation logic here

        return new RefrigeratorEfficiencyResponseDto
        {
            Efficiency = efficiency,
            COP = cop,
            COPRev = copRev
        };
    }
}