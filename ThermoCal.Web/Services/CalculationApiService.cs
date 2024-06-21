using ThermoCal.Core.DTOs;

namespace ThermoCal.Web.Services;

public class CalculationApiService
{
    private readonly ILogger<CalculationApiService> _logger;
    private readonly HttpClient _httpClient;

    public CalculationApiService(HttpClient httpClient, ILogger<CalculationApiService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<CustomResponseDto<AccelerationWorkResponseDto>> CalculateAccelerationWork(AccelerationWorkRequestDto request)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/calculation/accelerationwork", request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CustomResponseDto<AccelerationWorkResponseDto>>();
        }
        catch (HttpRequestException httpRequestException)
        {
            _logger.LogError(httpRequestException, "An error occurred while calculating acceleration work.");
            return new CustomResponseDto<AccelerationWorkResponseDto>
            {
                StatusCode = 500,
                Errors = new List<string> { httpRequestException.Message }
            };
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while calculating acceleration work.");
            return new CustomResponseDto<AccelerationWorkResponseDto>
            {
                StatusCode = 500,
                Errors = new List<string> { e.Message }
            };
        }
    }
}