using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IDiffuserCalculationService
{
    DiffuserCalculationResponseDto CalculateDiffuser(DiffuserCalculationRequestDto request);
}