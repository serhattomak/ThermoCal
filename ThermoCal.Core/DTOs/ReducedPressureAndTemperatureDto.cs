namespace ThermoCal.Core.DTOs;

public class ReducedPressureAndTemperatureDto
{
    public double P { get; set; }
    public double Pr { get; set; }
    public double PCr { get; set; }
    public double T { get; set; }
    public double Tr { get; set; }
    public double TCr { get; set; }
    public double VSpecificR { get; set; }
    public double VSpecificActual { get; set; }
}