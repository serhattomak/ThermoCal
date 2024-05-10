namespace ThermoCal.Core.DTOs;

public class DiffuserCalculationDto
{
    public double G { get; set; }
    public double A { get; set; }
    public double Density { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
    public double QDot { get; set; }
    public double WDot { get; set; }
    public double MDot { get; set; }
    public double MDotFirst { get; set; }
    public double MDotSecond { get; set; }
    public double ZFirst { get; set; }
    public double ZSecond { get; set; }
}