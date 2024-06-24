using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class DiffuserCalculationService: IDiffuserCalculationService
{
    public Task<CustomResponseDto<DiffuserCalculationResponseDto>> CalculateDiffuserAsync(DiffuserCalculationRequestDto request)
    {
        var v1=CalculateV1(request);

        var response = new DiffuserCalculationResponseDto
        {
            VFirst = v1
        };

        return Task.FromResult(CustomResponseDto<DiffuserCalculationResponseDto>.Success(200, response));
    }

    private double CalculateV1(DiffuserCalculationRequestDto request)
    {
        var v1 = Math.Sqrt((2* (request.HSecond - request.HFirst)));
        return v1;
    }
}