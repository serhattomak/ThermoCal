namespace ThermoCal.Core.DTOs;

public class AdiabaticPhaseChangeResponseDto
{
    public double W { get; set; }
    public double K { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
}