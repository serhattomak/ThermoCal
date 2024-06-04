using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IGibbsEquationCalculationService
{
    GibbsEquationCalculationResponseDto CalculateGibbsEquationCalculation(GibbsEquationCalculationRequestDto request);
}