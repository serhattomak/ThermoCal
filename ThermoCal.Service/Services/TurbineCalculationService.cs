using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class TurbineCalculationService : ITurbineCalculationService
{
    public Task<CustomResponseDto<TurbineCalculationResponseDto>> CalculateTurbineAsync(TurbineCalculationRequestDto request)
    {
        var response = CalculateTurbine(request);

        return Task.FromResult(CustomResponseDto<TurbineCalculationResponseDto>.Success(200, response));
    }

    private TurbineCalculationResponseDto CalculateTurbine(TurbineCalculationRequestDto request)
    {
        double wmDot = 0;
        double mDot = request.MDot;
        double density = request.Density;
        double a = request.A;
        double v = request.V;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;


        if (mDot==0)
        {
            mDot = density * a * v;
        }
        
        wmDot = mDot * (hFirst - hSecond);


        return new TurbineCalculationResponseDto
        {
            WMDot = wmDot,
            MDot = mDot,
            Density = density,
            A = a,
            V = v,
            HFirst = hFirst,
            HSecond = hSecond
        };
    }
}