namespace ThermoCal.Core.DTOs;

public class PressureCalculationResponseDto
{
    public double P { get; set; }
    public double PAbsolute { get; set; }
    public double PAtm { get; set; }
    public double PVacuum { get; set; }
    public double PGauge { get; set; }
    public double N { get; set; }
    public double L { get; set; }
    public double Sigma { get; set; }
    public double A { get; set; }
    public double M { get; set; }
    public double G { get; set; }
    public double H { get; set; }
    public double Density { get; set; }
}