namespace ThermoCal.Core.DTOs;

public class ElectricalWorkResponseDto
{
    public double W { get; set; }
    public double Q { get; set; }
    public double V { get; set; }
    public double I { get; set; }
    public double R { get; set; }
    public double TimeFirst { get; set; }
    public double TimeSecond { get; set; }

}