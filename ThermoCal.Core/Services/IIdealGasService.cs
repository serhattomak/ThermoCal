using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IIdealGasService
{
    IdealGasResponseDto CalculateIdealGas(IdealGasRequestDto request);
}