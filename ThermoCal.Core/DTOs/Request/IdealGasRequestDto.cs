namespace ThermoCal.Core.DTOs;

public class IdealGasRequestDto
{
    public double P { get; set; }
    public double V { get; set; }
    public double T { get; set; }
    public double R { get; set; }
    public double M { get; set; }
    public double N { get; set; }
    public double Ru { get; set; }
    public double VSpecific { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
}