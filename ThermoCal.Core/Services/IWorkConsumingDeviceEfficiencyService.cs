using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IWorkConsumingDeviceEfficiencyService
{
    Task<CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>> CalculateWorkConsumingDeviceEfficiencyAsync(WorkConsumingDeviceEfficiencyRequestDto request);
}