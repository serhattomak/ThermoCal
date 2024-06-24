using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class NozzleCalculationService : INozzleCalculationService
{
    public Task<CustomResponseDto<NozzleCalculationResponseDto>> CalculateNozzleAsync(NozzleCalculationRequestDto request)
    {
        var response = CalculateNozzle(request);

        return Task.FromResult(CustomResponseDto<NozzleCalculationResponseDto>.Success(200, response));
    }

    private NozzleCalculationResponseDto CalculateNozzle(NozzleCalculationRequestDto request)
    {
        double vSecond = request.VSecond;
        double hFirst = request.HFirst;
        double hSecond = request.HSecond;

        vSecond = Math.Sqrt(2 * (hFirst - hSecond));

        return new NozzleCalculationResponseDto
        {
            VSecond = vSecond
        };
    }
}