using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyOfPumpService
{
    Task<CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>> CalculateAdiabaticEfficiencyOfPumpAsync(AdiabaticEfficiencyOfPumpRequestDto request);
}