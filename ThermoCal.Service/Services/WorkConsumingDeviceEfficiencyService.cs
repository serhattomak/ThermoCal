using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class WorkConsumingDeviceEfficiencyService: IWorkConsumingDeviceEfficiencyService
{
    public WorkConsumingDeviceEfficiencyResponseDto CalculateEfficiency(WorkConsumingDeviceEfficiencyRequestDto request)
    {
        var efficiency = request.WSur / request.WRev;
        return new WorkConsumingDeviceEfficiencyResponseDto
        {
            Efficiency = efficiency,
        };
    }
}