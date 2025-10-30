namespace APIInteraction.Models;

//model đại diên cho cái dữ liệu trả về của weather api
public class WeatherResponse
{
    public Location? Location { get; set; }
    public Current? Current { get; set; }
}

public class Location
{
    public string? Name { get; set; }
    public string? Country { get; set; }
    public string? LocalTime { get; set; }
}

public class Current
{
    public decimal Temp_c { get; set; }
    public decimal Temp_f { get; set; }
    public Condition? Condition { get; set; }
    public decimal Wind_kph { get; set; }
    public int Humidity { get; set; }
}

public class Condition
{
    public string? Text { get; set; }
    public string? Icon { get; set; }
}