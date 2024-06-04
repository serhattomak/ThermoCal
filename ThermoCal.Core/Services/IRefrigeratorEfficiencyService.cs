using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IRefrigeratorEfficiencyService
{
    RefrigeratorEfficiencyResponseDto Calculate(RefrigeratorEfficiencyRequestDto request);
}