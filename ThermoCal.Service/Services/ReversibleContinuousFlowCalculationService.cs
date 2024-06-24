using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ReversibleContinuousFlowCalculationService: IReversibleContinuousFlowCalculationService
{
    public Task<CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>> CalculateReversibleContinuousFlowAsync(ReversibleContinuousFlowCalculationRequestDto request)
    {
        var response = CalculateReversibleContinuousFlow(request);

        return Task.FromResult(CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>.Success(200, response));
    }

    private ReversibleContinuousFlowCalculationResponseDto CalculateReversibleContinuousFlow(ReversibleContinuousFlowCalculationRequestDto request)
    {
        double wTr= request.WTr;
        double vSpecific = request.VSpecific;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;

        wTr = vSpecific*(pFirst-pSecond);

        return new ReversibleContinuousFlowCalculationResponseDto
        {
            WTr = wTr,
            VSpecific = vSpecific,
            PFirst = pFirst,
            PSecond = pSecond
        };
    }
}