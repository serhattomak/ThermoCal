using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class WorkConsumingDeviceEfficiencyService: IWorkConsumingDeviceEfficiencyService
{
    public Task<CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>> CalculateWorkConsumingDeviceEfficiencyAsync(WorkConsumingDeviceEfficiencyRequestDto request)
    {
        var response = CalculateWorkConsumingDeviceEfficiency(request);

        return Task.FromResult(CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>.Success(200, response));
    }

    private WorkConsumingDeviceEfficiencyResponseDto CalculateWorkConsumingDeviceEfficiency(WorkConsumingDeviceEfficiencyRequestDto request)
    {
        double efficiency = 0;
        double wUseful = request.WSur;
        double wRev = request.WRev;

        efficiency = wUseful / wRev;

        return new WorkConsumingDeviceEfficiencyResponseDto
        {
            Efficiency = efficiency
        };
    }
}