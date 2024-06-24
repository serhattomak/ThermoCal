using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class MassFlowService: IMassFlowService
{
    public Task<CustomResponseDto<MassFlowResponseDto>> CalculateMassFlowAsync(MassFlowRequestDto request)
    {
        var response = CalculateMassFlow(request);

        return Task.FromResult(CustomResponseDto<MassFlowResponseDto>.Success(200, response));
    }

    private MassFlowResponseDto CalculateMassFlow(MassFlowRequestDto request)
    {
        double massFlow = request.MassFlow;
        double volumetricFlow = request.VolumetricFlow;
        double density = request.Density;
        double vAverage = request.VAverage;
        double a = request.A;

        massFlow = density * vAverage * a;

        return new MassFlowResponseDto
        {
            MassFlow = massFlow,
            VolumetricFlow = volumetricFlow,
            Density = density,
            VAverage = vAverage,
            A = a
        };
    }
}