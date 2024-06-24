using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class PressureCalculationService : IPressureCalculationService
{
    public Task<CustomResponseDto<PressureCalculationResponseDto>> CalculatePressureAsync(PressureCalculationRequestDto request)
    {
        var response = CalculatePressure(request);

        return Task.FromResult(CustomResponseDto<PressureCalculationResponseDto>.Success(200, response));
    }

    private PressureCalculationResponseDto CalculatePressure(PressureCalculationRequestDto request)
    {
        double p = request.P;
        double pAbsolute = request.PAbsolute;
        double pGauge = request.PGauge;
        double pAtm = request.PAtm;
        double pVacuum = request.PVacuum;
        double density = request.Density;
        double g = request.G;
        double h = request.H;

        if (density != 0 && g != 0 && h != 0)
        {
            pAtm = density * g * h;
        }

        pAtm = pAbsolute + pVacuum;
        pVacuum = pAtm - pAbsolute;
        pGauge = pAbsolute - pAtm;


        return new PressureCalculationResponseDto
        {
            P = p,
            PAbsolute = pAbsolute,
            PGauge = pGauge,
            PAtm = pAtm,
            PVacuum = pVacuum,
            Density = density,
            G = g,
            H = h
        };
    }
}