using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyNozzleService
{
    AdiabaticEfficiencyNozzleResponseDto CalculateAdiabaticEfficiencyNozzle(AdiabaticEfficiencyNozzleRequestDto request);
}