using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IUsefulWorkCalculationService
{
    UsefulWorkCalculationResponseDto Calculate(UsefulWorkCalculationRequestDto request);
}