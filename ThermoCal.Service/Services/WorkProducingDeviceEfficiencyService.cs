using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class WorkProducingDeviceEfficiencyService: IWorkProducingDeviceEfficiencyService
{
    public Task<CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>> CalculateWorkProducingDeviceEfficiencyAsync(WorkProducingDeviceEfficiencyRequestDto request)
    {
        var response = CalculateWorkProducingDeviceEfficiency(request);

        return Task.FromResult(CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>.Success(200, response));
    }

    private WorkProducingDeviceEfficiencyResponseDto CalculateWorkProducingDeviceEfficiency(WorkProducingDeviceEfficiencyRequestDto request)
    {
        double efficiency = 0;
        double wUseful = request.WSur;
        double wRev = request.WRev;

        efficiency = wRev / wUseful;

        return new WorkProducingDeviceEfficiencyResponseDto
        {
            Efficiency = efficiency,
            WRev = wRev,
            WSur = wUseful
        };
    }
}