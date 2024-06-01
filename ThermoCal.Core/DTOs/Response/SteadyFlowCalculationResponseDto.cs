namespace ThermoCal.Core.DTOs;

public class SteadyFlowCalculationResponseDto
{
    public double Q { get; set; }
    public double W { get; set; }
    public double EFirst { get; set; }
    public double ESecond { get; set; }
    public double MFirst { get; set; }
    public double MSecond { get; set; }
    public double HIn { get; set; }
    public double HOut { get; set; }
    public double VIn { get; set; }
    public double VOut { get; set; }
    public double ZIn { get; set; }
    public double ZOut { get; set; }
    public double G { get; set; }
    public double MIn { get; set; }
    public double MOut { get; set; }
}