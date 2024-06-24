using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class MechanicalWorkService: IMechanicalWorkService
{
    public Task<CustomResponseDto<MechanicalWorkResponseDto>> CalculateMechanicalWorkAsync(MechanicalWorkRequestDto request)
    {
        var response = CalculateMechanicalWork(request);

        return Task.FromResult(CustomResponseDto<MechanicalWorkResponseDto>.Success(200, response));
    }

    private MechanicalWorkResponseDto CalculateMechanicalWork(MechanicalWorkRequestDto request)
    {
        double w = request.W;
        double f = request.F;
        double p = request.P;
        double a = request.A;
        double vFirst = request.VFirst;
        double vSecond = request.VSecond;

        f=p*a;
        w=p*(vSecond-vFirst);

        return new MechanicalWorkResponseDto
        {
            W = w,
            F = f,
            P = p,
            A = a,
            VFirst = vFirst,
            VSecond = vSecond
        };
    }
}