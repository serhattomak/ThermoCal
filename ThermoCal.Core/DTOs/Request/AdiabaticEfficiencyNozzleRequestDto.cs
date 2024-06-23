﻿namespace ThermoCal.Core.DTOs;

public class AdiabaticEfficiencyNozzleRequestDto
{
    public double Efficiency { get; set; }
    public double VelocitySecond { get; set; }
    public double VelocitySecondS { get; set; }
    public double HFirst { get; set; }
    public double HSecond { get; set; }
    public double HSecondS { get; set; }
}