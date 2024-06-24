using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class MinimizeCompressorWorkService : IMinimizeCompressorWorkService
{
    public Task<CustomResponseDto<MinimizeCompressorWorkResponseDto>> CalculateMinimizeCompressorWorkAsync(MinimizeCompressorWorkRequestDto request)
    {
        var response = CalculateMinimizeCompressorWork(request);

        return Task.FromResult(CustomResponseDto<MinimizeCompressorWorkResponseDto>.Success(200, response));
    }

    private MinimizeCompressorWorkResponseDto CalculateMinimizeCompressorWork(MinimizeCompressorWorkRequestDto request)
    {
        double w = request.W;
        double k = request.K;
        double n = request.N;
        double r = request.R;
        double t = request.T;
        double tFirst = request.TFirst;
        double tSecond = request.TSecond;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;

        if (k == 0 && tSecond != 0)
        {
            w = (n * r * (tFirst - tSecond)) / (1 - n);
        }
        else if (k == 0 && tSecond == 0)
        {
            w = (n * r * tFirst * (1 - Math.Pow((pSecond / pFirst), ((n - 1) / n)))) / (n - 1);
        }

        if (n == 0 && tSecond != 0)
        {
            w = (k * r * (tFirst - tSecond)) / (1 - k);
        }
        else if (n == 0 && tSecond == 0)
        {
            w = (k * r * tFirst * (1 - Math.Pow((pSecond / pFirst), ((k - 1) / k)))) / (k - 1);
        }

        if (k==0&&n==0)
        {
            w=r*t*(Math.Log(pSecond/pFirst));
        }

        return new MinimizeCompressorWorkResponseDto
        {
            W = w,
            K = k,
            N = n,
            R = r,
            T = t,
            TFirst = tFirst,
            TSecond = tSecond,
            PFirst = pFirst,
            PSecond = pSecond
        };
    }
}