using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyOfCompressorService
{
    Task<CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>> CalculateAdiabaticEfficiencyOfCompressorAsync(AdiabaticEfficiencyOfCompressorRequestDto request);
}