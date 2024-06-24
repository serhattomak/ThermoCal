namespace ThermoCal.Core.DTOs;

public class EntropyBalanceForControlVolumeResponseDto
{
    public double QkDot { get; set; }
    public double QrDot { get; set; }
    public double Tk { get; set; }
    public double Tr { get; set; }
    public double MDotIn { get; set; }
    public double MDotOut { get; set; }
    public double SIn { get; set; }
    public double SOut { get; set; }
    public double SGenCV { get; set; }
    public double Density { get; set; }
    public double Volume { get; set; }
    public double A { get; set; }
    public double QDot { get; set; }
    public double S { get; set; }
    public double SGenDot { get; set; }
    public double SGen { get; set; }
}