namespace ThermoCal.Core.DTOs;

public class EntropyCalculationForSteadyFlowOpenSystemResponseDto
{
    public double SGenDot { get; set; }
    public double SGen { get; set; }
    public double SGenCV { get; set; }
    public double SGenCVDot { get; set; }
    public double SIn { get; set; }
    public double SOut { get; set; }
    public double S { get; set; }
    public double MDot { get; set; }
    public double MInDot { get; set; }
    public double MOutDot { get; set; }
    public double QrDot { get; set; }
    public double QOutDot { get; set; }
    public double QInDot { get; set; }
    public double Tr { get; set; }
    public double TOut { get; set; }
    public double TSur { get; set; }
}