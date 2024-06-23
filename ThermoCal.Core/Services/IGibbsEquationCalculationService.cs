using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IGibbsEquationCalculationService
{
    Task<CustomResponseDto<GibbsEquationCalculationResponseDto>> CalculateGibbsEquationCalculationAsync(GibbsEquationCalculationRequestDto request);
}