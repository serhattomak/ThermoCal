using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMixingChamberCalculationService
{
    Task<CustomResponseDto<MixingChamberCalculationResponseDto>> CalculateMixingChamberAsync(MixingChamberCalculationRequestDto request);
}