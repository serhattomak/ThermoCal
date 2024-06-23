using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IFlowCalculationInDuctService
{
    Task<CustomResponseDto<FlowCalculationInDuctResponseDto>> CalculateFlowCalculationInDuctAsync(FlowCalculationInDuctRequestDto request);
}