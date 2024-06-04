﻿using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IIsothermalPhaseChangeService
{
    IsothermalPhaseChangeResponseDto CalculateIsothermalPhaseChange(IsothermalPhaseChangeRequestDto request);
}