using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ExergyCalculationService: IExergyCalculationService
{
    public Task<CustomResponseDto<ExergyCalculationResponseDto>> CalculateExergyAsync(ExergyCalculationRequestDto request)
    {
        var exergy = CalculateExergy(request);

        var response = new ExergyCalculationResponseDto
        {
            Exergy = exergy
        };

        return Task.FromResult(CustomResponseDto<ExergyCalculationResponseDto>.Success(200, response));
    }

    private double CalculateExergy(ExergyCalculationRequestDto request)
    {
        double exergy = 0;
        double u = request.U;
        double u0 = request.U0;
        double t0 = request.T0;
        double s = request.S;
        double s0 = request.S0;
        double p0= request.P0;
        double v= request.V;
        double v0= request.V0;

        exergy = u-u0-(t0*(s-s0))+(p0*(v-v0));

        return exergy;
    }
}