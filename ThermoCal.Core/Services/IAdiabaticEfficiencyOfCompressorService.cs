using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyOfCompressorService
{
    AdiabaticEfficiencyOfCompressorResponseDto CalculateAdiabaticEfficiencyOfCompressor(AdiabaticEfficiencyOfCompressorRequestDto request);
}