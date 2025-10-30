using Microsoft.Extensions.DependencyInjection;
using APIInteraction.Services;

var services = new ServiceCollection();

services.AddHttpClient<WeatherService>(client =>
{
    client.BaseAddress = new Uri("https://api.weatherapi.com/v1/");
    client.Timeout = TimeSpan.FromSeconds(10);
    client.DefaultRequestHeaders.Add("User-Agent", "WeatherApp/1.0");
});

var serviceProvider = services.BuildServiceProvider();

var weatherService = serviceProvider.GetRequiredService<WeatherService>();

Console.WriteLine("WEATHER API CLIENT");
Console.WriteLine();

while (true)
{
    Console.Write("Nhập tên thành phố (hoặc 'exit' để thoát): ");
    var city = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(city) || city.ToLower() == "exit")
        break;
    
    var weather = await weatherService.GetCurrentWeatherAsync(city);
    
    if (weather != null)
    {
        Console.WriteLine($"\n Địa điểm: {weather.Location?.Name}, {weather.Location?.Country}");
        Console.WriteLine($"Nhiệt độ: {weather.Current?.Temp_c}°C ({weather.Current?.Temp_f}°F)");
        Console.WriteLine($"Thời tiết: {weather.Current?.Condition?.Text}");
        Console.WriteLine($"Gió: {weather.Current?.Wind_kph} km/h");
        Console.WriteLine($"Độ ẩm: {weather.Current?.Humidity}%");
        Console.WriteLine($"Thời gian: {weather.Location?.LocalTime}");
    }
    
    Console.WriteLine("\n" + new string('-', 50) + "\n");
}

Console.WriteLine("Ket thuc");