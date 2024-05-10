namespace ThermoCal.Core.DTOs;

public class FlowCalculationInDuctDto
{
    public double QDot { get; set; }
    public double WDot { get; set; }
    public double MDot { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
    public double VolumeDot { get; set; }
    public double VolumeSpecific { get; set; }
    public double Cp { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double R { get; set; }
}