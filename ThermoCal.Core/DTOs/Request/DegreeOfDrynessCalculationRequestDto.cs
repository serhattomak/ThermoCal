namespace ThermoCal.Core.DTOs;

public class DegreeOfDrynessCalculationRequestDto
{
    public double DegreeOfDryness { get; set; }
    public double MGas { get; set; }
    public double MFluid { get; set; }
    public double Y { get; set; }
}