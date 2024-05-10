namespace ThermoCal.Core.DTOs;

public class IrreversibilityCalculationDto
{
    public double I { get; set; }
    public double IDot { get; set; }
    public double WRev { get; set; }
    public double WSur { get; set; }
    public double Exergy { get; set; }
    public double U { get; set; }
    public double U0 { get; set; }
    public double T0 { get; set; }
    public double S { get; set; }
    public double S0 { get; set; }
    public double P0 { get; set; }
    public double V { get; set; }
    public double V0 { get; set; }
    public double M { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
    public double VSpecificFirst { get; set; }
    public double VSpecificSecond { get; set; }
}