namespace ThermoCal.Core.DTOs;

public class AdiabaticEfficiencyOfCompressorRequestDto
{
    public double Efficiency { get; set; }
    public double WActual { get; set; }
    public double WIsentropic { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
    public double HSecondS { get; set; }
}