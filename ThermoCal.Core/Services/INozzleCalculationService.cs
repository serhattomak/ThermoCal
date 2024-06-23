using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface INozzleCalculationService
{
    Task<CustomResponseDto<NozzleCalculationResponseDto>> CalculateNozzleAsync(NozzleCalculationRequestDto request);
}