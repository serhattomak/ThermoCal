namespace ThermoCal.Core.DTOs;

public class ConstantPressurePhaseChangeResponseDto
{
    public double Q { get; set; }
    public double W { get; set; }
    public double M { get; set; }
    public double Cp { get; set; }
    public double Cv { get; set; }
    public double P { get; set; }
    public double R { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
}