using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IRefrigeratorEfficiencyService
{
    Task<CustomResponseDto<RefrigeratorEfficiencyResponseDto>> CalculateRefrigeratorEfficiencyAsync(RefrigeratorEfficiencyRequestDto request);
}