namespace ThermoCal.Core.DTOs;

public class ReversibleContinousFlowCalculationDto
{
    public double WTr { get; set; }
    public double VSpecific { get; set; }
    public double P { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double VelocityFirst { get; set; }
    public double VelocitySecond { get; set; }
    public double ZFirst { get; set; }
    public double ZSecond { get; set; }
    public double G { get; set; }
}