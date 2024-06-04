using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IRefrigeratorCalculationService
{
    RefrigeratorCalculationResponseDto Calculate(RefrigeratorCalculationRequestDto request);
}