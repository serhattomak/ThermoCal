namespace ThermoCal.Core.DTOs;

public class EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto
{
    public double SGen { get; set; }
    public double SIn { get; set; }
    public double SOut { get; set; }
    public double SCVFirst { get; set; }
    public double SCVSecond { get; set; }
    public double MDotIn { get; set; }
    public double MDotOut { get; set; }
    public double Qr { get; set; }
    public double Tr { get; set; }
}