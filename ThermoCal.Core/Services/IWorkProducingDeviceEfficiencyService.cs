using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IWorkProducingDeviceEfficiencyService
{
    Task<CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>> CalculateWorkProducingDeviceEfficiencyAsync(WorkProducingDeviceEfficiencyRequestDto request);
}