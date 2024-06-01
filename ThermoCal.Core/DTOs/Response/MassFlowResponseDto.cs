namespace ThermoCal.Core.DTOs;

public class MassFlowResponseDto
{
    public double MassFlow { get; set; }
    public double VolumetricFlow { get; set; }
    public double Density { get; set; }
    public double VAverage { get; set; }
    public double A { get; set; }
}