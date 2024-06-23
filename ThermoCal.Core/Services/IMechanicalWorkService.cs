using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMechanicalWorkService
{
    Task<CustomResponseDto<MechanicalWorkResponseDto>> CalculateMechanicalWorkAsync(MechanicalWorkRequestDto request);
}