namespace ThermoCal.Core.DTOs;

public class HeatEngineCalculationDto
{
    public double Efficiency { get; set; }
    public double COPHeat { get; set; }
    public double COPRef { get; set; }
    public double Q { get; set; }
    public double W { get; set; }
    public double Qh { get; set; }
    public double Ql { get; set; }
    public double Th { get; set; }
    public double Tl { get; set; }
    public double WIn { get; set; }
    public double WOut { get; set; }
    public double WNet { get; set; }
    public double QIn { get; set; }
    public double QOut { get; set; }
    public double QNet { get; set; }

}