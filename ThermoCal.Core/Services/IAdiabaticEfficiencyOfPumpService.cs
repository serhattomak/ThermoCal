using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyOfPumpService
{
    AdiabaticEfficiencyOfPumpResponseDto CalculateAdiabaticEfficiencyOfPump(AdiabaticEfficiencyOfPumpRequestDto request);
}