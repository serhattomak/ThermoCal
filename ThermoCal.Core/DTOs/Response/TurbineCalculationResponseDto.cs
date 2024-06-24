namespace ThermoCal.Core.DTOs;

public class TurbineCalculationResponseDto
{
    public double WMDot { get; set; }
    public double MDot { get; set; }
    public double Density { get; set; }
    public double A { get; set; }
    public double V { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
}