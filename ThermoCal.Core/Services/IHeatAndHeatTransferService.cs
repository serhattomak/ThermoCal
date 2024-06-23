using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatAndHeatTransferService
{
    Task<CustomResponseDto<HeatAndHeatTransferResponseDto>> CalculateHeatAndHeatTransferAsync(HeatAndHeatTransferRequestDto request);
}