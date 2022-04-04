namespace OdataFluentUI.Controllers;

[Route("odata")]
public class ErrorLogController : ODataController
{
    private readonly Adventureworks2019Context _adventureworks2019Context;
    public ErrorLogController(Adventureworks2019Context adventureworks2019Context)
    {
        ArgumentNullException.ThrowIfNull(adventureworks2019Context, nameof(adventureworks2019Context));
        _adventureworks2019Context = adventureworks2019Context;
    }

    [EnableQuery(PageSize = 20)]
    [HttpGet("ErrorLog")]
    public IActionResult GetAllErrorLogs()
    {
        return Ok(_adventureworks2019Context.ErrorLogs);
    }

    [EnableQuery]
    [HttpGet("ErrorLog({key})")]
    public IActionResult GetOneErrorLog(int key)
    {
        var errorLogs = _adventureworks2019Context.ErrorLogs.Where(p => p.ErrorLogID == key);

        if (!errorLogs.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(errorLogs));
    }

    [HttpPost("ErrorLog")]
    public async Task<IActionResult> CreateErrorLog([FromBody]ErrorLog errorLog)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _adventureworks2019Context.ErrorLogs.Add(errorLog);
        await _adventureworks2019Context.SaveChangesAsync();

        return CreatedAtAction("GetOneErrorLog", new { key = errorLog.ErrorLogID }, errorLog);
    }

    [HttpPatch("ErrorLog({key})")]
    public async Task<IActionResult> UpdateErrorLogPartially(int key,
        [FromBody]Delta<ErrorLog> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var currentErrorLog = await _adventureworks2019Context.ErrorLogs
            .FirstOrDefaultAsync(p => p.ErrorLogID == key);

        if (currentErrorLog == null)
        {
            return NotFound();
        }

        patch.Patch(currentErrorLog);
        await _adventureworks2019Context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("ErrorLog({key})")]
    public async Task<IActionResult> DeleteErrorLog(int key)
    {
        var currentErrorLog = await _adventureworks2019Context.ErrorLogs
            .FirstOrDefaultAsync(p => p.ErrorLogID == key);

        if (currentErrorLog == null)
        {
            return NotFound();
        }

        _adventureworks2019Context.ErrorLogs.Remove(currentErrorLog);
        await _adventureworks2019Context.SaveChangesAsync();

        return NoContent();
    }
}
