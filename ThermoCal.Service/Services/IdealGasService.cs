using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class IdealGasService : IIdealGasService
{
    public Task<CustomResponseDto<IdealGasResponseDto>> CalculateIdealGasAsync(IdealGasRequestDto request)
    {
        var response = CalculateIdealGas(request);

        return Task.FromResult(CustomResponseDto<IdealGasResponseDto>.Success(200, response));
    }

    private IdealGasResponseDto CalculateIdealGas(IdealGasRequestDto request)
    {
        double p = request.P;
        double v = request.V;
        double n = request.N;
        double r = request.R;
        double t = request.T;
        double m = request.M;
        double ru = request.Ru;
        double vSpecific = request.VSpecific;
        double pFirst = request.PFirst;
        double pSecond = request.PSecond;
        double vFirst = request.VFirst;
        double vSecond = request.VSecond;
        double tFirst = request.TFirst;
        double tSecond = request.TSecond;

        if (p == 0 && (v != 0 && n != 0 && r != 0 && t != 0))
        {
            p = CalculateP(v, n, r, t);
        }

        if (v == 0 && (p != 0 && n != 0 && r != 0 && t != 0))
        {
            v = CalculateV(p, n, r, t);
        }

        if (n == 0 && (p != 0 && v != 0 && r != 0 && t != 0))
        {
            n = CalculateN(p, v, r, t);
        }

        if (r == 0 && (p != 0 && v != 0 && n != 0 && t != 0))
        {
            r = CalculateR(p, v, n, t);
        }

        if (t == 0 && (p != 0 && v != 0 && n != 0 && r != 0))
        {
            t = CalculateT(p, v, n, r);
        }

        if (m == 0 && (p != 0 && v != 0 && n != 0 && r != 0 && t != 0))
        {
            m = CalculateM(p, v, n, r, t);
        }

        if (ru == 0 && (r != 0 && m != 0))
        {
            ru = CalculateRu(r, m);
        }

        if (vSpecific == 0 && (v != 0 && m != 0))
        {
            vSpecific = CalculateVSpecific(v, m);
        }

        if (pFirst == 0 && (vFirst != 0 && n != 0 && r != 0 && tFirst != 0 && pSecond != 0 && vSecond != 0 && tSecond != 0))
        {
            pFirst = CalculatePFirst(vFirst, n, r, tFirst, pSecond, vSecond, tSecond);
        }

        if (pSecond == 0 && (vFirst != 0 && n != 0 && r != 0 && tFirst != 0 && pFirst != 0 && vSecond != 0 && tSecond != 0))
        {
            pSecond = CalculatePSecond(vFirst, n, r, tFirst, pFirst, vSecond, tSecond);
        }

        if (vFirst == 0 && (pFirst != 0 && n != 0 && r != 0 && tFirst != 0 && pSecond != 0 && vSecond != 0 && tSecond != 0))
        {
            vFirst = CalculateVFirst(pFirst, n, r, tFirst, pSecond, vSecond, tSecond);
        }

        if (vSecond == 0 && (vFirst != 0 && n != 0 && r != 0 && tFirst != 0 && pFirst != 0 && pSecond != 0 && tSecond != 0))
        {
            vSecond = CalculateVSecond(vFirst, n, r, tFirst, pFirst, pSecond, tSecond);
        }

        if (tFirst == 0 && (vFirst != 0 && n != 0 && r != 0 && pFirst != 0 && pSecond != 0 && vSecond != 0 && tSecond != 0))
        {
            tFirst = CalculateTFirst(vFirst, n, r, pFirst, pSecond, vSecond, tSecond);
        }

        if (tSecond == 0 && (vFirst != 0 && n != 0 && r != 0 && tFirst != 0 && pFirst != 0 && pSecond != 0 && vSecond != 0))
        {
            tSecond = CalculateTSecond(vFirst, n, r, tFirst, pFirst, pSecond, vSecond);
        }

        return new IdealGasResponseDto
        {
            P = p,
            V = v,
            N = n,
            R = r,
            T = t,
            M = m,
            Ru = ru,
            VSpecific = vSpecific,
            PFirst = pFirst,
            PSecond = pSecond,
            VFirst = vFirst,
            VSecond = vSecond,
            TFirst = tFirst,
            TSecond = tSecond
        };
    }

    private double CalculateP(double v, double n, double r, double t)
    {
        return (n * r * t) / v;
    }

    private double CalculateV(double p, double n, double r, double t)
    {
        return (n * r * t) / p;
    }

    private double CalculateN(double p, double v, double r, double t)
    {
        return (p * v) / (r * t);
    }

    private double CalculateR(double p, double v, double n, double t)
    {
        return (p * v) / (n * t);
    }

    private double CalculateT(double p, double v, double n, double r)
    {
        return (p * v) / (n * r);
    }

    private double CalculateM(double p, double v, double n, double r, double t)
    {
        return (p * v) / (n * r * t);
    }

    private double CalculateRu(double r, double m)
    {
        return m*r;
    }

    private double CalculateVSpecific(double v, double m)
    {
        return v / m;
    }

    private double CalculatePFirst(double vFirst, double n, double r, double tFirst, double pSecond, double vSecond, double tSecond)
    {
        return (n * r * tFirst) / vFirst;
    }

    private double CalculatePSecond(double vFirst, double n, double r, double tFirst, double pFirst, double vSecond, double tSecond)
    {
        return (n * r * tSecond) / vSecond;
    }

    private double CalculateVFirst(double pFirst, double n, double r, double tFirst, double pSecond, double vSecond, double tSecond)
    {
        return (n * r * tFirst) / pFirst;
    }

    private double CalculateVSecond(double vFirst, double n, double r, double tFirst, double pFirst, double pSecond, double tSecond)
    {
        return (n * r * tSecond) / pSecond;
    }

    private double CalculateTFirst(double vFirst, double n, double r, double pFirst, double pSecond, double vSecond, double tSecond)
    {
        return (pFirst * vFirst) / (n * r);
    }

    private double CalculateTSecond(double vFirst, double n, double r, double tFirst, double pFirst, double pSecond, double vSecond)
    {
        return (pSecond * vSecond) / (n * r);
    }
}