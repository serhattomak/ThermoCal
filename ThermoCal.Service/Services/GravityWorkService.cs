using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class GravityWorkService: IGravityWorkService
{
    public GravityWorkResponseDto CalculateGravityWork(GravityWorkRequestDto request)
    {
        var result = new GravityWorkResponseDto();
        result.W = request.F * (request.ZSecond - request.ZFirst);
        return result;
    }
}