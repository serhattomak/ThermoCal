namespace ThermoCal.Core.DTOs;

public class EntropyBalanceForClosedSystemRequestDto
{
    public double S { get; set; }
    public double M { get; set; }
    public double Q { get; set; }
    public double Qk { get; set; }
    public double Qr { get; set; }
    public double SFirst { get; set; }
    public double SSecond { get; set; }
    public double T { get; set; }
    public double Tk { get; set; }
    public double Tr { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
}