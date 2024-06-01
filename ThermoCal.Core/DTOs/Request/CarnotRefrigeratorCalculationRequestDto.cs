namespace ThermoCal.Core.DTOs;

public class CarnotRefrigeratorCalculationRequestDto
{
    public double Ql { get; set; }
    public double Qh { get; set; }
    public double Efficiency { get; set; }
    public double Tl { get; set; }
    public double Th { get; set; }
    public double COPRefRev { get; set; }
}