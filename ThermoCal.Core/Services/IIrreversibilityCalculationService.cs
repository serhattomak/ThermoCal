using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IIrreversibilityCalculationService
{
    Task<CustomResponseDto<IrreversibilityCalculationResponseDto>> CalculateIrreversibilityAsync(IrreversibilityCalculationRequestDto request);
}