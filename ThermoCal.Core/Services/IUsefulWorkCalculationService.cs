using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IUsefulWorkCalculationService
{
    Task<CustomResponseDto<UsefulWorkCalculationResponseDto>> CalculateUsefulWorkAsync(UsefulWorkCalculationRequestDto request);
}