using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class CompressorCalculationService : ICompressorCalculationService
{
    public Task<CustomResponseDto<CompressorCalculationResponseDto>> CalculateCompressorCalculationAsync(CompressorCalculationRequestDto request)
    {
        var wDot = CalculateCompressorW(request);

        var responseDto = new CompressorCalculationResponseDto
        {
            WMDot = wDot,
            MDot = request.MDot,
            Density = request.Density,
            A = request.A,
            V = request.V,
            HFirst = request.HFirst,
            HSecond = request.HSecond
        };

        return Task.FromResult(CustomResponseDto<CompressorCalculationResponseDto>.Success(200, responseDto));
    }

    private double CalculateCompressorW(CompressorCalculationRequestDto request)
    {
        double wDot = 0;
        double mDot = request.MDot;
        double dFirst = request.Density;
        double aFirst = request.A;
        double vFirst = request.V;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;

        if (mDot == 0)
        {
            mDot= dFirst * aFirst * vFirst;
        }

        if (mDot != 0 && hSecond != 0 && hFirst != 0)
        { 
            wDot = mDot * (hSecond - hFirst);
        }

        return wDot;
    }
}