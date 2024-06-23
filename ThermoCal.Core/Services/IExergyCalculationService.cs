using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IExergyCalculationService
{
    Task<CustomResponseDto<ExergyCalculationResponseDto>> CalculateExergyAsync(ExergyCalculationRequestDto request);
}