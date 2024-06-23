using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyNozzleService
{
    Task<CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>> CalculateAdiabaticEfficiencyNozzleAsync(AdiabaticEfficiencyNozzleRequestDto request);
}