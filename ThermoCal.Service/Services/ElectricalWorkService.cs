using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class ElectricalWorkService: IElectricalWorkService
{
    public Task<CustomResponseDto<ElectricalWorkResponseDto>> CalculateElectricalWorkAsync(ElectricalWorkRequestDto request)
    {
        var work = CalculateElectricalWork(request);

        var response = new ElectricalWorkResponseDto
        {
            W = work
        };

        return Task.FromResult(CustomResponseDto<ElectricalWorkResponseDto>.Success(200, response));
    }

    private double CalculateElectricalWork(ElectricalWorkRequestDto request)
    {
        double work = 0;
        double i = request.I;
        double v = request.V;
        double t1 = request.TimeFirst;
        double t2 = request.TimeSecond;
        double r = request.R;

        if (v != 0)
        {
            work = i * v * (t2 - t1);
        }
        else if (r != 0)
        {
            work = (i * i * r) * (t2 - t1);
        }
        else
        {
            work=(v*v)/r*(t2-t1);
        }

        return work;
    }
}