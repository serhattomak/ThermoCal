using ThermoCal.Core.DTOs;
using ThermoCal.Core.Services;

namespace ThermoCal.Service.Services;

public class HeatAndHeatTransferService : IHeatAndHeatTransferService
{
    public Task<CustomResponseDto<HeatAndHeatTransferResponseDto>> CalculateHeatAndHeatTransferAsync(HeatAndHeatTransferRequestDto request)
    {
        var response = CalculateHeatAndHeatTransfer(request);

        return Task.FromResult(CustomResponseDto<HeatAndHeatTransferResponseDto>.Success(200, response));
    }

    private HeatAndHeatTransferResponseDto CalculateHeatAndHeatTransfer(HeatAndHeatTransferRequestDto request)
    {
        double qConductionDot = request.QConductionDot;
        double qConvectionDot = request.QConvectionDot;
        double qRadiationDot = request.QRadiationDot;
        double t1 = request.TFirst;
        double t2 = request.TSecond;
        double x1 = request.XFirst;
        double x2 = request.XSecond;
        double a = request.A;
        double k = request.K;
        double h = request.H;
        double sigma = request.Sigma;
        double epsilon = request.Epsilon;
        double tSurface = request.TSurface;
        double tEnvironment = request.TEnvironment;
        double tFluid = request.TFluid;

        if (qConvectionDot == 0 && (k != 0 && a != 0 && t1 != 0 && t2 != 0 && x1 != 0 && x2 != 0))
        {
            qConvectionDot = CalculateQConvectionDot(k, a, t1, t2, x1, x2);
        }

        if (qConductionDot == 0 && (h != 0 && a != 0 && tSurface != 0 && tFluid != 0))
        {
            qConductionDot = CalculateQConductionDot(h, a, tSurface, tFluid);
        }

        if (qRadiationDot == 0 && (sigma != 0 && epsilon != 0 && a != 0 && tSurface != 0 && tEnvironment != 0))
        {
            qRadiationDot = CalculateQRadiationDot(sigma, epsilon, a, tSurface, tEnvironment);
        }

        return new HeatAndHeatTransferResponseDto
        {
            QConvectionDot = qConvectionDot,
            QConductionDot = qConductionDot,
            QRadiationDot = qRadiationDot
        };
    }

    private double CalculateQConvectionDot(double k, double a, double t1, double t2, double x1, double x2)
    {
        return k * a * (t1 - t2) / (x1 - x2);
    }

    private double CalculateQConductionDot(double h, double a, double tSurface, double tFluid)
    {
        return h * a * (tSurface - tFluid);
    }

    private double CalculateQRadiationDot(double sigma, double epsilon, double a, double tSurface, double tEnvironment)
    {
        return sigma * epsilon * a * (Math.Pow(tSurface, 4) - Math.Pow(tEnvironment, 4));
    }
}