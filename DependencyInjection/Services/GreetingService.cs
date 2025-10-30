namespace DependencyInjection.Services;

public interface IGreetingService
{
    string GetGreeting();
}

public class GreetingService : IGreetingService
{
    public string GetGreeting()
    {
        return "Hello from Service!";
    }
}