using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<WeatherForecast[]> Get()
        {
            var summaries = new[]
            {
                "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli", "I love you Rafaeli"
            };
            var forecast =  Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray();
            
            return Ok(forecast);
        }
        
        
    }

    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
    
    
}
