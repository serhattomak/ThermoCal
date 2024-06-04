using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IHeatAndHeatTransferService
{
    HeatAndHeatTransferResponseDto CalculateHeatAndHeatTransfer(HeatAndHeatTransferRequestDto request);
}