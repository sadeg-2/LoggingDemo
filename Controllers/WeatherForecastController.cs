using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> _logger) : ControllerBase
{

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("🎯 Tester requested weather at {Time}", DateTime.UtcNow);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = "Test"
        }).ToArray();
    }


}