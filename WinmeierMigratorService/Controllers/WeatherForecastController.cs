using Microsoft.AspNetCore.Mvc;
using WinmeierMigratorService.Context;

namespace WinmeierMigratorService.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly wgdb_000Context _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, wgdb_000Context context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet]
    [Route("getdata")]
    public IActionResult GetData()
    {
        var data = _context.account_movements.Take(1).ToArray();
        return Ok(data);
    }
    [HttpGet]
    [Route("get_account_documents/{quantity}")]
    public IActionResult get_account_documents(int quantity)
    {
		var data = _context.account_documents.Take(quantity).ToArray();
		return Ok(data);
	}
}
