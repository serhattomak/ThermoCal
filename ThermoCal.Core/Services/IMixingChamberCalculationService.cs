using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMixingChamberCalculationService
{
    MixingChamberCalculationResponseDto Calculate(MixingChamberCalculationRequestDto request);
}