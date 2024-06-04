using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IIrreversibilityCalculationService
{
    IrreversibilityCalculationResponseDto CalculateIrreversibility(IrreversibilityCalculationRequestDto request);
}