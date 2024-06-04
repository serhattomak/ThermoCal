using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IWorkProducingDeviceEfficiencyService
{
    WorkProducingDeviceEfficiencyResponseDto CalculateEfficiency(WorkProducingDeviceEfficiencyRequestDto request);
}