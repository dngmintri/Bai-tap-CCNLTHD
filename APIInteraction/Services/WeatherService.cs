using System.Text.Json;
using System.Net.Http.Json;
using APIInteraction.Models;

namespace APIInteraction.Services;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _apiKey = "x";
    }

    public async Task<WeatherResponse> GetCurrentWeatherAsync(string city)
    {
        try
        {
            var url = $"current.json?key={_apiKey}&q={city}&aqi=no";

            Console.WriteLine($"Requesting weather data for {city} from {url}");

            var response = await _httpClient.GetFromJsonAsync<WeatherResponse>(url);

            return response;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error about HTTP: {ex.Message}");
            return null;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error about JSON: {ex.Message}");
            return null;
        }
    }
}