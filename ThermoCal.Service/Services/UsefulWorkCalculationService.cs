using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class UsefulWorkCalculationService: IUsefulWorkCalculationService
{
    public Task<CustomResponseDto<UsefulWorkCalculationResponseDto>> CalculateUsefulWorkAsync(UsefulWorkCalculationRequestDto request)
    {
        var response = CalculateUsefulWork(request);

        return Task.FromResult(CustomResponseDto<UsefulWorkCalculationResponseDto>.Success(200, response));
    }

    private UsefulWorkCalculationResponseDto CalculateUsefulWork(UsefulWorkCalculationRequestDto request)
    {
        double w=request.W;
        double wUseful=request.WUseful;
        double wSurround=request.WSur;

        wUseful=w-wSurround;

        return new UsefulWorkCalculationResponseDto
        {
            W = w,
            WUseful = wUseful,
            WSur = wSurround
        };
    }
}