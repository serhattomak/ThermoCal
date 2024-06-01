namespace ThermoCal.Core.DTOs;

public class EntropyChangeOfPerfectGasesApproximateResponseDto
{
    public double T { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double S { get; set; }
    public double SFirst { get; set; }
    public double SSecond { get; set; }
    public double SFirstOver { get; set; }
    public double SSecondOver { get; set; }
    public double U { get; set; }
    public double UFirst { get; set; }
    public double USecond { get; set; }
    public double Cp { get; set; }
    public double CpAverage { get; set; }
    public double CpAverageOver { get; set; }
    public double Cv { get; set; }
    public double CvAverage { get; set; }
    public double CvAverageOver { get; set; }
    public double R { get; set; }
    public double Ru { get; set; }
    public double RuOver { get; set; }
    public double VSpecific { get; set; }
    public double VSpecificFirst { get; set; }
    public double VSpecificSecond { get; set; }
    public double P { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
}