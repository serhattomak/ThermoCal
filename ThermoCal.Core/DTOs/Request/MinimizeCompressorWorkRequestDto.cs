namespace ThermoCal.Core.DTOs;

public class MinimizeCompressorWorkRequestDto
{
    public double W { get; set; }
    public double WRev { get; set; }
    public double P { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double T { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double K { get; set; }
    public double Cv { get; set; }
    public double Cp { get; set; }
    public double N { get; set; }
    public double R { get; set; }
    public double V { get; set; }
    public double VSpecific { get; set; }
}