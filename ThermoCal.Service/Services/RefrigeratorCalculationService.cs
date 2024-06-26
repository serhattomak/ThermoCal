using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class RefrigeratorCalculationService: IRefrigeratorCalculationService
{
    public Task<CustomResponseDto<RefrigeratorCalculationResponseDto>> CalculateRefrigeratorAsync(RefrigeratorCalculationRequestDto request)
    {
        var response = CalculateRefrigerator(request);

        return Task.FromResult(CustomResponseDto<RefrigeratorCalculationResponseDto>.Success(200, response));
    }

    private RefrigeratorCalculationResponseDto CalculateRefrigerator(RefrigeratorCalculationRequestDto request)
    {
        double q = request.Q;
        double w = request.W;
        double qL = request.Ql;
        double qH = request.Qh;
        double wNet = request.WNet;
        double copRef = request.COPRef;

        if (wNet==0)
        {
            wNet = qH-qL;
        }

        copRef = qL/wNet;

        return new RefrigeratorCalculationResponseDto
        {
            Q = q,
            W = w,
            WNet = wNet,
            COPRef = copRef,
        };
    }
}