using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class FlowCalculationInPipeService: IFlowCalculationInPipeService
{
    public Task<CustomResponseDto<FlowCalculationInPipeResponseDto>> CalculateFlowCalculationInPipeAsync(FlowCalculationInPipeRequestDto request)
    {
        var response = CalculateFlowCalculationInPipe(request);

        return Task.FromResult(CustomResponseDto<FlowCalculationInPipeResponseDto>.Success(200, response));
    }

    private FlowCalculationInPipeResponseDto CalculateFlowCalculationInPipe(FlowCalculationInPipeRequestDto request)
    {
        double qDot = request.QDot;
        double wDot = request.WDot;
        double mDot = request.MDot;
        double cp = request.Cp;
        double t1 = request.TFirst;
        double t2 = request.TSecond;
        double volumeSpecific = request.VolumeSpecific;
        double volumeDot = request.VolumeDot;
        double pFirst = request.PFirst;

        if (qDot == 0 && (wDot != 0 && mDot != 0 && cp != 0 && t1 != 0 && t2 != 0))
        {
            qDot = CalculateQDot(mDot, cp, t1, t2, wDot);
        }

        if (wDot == 0 && (qDot != 0 && mDot != 0 && cp != 0 && t1 != 0 && t2 != 0))
        {
            wDot = CalculateWDot(mDot, cp, t1, t2, qDot);
        }

        if (mDot == 0 && (qDot != 0 && cp != 0 && t1 != 0 && t2 != 0 && wDot != 0))
        {
            mDot = CalculateMDot(qDot, cp, t1, t2, wDot);
        }

        if (cp == 0 && (qDot != 0 && mDot != 0 && t1 != 0 && t2 != 0 && wDot != 0))
        {
            cp = CalculateCp(qDot, mDot, t1, t2, wDot);
        }

        if (t1 == 0 && (qDot != 0 && mDot != 0 && cp != 0 && t2 != 0 && wDot != 0))
        {
            t1 = CalculateT1(qDot, mDot, cp, t2, wDot);
        }

        if (t2 == 0 && (qDot != 0 && mDot != 0 && cp != 0 && t1 != 0 && wDot != 0))
        {
            t2 = CalculateT2(qDot, mDot, cp, t1, wDot);
        }

        return new FlowCalculationInPipeResponseDto
        {
            QDot = qDot,
            WDot = wDot,
            MDot = mDot,
            Cp = cp,
            TFirst = t1,
            TSecond = t2,
            VolumeSpecific = volumeSpecific,
            VolumeDot = volumeDot,
            PFirst = pFirst
        };
    }

    private double CalculateQDot(double mDot, double cp, double t1, double t2, double wDot)
    {
        return (mDot * cp * (t2 - t1)) + wDot;
    }

    private double CalculateWDot(double mDot, double cp, double t1, double t2, double qDot)
    {
        return qDot - (mDot * cp * (t2 - t1));
    }

    private double CalculateMDot(double qDot, double cp, double t1, double t2, double wDot)
    {
        return (qDot - wDot) / (cp * (t2 - t1));
    }

    private double CalculateCp(double qDot, double mDot, double t1, double t2, double wDot)
    {
        return (qDot - wDot) / (mDot * (t2 - t1));
    }

    private double CalculateT1(double qDot, double mDot, double cp, double t2, double wDot)
    {
        return (qDot - wDot) / (mDot * cp) + t2;
    }

    private double CalculateT2(double qDot, double mDot, double cp, double t1, double wDot)
    {
        return (qDot - wDot) / (mDot * cp) + t1;
    }
}