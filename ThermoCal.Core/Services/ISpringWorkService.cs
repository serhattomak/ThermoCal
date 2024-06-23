using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISpringWorkService
{
    Task<CustomResponseDto<SpringWorkResponseDto>> CalculateSpringWorkAsync(SpringWorkRequestDto springWorkRequestDto);
}