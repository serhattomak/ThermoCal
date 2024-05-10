namespace ThermoCal.Core.DTOs;

public class PumpCalculationDto
{
    public double WMDot { get; set; }
    public double MDot { get; set; }
    public double G { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
    public double ZFirst { get; set; }
    public double ZSecond { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double UFirst { get; set; }
    public double USecond { get; set; }
    public double C { get; set; }
    public double VSpecific { get; set; }
}