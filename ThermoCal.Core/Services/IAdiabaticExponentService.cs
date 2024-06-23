using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IAdiabaticExponentService
{
    Task<CustomResponseDto<AdiabaticExponentResponseDto>> CalculateAdiabaticExponentAsync(AdiabaticExponentRequestDto request);
}