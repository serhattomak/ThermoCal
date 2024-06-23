using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IDiffuserCalculationService
{
    Task<CustomResponseDto<DiffuserCalculationResponseDto>> CalculateDiffuserAsync(DiffuserCalculationRequestDto request);
}