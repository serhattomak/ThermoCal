using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IMechanicalWorkService
{
    MechanicalWorkResponseDto CalculateMechanicalWork(MechanicalWorkRequestDto request);
}