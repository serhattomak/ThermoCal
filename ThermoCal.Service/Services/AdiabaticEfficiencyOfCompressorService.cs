using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AdiabaticEfficiencyOfCompressorService: IAdiabaticEfficiencyOfCompressorService
{
    public Task<CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>> CalculateAdiabaticEfficiencyOfCompressorAsync(AdiabaticEfficiencyOfCompressorRequestDto request)
    {
        var efficiency = CalculateAdiabaticEfficiencyOfCompressor(request);

        var responseDto = new AdiabaticEfficiencyOfCompressorResponseDto
        {
            Efficiency = efficiency,
            HFirst = request.HFirst,
            HSecond = request.HSecond,
            HSecondS = request.HSecondS,
            WActual = request.WActual,
            WIsentropic = request.WIsentropic
        };

        return Task.FromResult(CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>.Success(200, responseDto));
    }

    private double CalculateAdiabaticEfficiencyOfCompressor(AdiabaticEfficiencyOfCompressorRequestDto request)
    {
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;
        double hSecondS = request.HSecondS;
        double wActual = request.WActual;
        double wIsentropic = request.WIsentropic;
        double efficiency = 0;

        if (wActual == 0)
        {
            efficiency = (hSecondS - hFirst) / (hSecond - hFirst);
        }
        else
        {
            efficiency = wIsentropic / wActual;
        }

        return efficiency;
    }
}