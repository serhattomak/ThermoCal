using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class HeatExchangersCalculationService: IHeatExchangersCalculationService
{
    public Task<CustomResponseDto<HeatExchangersCalculationResponseDto>> CalculateHeatExchangersAsync(HeatExchangersCalculationRequestDto request)
    {
        var response = CalculateHeatExchangers(request);

        return Task.FromResult(CustomResponseDto<HeatExchangersCalculationResponseDto>.Success(200, response));
    }

    private HeatExchangersCalculationResponseDto CalculateHeatExchangers(HeatExchangersCalculationRequestDto request)
    {
        double qDot= 0;
        double mDot= request.MDot;
        double h1= request.HIn;
        double h2= request.HOut;

        qDot = mDot * (h2 - h1);

        return new HeatExchangersCalculationResponseDto
        {
            QDot = qDot,
            HIn = h1,
            HOut = h2,
            MDot = mDot
        };
    }

}