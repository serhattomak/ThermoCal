namespace ThermoCal.Core.DTOs;

public class GibbsEquationCalculationRequestDto
{
    public double T { get; set; }
    public double TFirst { get; set; }
    public double TSecond { get; set; }
    public double P { get; set; }
    public double PFirst { get; set; }
    public double PSecond { get; set; }
    public double V { get; set; }
    public double VFirst { get; set; }
    public double VSecond { get; set; }
    public double VSpecific { get; set; }
    public double VSpecificFirst { get; set; }
    public double VSpecificSecond { get; set; }
    public double S { get; set; }
    public double SFirst { get; set; }
    public double SSecond { get; set; }
    public double H { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
    public double U { get; set; }
    public double UFirst { get; set; }
    public double USecond { get; set; }
    public double Cv { get; set; }
    public double Cp { get; set; }
}