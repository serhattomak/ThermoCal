using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class HeatEngineCalculationService: IHeatEngineCalculationService
{
    public Task<CustomResponseDto<HeatEngineCalculationResponseDto>> CalculateHeatEngineAsync(HeatEngineCalculationRequestDto request)
    {
        var response = CalculateHeatEngine(request);

        return Task.FromResult(CustomResponseDto<HeatEngineCalculationResponseDto>.Success(200, response));
    }

    private HeatEngineCalculationResponseDto CalculateHeatEngine(HeatEngineCalculationRequestDto request)
    {
        double efficiency = 0;
        double q = 0;
        double w=0;
        double qIn = request.QIn;
        double qOut = request.QOut;
        double qNet = request.QNet;
        double qH = request.Qh;
        double qL = request.Ql;
        double wIn = request.WIn;
        double wOut = request.WOut;
        double wNet = request.WNet;

        if (qIn != 0 && qOut != 0)
        {
            q = qIn - qOut;
        }
        else if (qNet != 0)
        {
            q = qNet;
        }

        if (wIn != 0 && wOut != 0)
        {
            w = wIn - wOut;
        }
        else if (wNet != 0)
        {
            w = wNet;
        }

        if (qH != 0 && qL != 0)
        {
            efficiency = (qH - qL) / qH;
        }

        return new HeatEngineCalculationResponseDto
        {
            Efficiency = efficiency,
            Q = q,
            W = w
        };
    }
}