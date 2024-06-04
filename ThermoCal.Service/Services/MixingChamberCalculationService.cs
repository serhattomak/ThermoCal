using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class MixingChamberCalculationService: IMixingChamberCalculationService
{
    public MixingChamberCalculationResponseDto Calculate(MixingChamberCalculationRequestDto request)
    {
        var result = new MixingChamberCalculationResponseDto();
        result.MDotOut = request.MDotFirst + request.MDotSecond + request.MDotThird;
        result.HOut = (request.MDotFirst * request.HIn + request.MDotSecond * request.HIn + request.MDotThird * request.HIn) / result.MDotOut;
        result.VOut = (request.MDotFirst * request.VIn + request.MDotSecond * request.VIn + request.MDotThird * request.VIn) / result.MDotOut;
        result.ZOut = (request.MDotFirst * request.ZIn + request.MDotSecond * request.ZIn + request.MDotThird * request.ZIn) / result.MDotOut;
        result.G = request.G;
        return result;
    }
}