using Microsoft.AspNetCore.Mvc;
using SimpleWebApi;

namespace SimpleApi.Test;

public class UnitTest1
{
    private SimpleApiController controller = new SimpleApiController();

    [Fact]
    public void SimpleApiController_TestGet_ReturnsWeatherForecast()
    {
        var weatherForecast = (controller.Get().Result as OkObjectResult)?.Value as WeatherForecast[];

        Assert.NotNull(weatherForecast);
        Assert.NotNull(weatherForecast[0]);
        Assert.IsType<int>(weatherForecast[0].TemperatureC);
        Assert.True(weatherForecast[0].TemperatureC > -20);
    }

    [Fact]
    public void Test1()
    {
        
    }
}