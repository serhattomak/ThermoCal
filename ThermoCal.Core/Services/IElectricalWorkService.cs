using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IElectricalWorkService
{
    ElectricalWorkResponseDto CalculateElectricalWork(ElectricalWorkRequestDto request);
}