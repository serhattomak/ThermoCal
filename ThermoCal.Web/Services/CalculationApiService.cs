using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ThermoCal.Core.DTOs;

namespace ThermoCal.Web.Services
{
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
                var requestUrl = "api/Calculation/AccelerationWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AccelerationWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AccelerationWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating acceleration work.");
                return CustomResponseDto<AccelerationWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating acceleration work.");
                return CustomResponseDto<AccelerationWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>> CalculateAdiabaticEfficiencyNozzle(AdiabaticEfficiencyNozzleRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/AdiabaticEfficiencyNozzle";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic efficiency nozzle.");
                return CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency nozzle.");
                return CustomResponseDto<AdiabaticEfficiencyNozzleResponseDto>.Fail(500, e.Message);
            }
        }
    }
}
