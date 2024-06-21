using ThermoCal.Core.DTOs;

namespace ThermoCal.Web.Services;

public class CalculationApiService
{
    private readonly HttpClient _httpClient;

    public CalculationApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AccelerationWorkResponseDto> CalculateAccelerationWork(AccelerationWorkRequestDto request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/calculation", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<AccelerationWorkResponseDto>();
    }
}