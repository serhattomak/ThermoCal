using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IIdealGasService
{
    Task<CustomResponseDto<IdealGasResponseDto>> CalculateIdealGasAsync(IdealGasRequestDto request);
}