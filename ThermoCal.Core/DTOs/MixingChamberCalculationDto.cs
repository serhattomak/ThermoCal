namespace ThermoCal.Core.DTOs;

public class MixingChamberCalculationDto
{
    public double MDotFirst { get; set; }
    public double MDotSecond { get; set; }
    public double MDotThird { get; set; }
    public double MDotIn { get; set; }
    public double MDotOut { get; set; }
    public double HIn { get; set; }
    public double HOut { get; set; }
    public double VIn { get; set; }
    public double VOut { get; set; }
    public double ZIn { get; set; }
    public double ZOut { get; set; }
    public double G { get; set; }
}