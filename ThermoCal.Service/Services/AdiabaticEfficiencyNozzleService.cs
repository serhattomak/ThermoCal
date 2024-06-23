using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AdiabaticEfficiencyNozzleService: IAdiabaticEfficiencyNozzleService
{
    public Task<CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>> CalculateAdiabaticEfficiencyNozzleAsync(AdiabaticEfficiencyNozzleRequestDto request)
    {
        var efficiency = CalculateAdiabaticEfficiencyNozzle(request);

        var responseDto = new AdiabaticEfficiencyNozzleResponseDto
        {
            Efficiency = efficiency,
            VelocitySecond = request.VelocitySecond,
            VelocitySecondS = request.VelocitySecondS,
            HFirst = request.HFirst,
            HSecond = request.HSecond,
            HSecondS = request.HSecondS
        };
        
        return Task.FromResult(CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>.Success(200, responseDto));

    }

    private double CalculateAdiabaticEfficiencyNozzle(AdiabaticEfficiencyNozzleRequestDto request)
    {
        double velocitySecond = request.VelocitySecond;
        double velocitySecondS = request.VelocitySecondS;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;
        double hSecondS = request.HSecondS;
        double efficiency=0;

        if (velocitySecondS == 0 )
        {
            efficiency = (hFirst - hSecond) / (hFirst - hSecondS);
        }
        else
        {
            efficiency = (velocitySecond * velocitySecond) / (velocitySecondS * velocitySecondS);
        }

        return efficiency;
    }
}