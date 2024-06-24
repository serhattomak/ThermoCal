using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class CompressibilityMultiplierCalculationService : ICompressibilityMultiplierCalculationService
{
    public Task<CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>> CalculateCompressibilityMultiplierAsync(CompressibilityMultiplierCalculationRequestDto request)
    {
        var compressibilityMultiplier = CalculateCompressibilityMultiplier(request);

        var responseDto = new CompressibilityMultiplierCalculationResponseDto
        {
            Z = compressibilityMultiplier,
            P = request.P,
            T = request.T,
            R = request.R,
            V = request.V,
            VSpecific = request.VSpecific,
            VSpecificActual = request.VSpecificActual,
            VSpecificIdeal = request.VSpecificIdeal
        };

        return Task.FromResult(CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>.Success(200, responseDto));
    }

    private double CalculateCompressibilityMultiplier(CompressibilityMultiplierCalculationRequestDto request)
    {
        double z = request.Z;
        double p = request.P;
        double t = request.T;
        double r = request.R;
        double vSpecific = request.VSpecific;
        double vSpecificActual = request.VSpecificActual;
        double vSpecificIdeal = request.VSpecificIdeal;

        if (p != 0 && vSpecific != 0 && r != 0 && t != 0)
        {
            z = p * vSpecific / (r * t);
        }
        else if (vSpecificActual != 0 && vSpecificIdeal != 0)
        {
            z = vSpecificActual / vSpecificIdeal;
        }

        return z;
    }
}