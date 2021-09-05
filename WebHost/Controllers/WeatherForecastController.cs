using Microsoft.AspNetCore.Mvc;
using YYC.Module.Admin;

namespace WebHost.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly AdminDbContext _adminDbContext;

    public WeatherForecastController(AdminDbContext adminDbContext)
    {
        _adminDbContext = adminDbContext;
    }

    [HttpGet]
    public async Task<bool> Refresh()
    {
        await _adminDbContext.Database.EnsureDeletedAsync();
        return await _adminDbContext.Database.EnsureCreatedAsync();
    }
}
