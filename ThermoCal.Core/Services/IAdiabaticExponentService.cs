using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticExponentService
{
    AdiabaticExponentResponseDto CalculateAdiabaticExponent(AdiabaticExponentRequestDto request);
}