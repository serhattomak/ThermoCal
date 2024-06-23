using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyOfTurbineService
{
    Task<CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>> CalculateAdiabaticEfficiencyOfTurbineAsync(AdiabaticEfficiencyOfTurbineRequestDto request);
}