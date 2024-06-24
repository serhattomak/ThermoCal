using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class VolumetricFlowService: IVolumetricFlowService
{
    public Task<CustomResponseDto<VolumetricFlowResponseDto>> CalculateVolumetricFlowAsync(VolumetricFlowRequestDto request)
    {
        var response = CalculateVolumetricFlow(request);

        return Task.FromResult(CustomResponseDto<VolumetricFlowResponseDto>.Success(200, response));
    }

    private VolumetricFlowResponseDto CalculateVolumetricFlow(VolumetricFlowRequestDto request)
    {
        double volumetricFlow = 0;
        double a = request.A;
        double vAverage = request.VAverage;

        volumetricFlow = a * vAverage;

        return new VolumetricFlowResponseDto
        {
           VolumetricFlow = volumetricFlow,
           A = a,
           VAverage = vAverage
        };
    }
}