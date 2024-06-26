using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class IrreversibilityCalculationService: IIrreversibilityCalculationService
{
    public Task<CustomResponseDto<IrreversibilityCalculationResponseDto>> CalculateIrreversibilityAsync(IrreversibilityCalculationRequestDto request)
    {
        var response = CalculateIrreversibility(request);

        return Task.FromResult(CustomResponseDto<IrreversibilityCalculationResponseDto>.Success(200, response));
    }

    private IrreversibilityCalculationResponseDto CalculateIrreversibility(IrreversibilityCalculationRequestDto request)
    {
        double i = 0;
        double wRev=request.WRev;
        double wSur=0;
        double P0=request.P0;
        double V=request.V;
        double V0=request.V0;
        double U=request.U;
        double U0=request.U0;
        double T0=request.T0;
        double S=request.S;
        double S0=request.S0;

        i=(U-U0-T0*(S-S0)+P0*(V-V0))-(wRev+wSur);

        return new IrreversibilityCalculationResponseDto
        {
            I = i,
            WRev = wRev,
            WSur = wSur
        };
    }
}