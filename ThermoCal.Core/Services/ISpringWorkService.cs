using ThermoCal.Core.DTOs;

namespace ThermoCal.Core.Services;

public interface ISpringWorkService
{
    SpringWorkResponseDto CalculateSpringWork(SpringWorkRequestDto springWorkRequestDto);
}