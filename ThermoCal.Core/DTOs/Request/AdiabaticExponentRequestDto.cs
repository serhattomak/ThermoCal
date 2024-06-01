namespace ThermoCal.Core.DTOs;

public class AdiabaticExponentRequestDto
{
    public double Cv { get; set; }
    public double Cp { get; set; }
    public double R { get; set; }
    public double K { get; set; }
    public double P { get; set; }
    public double M { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
}