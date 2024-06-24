﻿namespace ThermoCal.Core.DTOs;

public class HeatExchangersCalculationRequestDto
{
    public double MDot { get; set; }
    public double HIn { get; set; }
    public double HOut { get; set; }
    public double QDot { get; set; }
}