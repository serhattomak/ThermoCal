namespace ThermoCal.Core.DTOs;

public class ConstantVolumePhaseChangeResponseDto
{
    public double Q { get; set; }
    public double W { get; set; }
    public double M { get; set; }
    public double Cv { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double R { get; set; }
}