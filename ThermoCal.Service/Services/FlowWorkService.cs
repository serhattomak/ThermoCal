using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class FlowWorkService : IFlowWorkService
{
    public Task<CustomResponseDto<FlowWorkResponseDto>> CalculateFlowWorkAsync(FlowWorkRequestDto request)
    {
        var response = CalculateFlowWork(request);

        return Task.FromResult(CustomResponseDto<FlowWorkResponseDto>.Success(200, response));
    }

    private FlowWorkResponseDto CalculateFlowWork(FlowWorkRequestDto request)
    {
        double work = 0;
        double qDot = request.QDot;
        double wDot = request.WDot;
        double mDotIn = request.MDotIn;
        double mDotOut = request.MDotOut;
        double vIn = request.VelocityIn;
        double vOut = request.VelocityOut;
        double hIn = request.HIn;
        double hOut = request.HOut;
        double zIn = request.ZIn;
        double zOut = request.ZOut;
        double g = request.G;

        double mDot = (mDotIn + mDotOut) / 2;

        if (qDot == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && vOut != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            qDot = CalculateQDot(mDot, hIn, hOut, vIn, wDot, vOut, zIn, zOut, g);
        }

        if (wDot == 0 && (qDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && vOut != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            wDot = CalculateWDot(mDot, hIn, hOut, vIn, qDot, vOut, zIn, zOut, g);
        }

        if (mDot == 0 && (wDot != 0 && qDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && vOut != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            mDot = CalculateMDot(qDot, hIn, hOut, vIn, wDot, vOut, zIn, zOut, g);
        }

        if (hIn == 0 && (wDot != 0 && mDot != 0 && qDot != 0 && hOut != 0 && vIn != 0 && vOut != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            hIn = CalculateHin(mDot, qDot, hOut, vIn, wDot, vOut, zIn, zOut, g);
        }

        if (hOut == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && qDot != 0 && vIn != 0 && vOut != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            hOut = CalculateHout(mDot, hIn, qDot, vIn, wDot, vOut, zIn, zOut, g);
        }

        if (vIn == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && qDot != 0 && vOut != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            vIn = CalculateVin(mDot, hIn, hOut, qDot, wDot, vOut, zIn, zOut, g);
        }

        if (vOut == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && qDot != 0 && zIn != 0 && zOut != 0 && g != 0))
        {
            vOut = CalculateVout(mDot, hIn, hOut, vIn, wDot, qDot, zIn, zOut, g);
        }

        if (zIn == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && vOut != 0 && qDot != 0 && zOut != 0 && g != 0))
        {
            zIn = CalculateZin(mDot, hIn, hOut, vIn, wDot, vOut, qDot, zOut, g);
        }

        if (zOut == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && vOut != 0 && zIn != 0 && qDot != 0 && g != 0))
        {
            zOut = CalculateZout(mDot, hIn, hOut, vIn, wDot, vOut, zIn, qDot, g);
        }

        if (g == 0 && (wDot != 0 && mDot != 0 && hIn != 0 && hOut != 0 && vIn != 0 && vOut != 0 && zIn != 0 && zOut != 0 && qDot != 0))
        {
            g = CalculateG(mDot, hIn, hOut, vIn, wDot, vOut, zIn, zOut, qDot);
        }

        return new FlowWorkResponseDto
        {
            QDot = qDot,
            WDot = wDot,
            MDotIn = mDot,
            MDotOut = mDot,
            HIn = hIn,
            HOut = hOut,
            VelocityIn = vIn,
            VelocityOut = vOut,
            ZIn = zIn,
            ZOut = zOut,
            G = g
        };
    }

    private double CalculateQDot(double mDot, double hIn, double hOut, double vIn, double wDot, double vOut, double zIn, double zOut, double g)
    {
        return (mDot * (hOut - hIn)) + (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2) + (mDot * g * (zOut - zIn)) + wDot;
    }

    private double CalculateWDot(double mDot, double hIn, double hOut, double vIn, double qDot, double vOut, double zIn, double zOut, double g)
    {
        return qDot - (mDot * (hOut - hIn)) - (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2) - (mDot * g * (zOut - zIn));
    }

    private double CalculateMDot(double qDot, double hIn, double hOut, double vIn, double wDot, double vOut, double zIn, double zOut, double g)
    {
        return (qDot - wDot) / ((hOut - hIn) + ((Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2) + (g * (zOut - zIn)));
    }

    private double CalculateHin(double mDot, double qDot, double hOut, double vIn, double wDot, double vOut, double zIn, double zOut, double g)
    {
        return (qDot - wDot - (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2) - (mDot * g * (zOut - zIn))) / mDot;
    }

    private double CalculateHout(double mDot, double hIn, double qDot, double vIn, double wDot, double vOut, double zIn, double zOut, double g)
    {
        return hIn + ((qDot - wDot - (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2) - (mDot * g * (zOut - zIn))) / mDot);
    }

    private double CalculateVin(double mDot, double hIn, double hOut, double qDot, double wDot, double vOut, double zIn, double zOut, double g)
    {
        return Math.Sqrt((2 * ((qDot - wDot) - (mDot * (hOut - hIn)) - (mDot * g * (zOut - zIn))) / mDot) + Math.Pow(vOut, 2));
    }

    private double CalculateVout(double mDot, double hIn, double hOut, double vIn, double wDot, double qDot, double zIn, double zOut, double g)
    {
        return Math.Sqrt((2 * ((qDot - wDot) - (mDot * (hOut - hIn)) - (mDot * g * (zOut - zIn))) / mDot) + Math.Pow(vIn, 2));
    }

    private double CalculateZin(double mDot, double hIn, double hOut, double vIn, double wDot, double vOut, double qDot, double zOut, double g)
    {
        return ((qDot - wDot) - (mDot * (hOut - hIn)) - (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2)) / (mDot * g) + zOut;
    }

    private double CalculateZout(double mDot, double hIn, double hOut, double vIn, double wDot, double vOut, double zIn, double qDot, double g)
    {
        return ((qDot - wDot) - (mDot * (hOut - hIn)) - (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2)) / (mDot * g) + zIn;
    }

    private double CalculateG(double mDot, double hIn, double hOut, double vIn, double wDot, double vOut, double zIn, double zOut, double qDot)
    {
        return ((qDot - wDot) - (mDot * (hOut - hIn)) - (mDot * (Math.Pow(vOut, 2) - Math.Pow(vIn, 2)) / 2)) / (mDot * (zOut - zIn));
    }
}