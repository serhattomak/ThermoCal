namespace ThermoCal.Core.DTOs;

public class IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto
{
    public double T { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double P { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double V { get; set; }
    public double VSpecific { get; set; }
    public double VSpecificFirst { get; set; }
    public double VSpecificSecond { get; set; }
    public double R { get; set; }
    public double K { get; set; }
    public double S { get; set; }
    public double SFirst { get; set; }
    public double SSecond { get; set; }
    public double CvAverage { get; set; }
    public double CvZero { get; set; }
    public double CpZero { get; set; }
}