﻿using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface IEntropyChangeOfPerfectGasesApproximateService
{
    Task<CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>> CalculateEntropyChangeOfPerfectGasesApproximateAsync(EntropyChangeOfPerfectGasesApproximateRequestDto request);
}