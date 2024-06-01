namespace ThermoCal.Core.DTOs;

public class CompressorCalculationRequestDto
{
    public double WMDot { get; set; }
    public double MDot { get; set; }
    public double MDotFirst { get; set; }
    public double MDotSecond { get; set; }
    public double DensityFirst { get; set; }
    public double DensitySecond { get; set; }
    public double AFirst { get; set; }
    public double ASecond { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
}