using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class RefrigeratorCalculationService: IRefrigeratorCalculationService
{
    public RefrigeratorCalculationResponseDto Calculate(RefrigeratorCalculationRequestDto request)
    {
        var efficiency = request.Efficiency;
        var copHeat = request.COPHeat;
        var copRef = request.COPRef;
        var q = request.Q;
        var w = request.W;
        var qh = request.Qh;
        var ql = request.Ql;
        var th = request.Th;
        var tl = request.Tl;
        var wIn = request.WIn;
        var wOut = request.WOut;
        var wNet = request.WNet;
        var qIn = request.QIn;
        var qOut = request.QOut;
        var qNet = request.QNet;

        // Calculation logic here

        return new RefrigeratorCalculationResponseDto
        {
            Efficiency = efficiency,
            COPHeat = copHeat,
            COPRef = copRef,
            Q = q,
            W = w,
            Qh = qh,
            Ql = ql,
            Th = th,
            Tl = tl,
            WIn = wIn,
            WOut = wOut,
            WNet = wNet,
            QIn = qIn,
            QOut = qOut,
            QNet = qNet
        };
    }
}