namespace OdataFluentUI.Controllers;

[Route("api/configs")]
[ApiController]
public class ConfigController : ControllerBase
{
    private readonly IHostEnvironment _hostEnvironment;
    public ConfigController(IHostEnvironment hostEnvironment)
    {
        ArgumentNullException.ThrowIfNull(hostEnvironment, nameof(hostEnvironment));
        _hostEnvironment = hostEnvironment;   
    }

    [HttpGet]
    public async Task<IActionResult> GetConfig()
    {
        string filePath = $"{_hostEnvironment.ContentRootPath}ConfigFiles\\config.json";
            
        string jsonText = string.Empty;
        using (StreamReader r = System.IO.File.OpenText(filePath))
        {
            jsonText = await r.ReadToEndAsync();
        }
        return Ok(jsonText);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateConfig(Config config)
    {
        string filePath = $"{_hostEnvironment.ContentRootPath}ConfigFiles\\config.json";
        using (StreamWriter streamWriter = new StreamWriter(filePath))
        {
            await streamWriter.WriteLineAsync(config.ConfigJsonText);
        }
        return NoContent();
    }
}

public class Config
{       
    public string ConfigJsonText { get; set; }
}

