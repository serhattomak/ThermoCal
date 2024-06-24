using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ReducedPressureAndTemperatureService: IReducedPressureAndTemperatureService
{
    public Task<CustomResponseDto<ReducedPressureAndTemperatureResponseDto>> CalculateReducedPressureAndTemperatureAsync(ReducedPressureAndTemperatureRequestDto request)
    {
        var response = CalculateReducedPressureAndTemperature(request);

        return Task.FromResult(CustomResponseDto<ReducedPressureAndTemperatureResponseDto>.Success(200, response));
    }

    private ReducedPressureAndTemperatureResponseDto CalculateReducedPressureAndTemperature(ReducedPressureAndTemperatureRequestDto request)
    {
        double p = request.P;
        double t = request.T;
        double pR = request.Pr;
        double tR = request.Tr;
        double pCr = request.PCr;
        double tCr = request.TCr;

        pR= p / pCr;
        tR = t / tCr;

        return new ReducedPressureAndTemperatureResponseDto
        {
            P = p,
            T = t,
            Pr = pR,
            Tr = tR,
            PCr = pCr,
            TCr = tCr
        };
    }
}