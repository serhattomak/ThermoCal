namespace ThermoCal.Core.DTOs;

public class CarnotHeatPumpCalculationDto
{
    public double Ql { get; set; }
    public double Qh { get; set; }
    public double Efficiency { get; set; }
    public double Tl { get; set; }
    public double Th { get; set; }
    public double COPHeatRev { get; set; }
}