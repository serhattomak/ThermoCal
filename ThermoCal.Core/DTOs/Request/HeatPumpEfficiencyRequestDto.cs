namespace ThermoCal.Core.DTOs;

public class HeatPumpEfficiencyRequestDto
{
    public double Efficiency { get; set; }
    public double COP { get; set; }
    public double COPRev { get; set; }
}