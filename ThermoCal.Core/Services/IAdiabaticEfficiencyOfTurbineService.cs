using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticEfficiencyOfTurbineService
{
    AdiabaticEfficiencyOfTurbineResponseDto CalculateAdiabaticEfficiencyOfTurbine(AdiabaticEfficiencyOfTurbineRequestDto request);
}