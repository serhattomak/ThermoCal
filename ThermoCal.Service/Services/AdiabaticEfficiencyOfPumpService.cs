using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AdiabaticEfficiencyOfPumpService : IAdiabaticEfficiencyOfPumpService
{
    public Task<CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>> CalculateAdiabaticEfficiencyOfPumpAsync(AdiabaticEfficiencyOfPumpRequestDto request)
    {
        var efficiency = CalculateAdiabaticEfficiencyOfPump(request);

        var responseDto = new AdiabaticEfficiencyOfPumpResponseDto
        {
            Efficiency = efficiency,
            VSpecific = request.VSpecific,
            HFirst = request.HFirst,
            HSecond = request.HSecond,
            PFirst = request.PFirst,
            PSecond = request.PSecond
        };

        return Task.FromResult(CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>.Success(200, responseDto));
    }

    private double CalculateAdiabaticEfficiencyOfPump(AdiabaticEfficiencyOfPumpRequestDto request)
    {
        double vSpecific = request.VSpecific;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;
        double efficiency = ((vSpecific)*(pSecond-pFirst)/(hSecond-hFirst));

        return efficiency;
    }
}