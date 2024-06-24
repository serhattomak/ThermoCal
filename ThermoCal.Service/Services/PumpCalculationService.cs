using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class PumpCalculationService : IPumpCalculationService
{
    public Task<CustomResponseDto<PumpCalculationResponseDto>> CalculatePumpAsync(PumpCalculationRequestDto request)
    {
        var response = CalculatePump(request);

        return Task.FromResult(CustomResponseDto<PumpCalculationResponseDto>.Success(200, response));
    }

    private PumpCalculationResponseDto CalculatePump(PumpCalculationRequestDto request)
    {
        double wmDot = request.WMDot;
        double mDot = request.MDot;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;
        double g = request.G;
        double density = request.Density;
        double zFirst = request.ZFirst;
        double zSecond = request.ZSecond;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;
        double tFirst = request.TFirst;
        double tSecond = request.TSecond;
        double uFirst = request.UFirst;
        double uSecond = request.USecond;
        double c = request.C;
        double vSpecific = request.VSpecific;
        double vSpecificFirst = request.VSpecificFirst;
        double vSpecificSecond = request.VSpecificSecond;

        if (pFirst != 0 && pSecond != 0)
        {
            wmDot = mDot * (g * (zSecond - zFirst) + ((pSecond - pFirst) * density));
        }
        else if (c != 0)
        {
            wmDot = mDot * (c * (tSecond - tFirst) + ((pSecond - pFirst) * vSpecific) + (g * (zSecond - zFirst)));
        }
        else
        {
            wmDot = mDot * ((hSecond - hFirst) * g * (zSecond - zFirst));
        }

        return new PumpCalculationResponseDto
        {
            WMDot = wmDot,
            HFirst = hFirst,
            HSecond = hSecond,
            G = g,
            Density = density,
            ZFirst = zFirst,
            ZSecond = zSecond,
            PFirst = pFirst,
            PSecond = pSecond,
            TFirst = tFirst,
            TSecond = tSecond,
            UFirst = uFirst,
            USecond = uSecond,
            C = c,
            VSpecific = vSpecific,
            VSpecificFirst = vSpecificFirst,
            VSpecificSecond = vSpecificSecond
        };
    }
}