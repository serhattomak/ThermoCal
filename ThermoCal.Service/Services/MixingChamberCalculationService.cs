using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class MixingChamberCalculationService : IMixingChamberCalculationService
{
    public Task<CustomResponseDto<MixingChamberCalculationResponseDto>> CalculateMixingChamberAsync(MixingChamberCalculationRequestDto request)
    {
        var response = CalculateMixingChamber(request);

        return Task.FromResult(CustomResponseDto<MixingChamberCalculationResponseDto>.Success(200, response));
    }

    private MixingChamberCalculationResponseDto CalculateMixingChamber(MixingChamberCalculationRequestDto request)
    {
        double mDotFirst = request.MDotFirst;
        double mDotSecond = request.MDotSecond;
        double mDotIn = request.MDotIn;
        double mDotOut = request.MDotOut;
        double hIn = request.HIn;
        double hOut = request.HOut;

        if (mDotFirst != 0 && mDotSecond != 0)
        {
            mDotIn = mDotFirst + mDotSecond;
        }

        if (mDotOut != 0 && hOut != 0 && hIn != 0)
        {
            mDotIn = mDotOut * hOut / hIn;
        }

        return new MixingChamberCalculationResponseDto
        {
            MDotFirst = mDotFirst,
            MDotSecond = mDotSecond,
            MDotIn = mDotIn,
            MDotOut = mDotOut,
            HIn = hIn,
            HOut = hOut
        };
    }
}