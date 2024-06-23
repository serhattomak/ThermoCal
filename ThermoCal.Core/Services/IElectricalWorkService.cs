using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IElectricalWorkService
{
    Task<CustomResponseDto<ElectricalWorkResponseDto>> CalculateElectricalWorkAsync(ElectricalWorkRequestDto request);
}