namespace ThermoCal.Core.DTOs;

public class CompressibilityMultiplierCalculationRequestDto
{
    public double Z { get; set; }
    public double P { get; set; }
    public double V { get; set; }
    public double T { get; set; }
    public double R { get; set; }
    public double VSpecific { get; set; }
    public double VSpecificActual { get; set; }
    public double VSpecificIdeal { get; set; }
}