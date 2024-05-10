namespace ThermoCal.Core.DTOs;

public class EntropyCalculationDto
{
    public double Wb { get; set; }
    public double T { get; set; }
    public double T0 { get; set; }
    public double Tl { get; set; }
    public double Th { get; set; }
    public double Tr { get; set; }
    public double Ql { get; set; }
    public double Qh { get; set; }
    public double Qr { get; set; }
    public double QNet { get; set; }
    public double S { get; set; }
    public double SFirst { get; set; }
    public double SSecond { get; set; }
    public double Efficiency { get; set; }
    public double M { get; set; }
    public double Cv { get; set; }
}