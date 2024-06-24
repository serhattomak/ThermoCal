using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class EntropyChangeOfPerfectGasesApproximateService: IEntropyChangeOfPerfectGasesApproximateService
{
    public Task<CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>> CalculateEntropyChangeOfPerfectGasesApproximateAsync(EntropyChangeOfPerfectGasesApproximateRequestDto request)
    {
        var entropyChange=CalculateEntropyChangeOfPerfectGasesApproximate(request);

        var response = new EntropyChangeOfPerfectGasesApproximateResponseDto
        {
            S = entropyChange
        };

        return Task.FromResult(CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>.Success(200, response));
    }

    private double CalculateEntropyChangeOfPerfectGasesApproximate(EntropyChangeOfPerfectGasesApproximateRequestDto request)
    {
        double entropyChange = 0;

        double r= request.R;
        double rUOver= request.RuOver;
        double vSpecificFirst=request.VSpecificFirst;
        double vSpecificSecond=request.VSpecificSecond;
        double tFirst=request.TFirst;
        double tSecond=request.TSecond;
        double cpAverage=request.CpAverage;
        double cpAverageOver=request.CpAverageOver;
        double cvAverage=request.CvAverage;
        double cvAverageOver=request.CvAverageOver;

        if (cpAverageOver!=0)
        {
            entropyChange = cpAverage * Math.Log(tSecond / tFirst) + rUOver * Math.Log(vSpecificSecond / vSpecificFirst);
        }
        else if (cvAverageOver!=0)
        {
            entropyChange = cvAverage * Math.Log(tSecond / tFirst) + rUOver * Math.Log(vSpecificSecond / vSpecificFirst);
        }
        else if (cpAverage!=0)
        {
            entropyChange = cpAverage * Math.Log(tSecond / tFirst) + r * Math.Log(vSpecificSecond / vSpecificFirst);
        }
        else if (cvAverage!=0)
        {
            entropyChange = cvAverage * Math.Log(tSecond / tFirst) + r * Math.Log(vSpecificSecond / vSpecificFirst);
        }

        return entropyChange;
    }
}