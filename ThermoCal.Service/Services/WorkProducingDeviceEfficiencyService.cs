using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class WorkProducingDeviceEfficiencyService: IWorkProducingDeviceEfficiencyService
{
    public WorkProducingDeviceEfficiencyResponseDto CalculateEfficiency(WorkProducingDeviceEfficiencyRequestDto request)
    {
        var efficiency = request.WSur / request.WRev;
        return new WorkProducingDeviceEfficiencyResponseDto
        {
            Efficiency = efficiency,
        };
    }
}