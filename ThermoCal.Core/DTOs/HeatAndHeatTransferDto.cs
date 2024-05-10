namespace ThermoCal.Core.DTOs;

public class HeatAndHeatTransferDto
{
    public double Q { get; set; }
    public double QConduction { get; set; }
    public double QConductionDot { get; set; }
    public double QConvection { get; set; }
    public double QConvectionDot { get; set; }
    public double QRadiation { get; set; }
    public double QRadiationDot { get; set; }
    public double QDot { get; set; }
    public double M { get; set; }
    public double K { get; set; }
    public double Sigma { get; set; }
    public double Epsilon { get; set; }
    public double A { get; set; }
    public double Time { get; set; }
    public double TimeFirst { get; set; }
    public double TimeSecond { get; set; }
    public double T { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double TSurface { get; set; }
    public double TEnvironment { get; set; }
    public double TFluid { get; set; }
    public double TAbsolute { get; set; }
    public double X { get; set; }
    public double XFirst { get; set; }
    public double XSecond { get; set; }
}