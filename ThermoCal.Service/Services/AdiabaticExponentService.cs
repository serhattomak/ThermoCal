using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class AdiabaticExponentService : IAdiabaticExponentService
{
    public Task<CustomResponseDto<AdiabaticExponentResponseDto>> CalculateAdiabaticExponentAsync(AdiabaticExponentRequestDto request)
    {
        var exponent = CalculateAdiabaticExponent(request);

        var responseDto = new AdiabaticExponentResponseDto
        {
            K = exponent,
            Cp = request.Cp,
            Cv = request.Cv
        };

        return Task.FromResult(CustomResponseDto<AdiabaticExponentResponseDto>.Success(200, responseDto));
    }

    private double CalculateAdiabaticExponent(AdiabaticExponentRequestDto request)
    {
        double cp = request.Cp;
        double cv = request.Cv;
        double exponent = cp / cv;

        return exponent;
    }
}