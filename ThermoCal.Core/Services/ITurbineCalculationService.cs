using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ITurbineCalculationService
{
    TurbineCalculationResponseDto Calculate(TurbineCalculationRequestDto request);
}