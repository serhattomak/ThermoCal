using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class DegreeOfDrynessCalculationService: IDegreeOfDrynessCalculationService
{
    public Task<CustomResponseDto<DegreeOfDrynessCalculationResponseDto>> CalculateDegreeOfDrynessAsync(DegreeOfDrynessCalculationRequestDto request)
    {
        var X = CalculateDegreeOfDryness(request);

        var response = new DegreeOfDrynessCalculationResponseDto
        {
            DegreeOfDryness = X
        };

        return Task.FromResult(CustomResponseDto<DegreeOfDrynessCalculationResponseDto>.Success(200, response));
    }

    private double CalculateDegreeOfDryness(DegreeOfDrynessCalculationRequestDto request)
    {
        var X = (request.MGas) / (request.MGas+request.MFluid);
        return X;
    }
}