using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class RefrigeratorEfficiencyService: IRefrigeratorEfficiencyService
{
    public Task<CustomResponseDto<RefrigeratorEfficiencyResponseDto>> CalculateRefrigeratorEfficiencyAsync(RefrigeratorEfficiencyRequestDto request)
    {
        var response = CalculateRefrigeratorEfficiency(request);

        return Task.FromResult(CustomResponseDto<RefrigeratorEfficiencyResponseDto>.Success(200, response));
    }

    private RefrigeratorEfficiencyResponseDto CalculateRefrigeratorEfficiency(RefrigeratorEfficiencyRequestDto request)
    {
        double efficiency = 0;
        double cop = request.COP;
        double copRev = request.COPRev;

        efficiency = cop / copRev;

        return new RefrigeratorEfficiencyResponseDto
        {
            Efficiency = efficiency,
            COP = cop,
            COPRev = copRev
        };
    }
}