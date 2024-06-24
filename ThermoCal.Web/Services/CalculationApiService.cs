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

        public async Task<CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>> CalculateAdiabaticEfficiencyOfCompressor(AdiabaticEfficiencyOfCompressorRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/AdiabaticEfficiencyOfCompressor";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic efficiency of compressor.");
                return CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of compressor.");
                return CustomResponseDto<AdiabaticEfficiencyOfCompressorResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>> CalculateAdiabaticEfficiencyOfPump(AdiabaticEfficiencyOfPumpRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/AdiabaticEfficiencyOfPump";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic efficiency of pump.");
                return CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of pump.");
                return CustomResponseDto<AdiabaticEfficiencyOfPumpResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>> CalculateAdiabaticEfficiencyOfTurbine(AdiabaticEfficiencyOfTurbineRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/AdiabaticEfficiencyOfTurbine";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic efficiency of turbine.");
                return CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of turbine.");
                return CustomResponseDto<AdiabaticEfficiencyOfTurbineResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<AdiabaticExponentResponseDto>> CalculateAdiabaticExponent(AdiabaticExponentRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/AdiabaticExponent";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AdiabaticExponentResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AdiabaticExponentResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic efficiency of turbine.");
                return CustomResponseDto<AdiabaticExponentResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic efficiency of turbine.");
                return CustomResponseDto<AdiabaticExponentResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<AdiabaticPhaseChangeResponseDto>> CalculateAdiabaticPhaseChange(AdiabaticPhaseChangeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/AdiabaticPhaseChange";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<AdiabaticPhaseChangeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<AdiabaticPhaseChangeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic index.");
                return CustomResponseDto<AdiabaticPhaseChangeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic index.");
                return CustomResponseDto<AdiabaticPhaseChangeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<CarnotHeatPumpCalculationResponseDto>> CalculateCarnotHeatPump(CarnotHeatPumpCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/CarnotHeatPump";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<CarnotHeatPumpCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<CarnotHeatPumpCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CarnotHeatPumpCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CarnotHeatPumpCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>> CalculateCarnotRefrigerator(CarnotRefrigeratorCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/CarnotRefrigerator";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CarnotRefrigeratorCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>> CalculateCompressibilityMultiplier(CompressibilityMultiplierCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/CompressibilityMultiplier";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CompressibilityMultiplierCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<CompressorCalculationResponseDto>> CalculateCompressor(CompressorCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Compressor";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<CompressorCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<CompressorCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CompressorCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<CompressorCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ConstantPressurePhaseChangeResponseDto>> CalculateConstantPressurePhaseChange(ConstantPressurePhaseChangeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ConstantPressurePhaseChange";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ConstantPressurePhaseChangeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ConstantPressurePhaseChangeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ConstantPressurePhaseChangeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ConstantPressurePhaseChangeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ConstantVolumePhaseChangeResponseDto>> CalculateConstantVolumePhaseChange(ConstantVolumePhaseChangeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ConstantVolumePhaseChange";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ConstantVolumePhaseChangeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ConstantVolumePhaseChangeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ConstantVolumePhaseChangeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ConstantVolumePhaseChangeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<DegreeOfDrynessCalculationResponseDto>> CalculateDegreeOfDryness(DegreeOfDrynessCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/DegreeOfDryness";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<DegreeOfDrynessCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<DegreeOfDrynessCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<DegreeOfDrynessCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<DegreeOfDrynessCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<DiffuserCalculationResponseDto>> CalculateDiffuser(DiffuserCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Diffuser";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<DiffuserCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<DiffuserCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<DiffuserCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<DiffuserCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ElectricalWorkResponseDto>> CalculateElectricalWork(ElectricalWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ElectricalWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ElectricalWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ElectricalWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ElectricalWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ElectricalWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>> CalculateEntropyBalanceForClosedSystem(EntropyBalanceForClosedSystemRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyBalanceForClosedSystem";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyBalanceForClosedSystemResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>> CalculateEntropyBalanceForControlVolume(EntropyBalanceForControlVolumeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyBalanceForControlVolume";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyBalanceForControlVolumeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>> CalculateEntropyForSteadyFlowOpenSystem(EntropyCalculationForSteadyFlowOpenSystemRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyCalculationForSteadyFlowOpenSystem";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyCalculationForSteadyFlowOpenSystemResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>> CalculateEntropyCalculationForUniformFlowBalancedOpenSystem(EntropyCalculationForUniformFlowBalancedOpenSystemRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyCalculationForUniformFlowBalancedOpenSystem";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyCalculationForUniformFlowBalancedOpenSystemResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyCalculationResponseDto>> CalculateEntropy(EntropyCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Entropy";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyChangeOfLiquidResponseDto>> CalculateEntropyChangeOfLiquid(EntropyChangeOfLiquidRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyChangeOfLiquid";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyChangeOfLiquidResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyChangeOfLiquidResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfLiquidResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfLiquidResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>> CalculateEntropyChangeOfPerfectGasesApproximate(EntropyChangeOfPerfectGasesApproximateRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyChangeOfPerfectGasesApproximate";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfPerfectGasesApproximateResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>> CalculateEntropyChangeOfPerfectGasesExact(EntropyChangeOfPerfectGasesExactRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyChangeOfPerfectGasesExact";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfPerfectGasesExactResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyChangeOfPureResponseDto>> CalculateEntropyChangeOfPure(EntropyChangeOfPureRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyChangeOfPure";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyChangeOfPureResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyChangeOfPureResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfPureResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfPureResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<EntropyChangeOfSolidResponseDto>> CalculateEntropyChangeOfSolid(EntropyChangeOfSolidRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/EntropyChangeOfSolid";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<EntropyChangeOfSolidResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<EntropyChangeOfSolidResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfSolidResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<EntropyChangeOfSolidResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ExergyCalculationResponseDto>> CalculateExergy(ExergyCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Exergy";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ExergyCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ExergyCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ExergyCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<ExergyCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<FlexibleRodWorkResponseDto>> CalculateFlexibleRodWork(FlexibleRodWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/FlexibleRodWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<FlexibleRodWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<FlexibleRodWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlexibleRodWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlexibleRodWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<FlowCalculationInDuctResponseDto>> CalculateFlowCalculationInDuct(FlowCalculationInDuctRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/FlowCalculationInDuct";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<FlowCalculationInDuctResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<FlowCalculationInDuctResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlowCalculationInDuctResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlowCalculationInDuctResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<FlowCalculationInPipeResponseDto>> CalculateFlowCalculationInPipe(FlowCalculationInPipeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/FlowCalculationInPipe";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<FlowCalculationInPipeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<FlowCalculationInPipeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlowCalculationInPipeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlowCalculationInPipeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<FlowWorkResponseDto>> CalculateFlowWork(FlowWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/FlowWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<FlowWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<FlowWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlowWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<FlowWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<GravityWorkResponseDto>> CalculateGravityWork(GravityWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/GravityWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<GravityWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<GravityWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<GravityWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<GravityWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<HeatAndHeatTransferResponseDto>> CalculateHeatAndHeatTransfer(HeatAndHeatTransferRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/HeatAndHeatTransfer";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<HeatAndHeatTransferResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<HeatAndHeatTransferResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatAndHeatTransferResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatAndHeatTransferResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<HeatEngineCalculationResponseDto>> CalculateHeatEngine(HeatEngineCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/HeatEngine";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<HeatEngineCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<HeatEngineCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatEngineCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatEngineCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<HeatExchangersCalculationResponseDto>> CalculateHeatExchangers(HeatExchangersCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/HeatExchangers";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<HeatExchangersCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<HeatExchangersCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatExchangersCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatExchangersCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<HeatPumpEfficiencyResponseDto>> CalculateHeatPumpEfficiency(HeatPumpEfficiencyRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/HeatPumpEfficiency";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<HeatPumpEfficiencyResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<HeatPumpEfficiencyResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatPumpEfficiencyResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating adiabatic phase change.");
                return CustomResponseDto<HeatPumpEfficiencyResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<IdealGasResponseDto>> CalculateIdealGas(IdealGasRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/IdealGas";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<IdealGasResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<IdealGasResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating ideal gas.");
                return CustomResponseDto<IdealGasResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating ideal gas.");
                return CustomResponseDto<IdealGasResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<IrreversibilityCalculationResponseDto>> CalculateIrreversibility(IrreversibilityCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Irreversibility";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<IrreversibilityCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<IrreversibilityCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating irreversibility.");
                return CustomResponseDto<IrreversibilityCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating irreversibility.");
                return CustomResponseDto<IrreversibilityCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>> CalculateIsentropicPhaseChangeOfPerfectGasesApproximate(IsentropicPhaseChangeOfPerfectGasesApproximateRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/IsentropicPhaseChangeOfPerfectGasesApproximate";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating isentropic phase change of perfect gases (approximate).");
                return CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating isentropic phase change of perfect gases (approximate).");
                return CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesApproximateResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>> CalculateIsentropicPhaseChangeOfPerfectGasesExact(IsentropicPhaseChangeOfPerfectGasesExactRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/IsentropicPhaseChangeOfPerfectGasesExact";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating isentropic phase change of perfect gases (exact).");
                return CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating isentropic phase change of perfect gases (exact).");
                return CustomResponseDto<IsentropicPhaseChangeOfPerfectGasesExactResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<IsothermalPhaseChangeResponseDto>> CalculateIsothermalPhaseChange(IsothermalPhaseChangeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/IsothermalPhaseChange";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<IsothermalPhaseChangeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<IsothermalPhaseChangeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating isothermal phase change process.");
                return CustomResponseDto<IsothermalPhaseChangeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating isothermal phase change process.");
                return CustomResponseDto<IsothermalPhaseChangeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<MassFlowResponseDto>> CalculateMassFlow(MassFlowRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/MassFlow";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<MassFlowResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<MassFlowResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating mass flow.");
                return CustomResponseDto<MassFlowResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating mass flow.");
                return CustomResponseDto<MassFlowResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<MechanicalWorkResponseDto>> CalculateMechanicalWork(MechanicalWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/MechanicalWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<MechanicalWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<MechanicalWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating mechanical work.");
                return CustomResponseDto<MechanicalWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating mechanical work.");
                return CustomResponseDto<MechanicalWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<MinimizeCompressorWorkResponseDto>> CalculateMinimizeCompressorWork(MinimizeCompressorWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/MinimizeCompressorWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<MinimizeCompressorWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<MinimizeCompressorWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while calculating MinimizeCompressorWork.");
                return CustomResponseDto<MinimizeCompressorWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while calculating MinimizeCompressorWork.");
                return CustomResponseDto<MinimizeCompressorWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<MixingChamberCalculationResponseDto>> CalculateMixingChamber(MixingChamberCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/MixingChamber";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<MixingChamberCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<MixingChamberCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while MixingChamber.");
                return CustomResponseDto<MixingChamberCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while MixingChamber.");
                return CustomResponseDto<MixingChamberCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<NozzleCalculationResponseDto>> CalculateNozzle(NozzleCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Nozzle";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<NozzleCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<NozzleCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while Nozzle.");
                return CustomResponseDto<NozzleCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while Nozzle.");
                return CustomResponseDto<NozzleCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<PolytropicPhaseChangeResponseDto>> CalculatePolytropicPhaseChange(PolytropicPhaseChangeRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/PolytropicPhaseChange";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<PolytropicPhaseChangeResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<PolytropicPhaseChangeResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while PolytropicPhaseChange.");
                return CustomResponseDto<PolytropicPhaseChangeResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while PolytropicPhaseChange.");
                return CustomResponseDto<PolytropicPhaseChangeResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<PressureCalculationResponseDto>> CalculatePressure(
            PressureCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Pressure";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<PressureCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<PressureCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while Pressure.");
                return CustomResponseDto<PressureCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while Pressure.");
                return CustomResponseDto<PressureCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<PumpCalculationResponseDto>> CalculatePump(PumpCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Pump";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<PumpCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<PumpCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while Pump.");
                return CustomResponseDto<PumpCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while Pump.");
                return CustomResponseDto<PumpCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ReducedPressureAndTemperatureResponseDto>> CalculateReducedPressureAndTemperature(ReducedPressureAndTemperatureRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ReducedPressureAndTemperature";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ReducedPressureAndTemperatureResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ReducedPressureAndTemperatureResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while ReducedPressureAndTemperature.");
                return CustomResponseDto<ReducedPressureAndTemperatureResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while ReducedPressureAndTemperature.");
                return CustomResponseDto<ReducedPressureAndTemperatureResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<RefrigeratorCalculationResponseDto>> CalculateRefrigerator(RefrigeratorCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Refrigerator";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<RefrigeratorCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<RefrigeratorCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while Refrigeration.");
                return CustomResponseDto<RefrigeratorCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while Refrigeration.");
                return CustomResponseDto<RefrigeratorCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<RefrigeratorEfficiencyResponseDto>> CalculateRefrigeratorEfficiency(RefrigeratorEfficiencyRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/RefrigeratorEfficiency";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<RefrigeratorEfficiencyResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<RefrigeratorEfficiencyResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while RefrigeratorEfficiency.");
                return CustomResponseDto<RefrigeratorEfficiencyResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while RefrigeratorEfficiency.");
                return CustomResponseDto<RefrigeratorEfficiencyResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>> CalculateReversibleContinuousFlow(ReversibleContinuousFlowCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ReversibleContinuousFlow";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while ReversibleContinuousFlow.");
                return CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while ReversibleContinuousFlow.");
                return CustomResponseDto<ReversibleContinuousFlowCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ReversibleWorkCalculationResponseDto>> CalculateReversibleWork(ReversibleWorkCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ReversibleWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ReversibleWorkCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ReversibleWorkCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while ReversibleWork.");
                return CustomResponseDto<ReversibleWorkCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while ReversibleWork.");
                return CustomResponseDto<ReversibleWorkCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<SpindleWorkResponseDto>> CalculateSpindleWork(SpindleWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/SpindleWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<SpindleWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<SpindleWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while SpindleWork.");
                return CustomResponseDto<SpindleWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while SpindleWork.");
                return CustomResponseDto<SpindleWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<SpringWorkResponseDto>> CalculateSpringWork(SpringWorkRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/SpringWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<SpringWorkResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<SpringWorkResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while SpringWork.");
                return CustomResponseDto<SpringWorkResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while SpringWork.");
                return CustomResponseDto<SpringWorkResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<SteadyFlowCalculationResponseDto>> CalculateSteadyFlow(SteadyFlowCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/SteadyFlow";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<SteadyFlowCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<SteadyFlowCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while SteadyFlow.");
                return CustomResponseDto<SteadyFlowCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while SteadyFlow.");
                return CustomResponseDto<SteadyFlowCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>> CalculateStressOfLiquidSurface(StressCalculationOfLiquidSurfaceRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/StressCalculationOfLiquidSurface";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while StressCalculationOfLiquidSurface.");
                return CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while StressCalculationOfLiquidSurface.");
                return CustomResponseDto<StressCalculationOfLiquidSurfaceResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<ThrottleValveCalculationResponseDto>> CalculateThrottleValve(ThrottleValveCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/ThrottleValve";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<ThrottleValveCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<ThrottleValveCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while ThrottleValve.");
                return CustomResponseDto<ThrottleValveCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while ThrottleValve.");
                return CustomResponseDto<ThrottleValveCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<TurbineCalculationResponseDto>> CalculateTurbine(TurbineCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/Turbine";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<TurbineCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<TurbineCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while Turbine.");
                return CustomResponseDto<TurbineCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while Turbine.");
                return CustomResponseDto<TurbineCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<UsefulWorkCalculationResponseDto>> CalculateUsefulWork(UsefulWorkCalculationRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/UsefulWork";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<UsefulWorkCalculationResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<UsefulWorkCalculationResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while UsefulWork.");
                return CustomResponseDto<UsefulWorkCalculationResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while UsefulWork.");
                return CustomResponseDto<UsefulWorkCalculationResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<VolumetricFlowResponseDto>> CalculateVolumetricFlow(VolumetricFlowRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/VolumetricFlow";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode, errorContent);

                    return CustomResponseDto<VolumetricFlowResponseDto>.Fail((int)response.StatusCode, errorContent);
                }

                var responseData = await response.Content.ReadFromJsonAsync<CustomResponseDto<VolumetricFlowResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while VolumetricFlow.");
                return CustomResponseDto<VolumetricFlowResponseDto>.Fail(500, httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while VolumetricFlow.");
                return CustomResponseDto<VolumetricFlowResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>>
            CalculateWorkConsumingDeviceEfficiency(WorkConsumingDeviceEfficiencyRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/WorkConsumingDeviceEfficiency";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode,
                        errorContent);

                    return CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>.Fail((int)response.StatusCode,
                        errorContent);
                }

                var responseData = await response.Content
                    .ReadFromJsonAsync<CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while WorkConsumingDeviceEfficiency.");
                return CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>.Fail(500,
                    httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while WorkConsumingDeviceEfficiency.");
                return CustomResponseDto<WorkConsumingDeviceEfficiencyResponseDto>.Fail(500, e.Message);
            }
        }

        public async Task<CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>>
            CalculateWorkProducingDeviceEfficiency(WorkProducingDeviceEfficiencyRequestDto request)
        {
            try
            {
                var requestUrl = "api/Calculation/WorkProducingDeviceEfficiency";
                _logger.LogInformation("Sending request to {Url} with data: {RequestData}", requestUrl, request);

                var response = await _httpClient.PostAsJsonAsync(requestUrl, request);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("API returned error: {StatusCode} {ErrorContent}", response.StatusCode,
                        errorContent);

                    return CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>.Fail((int)response.StatusCode,
                        errorContent);
                }

                var responseData = await response.Content
                    .ReadFromJsonAsync<CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>>();
                _logger.LogInformation("Received response: {@ResponseData}", responseData);

                return responseData;
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException, "An error occurred while WorkProducingDeviceEfficiency.");
                return CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>.Fail(500,
                    httpRequestException.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while WorkProducingDeviceEfficiency.");
                return CustomResponseDto<WorkProducingDeviceEfficiencyResponseDto>.Fail(500, e.Message);
            }
        }
    }
}
