namespace ThermoCal.Core.DTOs;

public class EntropyChangeOfSolidRequestDto
{
    public double C { get; set; }
    public double CAverage { get; set; }
    public double Cv { get; set; }
    public double Cp { get; set; }
    public double T { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double S { get; set; }
    public double SFirst { get; set; }
    public double SSecond { get; set; }
    public double U { get; set; }
    public double UFirst { get; set; }
    public double USecond { get; set; }
}