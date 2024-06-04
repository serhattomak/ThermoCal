using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IExergyCalculationService
{
    ExergyCalculationResponseDto CalculateExergy(ExergyCalculationRequestDto request);
}