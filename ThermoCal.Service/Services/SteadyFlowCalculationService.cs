using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class SteadyFlowCalculationService: ISteadyFlowCalculationService
{
    public Task<CustomResponseDto<SteadyFlowCalculationResponseDto>> CalculateSteadyFlowAsync(SteadyFlowCalculationRequestDto request)
    {
        var response = CalculateSteadyFlow(request);

        return Task.FromResult(CustomResponseDto<SteadyFlowCalculationResponseDto>.Success(200, response));
    }

    private SteadyFlowCalculationResponseDto CalculateSteadyFlow(SteadyFlowCalculationRequestDto request)
    {
        double mIn= request.MIn;
        double mOut = request.MOut;
        double hIn = request.HIn;
        double hOut = request.HOut;
        double mFirst = request.MFirst;
        double mSecond = request.MSecond;
        double eFirst = request.EFirst;
        double eSecond = request.ESecond;

        hIn=(mSecond*eSecond)/mIn;

        return new SteadyFlowCalculationResponseDto
        {
            MIn = mIn,
            MOut = mOut,
            HIn = hIn,
            HOut = hOut,
            MFirst = mFirst,
            MSecond = mSecond,
            EFirst = eFirst,
            ESecond = eSecond
        };
    }
}