using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IWorkConsumingDeviceEfficiencyService
{
    WorkConsumingDeviceEfficiencyResponseDto CalculateEfficiency(WorkConsumingDeviceEfficiencyRequestDto request);
}